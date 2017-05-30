SELECT * FROM Unidade

INSERT INTO Unidade(nomeUnidade, bloco, ruaInterna, numAP, id_Proprietario, id_Divida, id_Endereco, id_Inquilino) VALUES('Primavera', 'BL 02', 'Rua Treze', 3, 2, 1, 1, 1)
INSERT INTO Unidade(nomeUnidade, bloco, ruaInterna, numAP, id_Proprietario, id_Divida, id_Endereco, id_Inquilino) VALUES('Primavera', 'BL 03', 'Rua Treze', 4, 2, 1, 1, 1)
INSERT INTO Unidade(nomeUnidade, bloco, ruaInterna, numAP, id_Proprietario, id_Divida, id_Endereco, id_Inquilino) VALUES('Primavera', 'BL 04', 'Rua Cinco', 5, 2, 1, 1, 1)
INSERT INTO Unidade(nomeUnidade, bloco, ruaInterna, numAP, id_Proprietario, id_Divida, id_Endereco, id_Inquilino) VALUES('Primavera', 'BL 05', 'Rua Treze', 3, 2, 1, 1, 1)
INSERT INTO Unidade(nomeUnidade, bloco, ruaInterna, numAP, id_Proprietario, id_Divida, id_Endereco, id_Inquilino) VALUES('Primavera', 'BL 06', 'Rua Três',  2, 2, 1, 1, 1)
INSERT INTO Unidade(nomeUnidade, bloco, ruaInterna, numAP, id_Proprietario, id_Divida, id_Endereco, id_Inquilino) VALUES('Primavera', 'BL 07', 'Rua Um',    4, 2, 1, 1, 1)
INSERT INTO Unidade(nomeUnidade, bloco, ruaInterna, numAP, id_Proprietario, id_Divida, id_Endereco, id_Inquilino) VALUES('Primavera', 'BL 08', 'Rua Dez',   4, 2, 1, 1, 1)

INSERT INTO Proprietario(nome, cpf, rg, dataNascimento, estadoCivil, id_Divida, id_Endereco, id_Contato) VALUES('Vagner Moura', '324533322', '78464849', 03/02/1982, 'Casado', 4, 2, 1)


SELECT * FROM Divida
SELECT * FROM Unidade
SELECT * FROM Proprietario

INSERT INTO Divida(nomeUnidade, bloco, ruaInterna, numAP, id_Proprietario, id_Divida, id_Endereco, id_Inquilino) VALUES('Primavera', 'BL 08', 'Rua Dez',   4, 2, 1, 1, 1)




	SELECT  a.nome, a.cpf, c.valorDivida
	
	FROM Proprietario AS A
	INNER JOIN Unidade AS B
		on b.id_Unidade = b.id_Unidade
	INNER JOIN Divida AS C on b.id_divida = c.id_divida
	WHERE c.valorDivida = (SELECT max(valorDivida) FROM divida)
	Order by c.valorDivida desc limit 1                      

	SELECT * FROM Divida
	SELECT * FROM Unidade
	SELECT * FROM Proprietario
