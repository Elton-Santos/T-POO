CREATE TABLE Contatos(
	id_Contatos int NOT NULL PRIMARY KEY IDENTITY(1,1),
	residencial varchar(15),
	celular varchar(15),
	email varchar(30)
);

CREATE TABLE Proprietario(
	id_Proprietario int NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome varchar(15),
	cpf varchar(15),
	rg varchar(30),
	dataNascimento DATETIME,
	estadoCivil int,
	id_Unidade int FOREIGN KEY REFERENCES Unidade(id_Unidade)
);

CREATE TABLE Endereco(
	id_indereco int NOT NULL PRIMARY KEY IDENTITY(1,1),
	logradouro varchar(15),
	numero varchar(15),
	complemento varchar(30),
	cep varchar(15),
	estado varchar(20),
	uf varchar(2),
	bairro varchar(50),
	id_Proprietario int FOREIGN KEY REFERENCES Proprietario,
	id_Inquilino int FOREIGN KEY REFERENCES Inquilino,
	id_Unidade int FOREIGN KEY REFERENCES Unidade
);

CREATE TABLE Inquilino(
	id_Inquilino int NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome varchar(15),
	cpf varchar(15),
	rg varchar(30),
	dataNascimento DATETIME,
	estadoCivil int,
	id_Unidade int FOREIGN KEY REFERENCES Unidade(id_Unidade)
);

CREATE TABLE Divida(
	id_Divida int NOT NULL PRIMARY KEY IDENTITY(1,1),
	descrcaoDivida varchar(15),
	dataVencimento varchar(15),
	valorDivida varchar(30),
	id_Proprietario int FOREIGN KEY REFERENCES Proprietario(id_Proprietario),
	id_Inquilino int FOREIGN KEY REFERENCES Inquilino(id_Inquilino),
	id_Unidade int FOREIGN KEY REFERENCES Unidade(id_Unidade)
);

CREATE TABLE Unidade(
	id_Unidade int NOT NULL PRIMARY KEY IDENTITY(1,1),
	nomeUnidade varchar(15),
	bloco varchar(15),
	ruaInterna varchar(30),
	id_Proprietario int FOREIGN KEY REFERENCES Proprietario(id_Proprietario),
	id_Inquilino int FOREIGN KEY REFERENCES Inquilino(id_Inquilino),
	id_Divida int FOREIGN KEY REFERENCES Divida(id_Divida)
);


