CREATE LOGIN todolistuser   
    WITH PASSWORD = '340$Uuxwp7Mcxo7Khy';  
GO

CREATE DATABASE todolist;

USE todolist;

-- Cria um usuário para o banco.  
CREATE USER todolistuser FOR LOGIN todolistuser;  
GO 

USE todolist;
GO

ALTER ROLE db_owner ADD MEMBER todolistuser;

SELECT  Id,
		ListName
FROM dbo.tasklists


--deletar
DROP DATABASE todolist;
GO

-- deletar user
DROP LOGIN todolistuser   
GO