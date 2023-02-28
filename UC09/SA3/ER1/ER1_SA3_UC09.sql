--Comando para criação do banco de dados
CREATE DATABASE TesteSegurancaBE11;

--comando para colocar um banco em uso
 USE TesteSegurancaBE11;

 --criar tabela	
 CREATE TABLE Usuarios (
 Id INT PRIMARY KEY IDENTITY,
 Email VARCHAR(100) UNIQUE NOT NULL,
 Senha VARCHAR(50) NOT NULL
 );

 --inserção de valores
INSERT INTO Usuarios VALUES ('email@mail.com', '1234');

--selecionar usuarios do banco
SELECT * FROM Usuarios;

--hashear a senha
SELECT Email, HASHBYTES('MD2',Senha) FROM Usuarios;

SELECT Email, HASHBYTES('MD2',Senha)AS 'Senha Hash' FROM Usuarios Where Id = 1;

SELECT Email, HASHBYTES('MD4',Senha)AS 'Senha Hash' FROM Usuarios Where Id = 1;

SELECT Email, HASHBYTES('SHA_256',Senha)AS 'Senha Hash' FROM Usuarios Where Id = 1;

SELECT Email, HASHBYTES('SHA_512',Senha)AS 'Senha Hash' FROM Usuarios Where Id = 1;

