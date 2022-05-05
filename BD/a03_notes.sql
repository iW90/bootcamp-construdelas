SELECT * FROM sales.orders;
SELECT * FROM sales.staffs;



/* Subconsulta */
SELECT *
	FROM sales.orders
		WHERE staff_id IN ( -- Ou = no lugar de IN se quiser que retorne apenas um valor
			SELECT staff_id
			FROM sales.staffs
			WHERE staff_id = 2);

SELECT *
	FROM sales.orders a
		WHERE EXISTS (
			SELECT staff_id
			FROM sales.staffs b
			WHERE a.staff_id = b.staff_id AND b.first_name = 'Mireya');

/* Criando uma view */
CREATE VIEW clientes_de_novayork AS
SELECT * 
	FROM sales.customers
	WHERE state = 'NY';

SELECT * FROM clientes_de_novayork
	WHERE city = 'Orchard Park';

DROP VIEW clientes_de_novayork;

/* Criando uma outra view */
CREATE VIEW mountainbikes AS
SELECT *
	FROM production.products a
	INNER JOIN production.categories b ON a.category_id = b.category_id
WHERE b.category_name = 'Mountain Bikes';

/* Criando um procedure */
CREATE PROCEDURE procurar_por_cidade @cidade VARCHAR(30) AS
SELECT * 
	FROM sales.customers
	WHERE city = @cidade

EXEC procurar_por_cidade @cidade = 'Orchard Park';

/* Criando outra procedure */
CREATE PROCEDURE inserir_cliente @nome VARCHAR(255), @sobrenome VARCHAR(255), @phone VARCHAR(25),
@email VARCHAR(255), @street VARCHAR(255), @city VARCHAR(50), @state VARCHAR(25), @zipcode VARCHAR(5)
	AS
	INSERT INTO sales.customers(first_name, last_name, phone, email, street, city, state, zip_code)
	VALUES (@nome, @sobrenome, @phone, @email, @street, @city, @state, @zipcode);

	EXEC inserir_cliente @nome = 'WoMakers', @sobrenome = 'Code', @phone = NULL,
	@email = 'womakerscode@org.com', @street = 'Rua x', @city = 'São Paulo', 
	@state = 'SP', @zipcode = '12345'

	SELECT * FROM sales.customers;

/* Criando triggers */
CREATE TRIGGER sales.log_insert_costumers
	ON sales.customers
	AFTER INSERT
	AS 
	BEGIN
		DECLARE @nome VARCHAR(255)
		SELECT @nome = inserted.first_name FROM inserted --inserted é uma tabela virtual que é gerada
		PRINT CONCAT('Inserido ', @nome);
	END

DROP TRIGGER sales.log_insert_costumers;

SELECT * FROM sales.customers;

INSERT INTO sales.customers(first_name, last_name, phone, email, street, city, state, zip_code)
VALUES ('TRIGGER', 'TESTE', '', 'teste', 'teste', 'Americana', 'SP', '23456');





	/* ANOTAÇÕES */
/*
# Subconsultas
	Possuem 3 tipos básicos:
	• Funcionam como listas no IN ou com operações de comparações como ANY ou ALL
		SELECT * FROM table WHERE id IN (select id from table2)
	
	• Utilizadas com operadores de comparação (=), e neste caso devem retornar apenas um valor.
		SELECT * FROM table WHERE id = (select id from table 2 where idnew = x)
	
	• Testes de existência utilizados com EXISTS
		SELECT * FROM table WHERE EXISTS (select id from table2)


# Views
	Tabela virtual baseada no resultado de um comando SQL
	Você pode adicionar comandos SQL e funções em uma view e apresentar os dados como se eles estivessem vindo de uma tabela.

	Exemplo:
	CREATE VIEW nome_da_view AS
		SELECT nome_coluna1, nome_coluna2, CONCAT(nome_coluna3, nome_coluna4)
		FROM tabela;
		
	Para ler:
	SELECT * FROM nome_da_view;

	Para excluir:
	DROP VIEW nome_da_view;


# Procedures
	Uma procedure (ou stored procedure/ou proc) é um código SQL que você pode salvar para ser reutilizado várias vezes.
	
	CREATE PROCEDURE nome_procedure
	AS
	INSERT INTO nome_tabela(nome_coluna) VALUES('x');
	
	Para executar: 
	EXEC nome_procedure;

	• Outro modelo:
		CREATE PROCEDURE nome_procedure @nome_coluna VARCHAR(30)
		AS
		SELECT * FROM nome_tabela
		WHERE nome_coluna = @nome_coluna
		
		EXEC nome_procedure @nome_coluna = 'valor';


# Triggers
	Parecidas com store procedures, porém são executadas automaticamente quando alguma ação ocorre em algum objeto do banco (DML Triggers).
	Elas podem ser de 3 tipos:
		• INSERT (executada ao inserir dados em uma tabela)
		• UPDATE (executada ao fazer o update de dados em uma tabela)
		• DELETE (executada ao deletar dados de uma tabela)
		
		CREATE TRIGGER schema.nome_trigger
		ON nome_tabela
		AFTER [insert, delete, update]
		AS
		INSERT INTO nome_tabela(nome_coluna) VALUES('x');

	Para desabilitar:
		DISABLE TRIGGER nome_trigger ON nome_tabela;
		DISABLE TRIGGER ALL ON nome_tabela;
		DISABLE TRIGGER ALL ON nome_database;

	Para habilitar:
		ENABLE TRIGGER nome_trigger ON nome_tabela;
		ENABLE TRIGGER ALL ON nome_tabela;
		ENABLE TRIGGER ALL ON nome_database;

	Para excluir:
		DROP TRIGGER schema.nome_trigger;
*/