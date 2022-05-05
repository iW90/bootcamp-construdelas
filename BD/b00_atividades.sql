/*Selecione todas as compras (orders)  que estão com o envio atrasado (orders.required_date)*/

	/* enviadas com atraso */
	SELECT *
		FROM sales.orders
		WHERE shipped_date > REQUIRED_DATE;

	/* não enviadas (sem shipped_date) */
	SELECT *
		FROM sales.orders
		WHERE shipped_date IS NULL;

/*Selecione todas as compras (orders) da cliente (customers) 'Araceli Golden do estado da CA' e os items de cada compra (order_items)*/

	SELECT b.order_id, c.item_id
		FROM sales.customers a /* o AS pode ser ocultado */
		INNER JOIN sales.orders b on a.customer_id = b.customer_id
		INNER JOIN sales.order_items c ON b.order_id = c.order_id
		WHERE a.first_name = 'Araceli' AND a.last_name = 'Golden' AND a.state = 'CA';

/*Faça um relatório de produtos (products) disponíveis no estoque (stocks)  trazendo também informações sobre sua marca (brands) e categoria (categories)*/

	SELECT a.product_name, b.quantity, c.category_name, d.brand_name
		FROM production.products a
		INNER JOIN production.stocks b ON a.product_id = b.product_id
		INNER JOIN production.categories c ON a.category_id = c.category_id
		INNER JOIN production.brands d ON a.brand_id = d.brand_id;

 /*Existe algum cliente (customer) que nunca comprou nada (orders) ? */
	INSERT INTO sales.customers(first_name, last_name, phone, email, street, city, state, zip_code)
		VALUES ('Mariana', 'Mendes', NULL, 'mariana@mariana.com', 'Rua Park', 'Orchard', 'NY', 14127);

	SELECT a.*, b.customer_id
		FROM sales.customers a
		LEFT JOIN sales.orders b ON a.customer_id = b.customer_id
		WHERE b.order_id IS NULL;

/*Execute o seguinte comando (selecionando apenas o codigo abaixo) e verifique a tabela brands*/
select * from production.brands;

begin transaction;
	insert into production.brands(brand_name) values ('Kaloi');
	insert into production.brands(brand_name) values ('Outra');
	commit;

/*Agora execute este e verifique a tabela brands*/
begin transaction;
	insert into production.brands(brand_name) values ('Bike1');
	insert into production.brands(brand_name) values ('Bike2');
	rollback;

/*Qual a diferença entre a transação com commit no final e a com rollback?*/
/* O commit salva o conteúdo do begin transaction, e o rollback desfaz o conteúdo do begin transaction. */
