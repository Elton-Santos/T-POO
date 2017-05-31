USE [master]
GO
/****** Object:  Database [PROJETOS]    Script Date: 30/05/2017 19:09:50 ******/
CREATE DATABASE [PROJETOS] ON  PRIMARY 
( NAME = N'PROJETOS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.ELTON\MSSQL\DATA\PROJETOS.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PROJETOS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.ELTON\MSSQL\DATA\PROJETOS_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PROJETOS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PROJETOS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PROJETOS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PROJETOS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PROJETOS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PROJETOS] SET ARITHABORT OFF 
GO
ALTER DATABASE [PROJETOS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PROJETOS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PROJETOS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PROJETOS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PROJETOS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PROJETOS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PROJETOS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PROJETOS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PROJETOS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PROJETOS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PROJETOS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PROJETOS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PROJETOS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PROJETOS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PROJETOS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PROJETOS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PROJETOS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PROJETOS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PROJETOS] SET  MULTI_USER 
GO
ALTER DATABASE [PROJETOS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PROJETOS] SET DB_CHAINING OFF 
GO
USE [PROJETOS]
GO
/****** Object:  Table [dbo].[Contato]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contato](
	[id_Contato] [int] IDENTITY(1,1) NOT NULL,
	[residencial] [varchar](20) NULL,
	[celular] [varchar](20) NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Contato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Divida]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Divida](
	[id_Divida] [int] IDENTITY(1,1) NOT NULL,
	[descricaoDivida] [varchar](20) NOT NULL,
	[dataVencimento] [date] NOT NULL,
	[valorDivida] [money] NOT NULL,
	[id_Proprietario] [int] NULL,
	[id_Inquilino] [int] NULL,
	[id_Unidade] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Divida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Endereco](
	[id_Endereco] [int] IDENTITY(1,1) NOT NULL,
	[logradouro] [varchar](50) NOT NULL,
	[numero] [varchar](10) NULL,
	[complemento] [varchar](20) NULL,
	[cep] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
	[uf] [char](2) NULL,
	[bairro] [varchar](50) NULL,
	[id_Proprietario] [int] NULL,
	[id_Inquilino] [int] NULL,
	[id_Unidade] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Endereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inquilino]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inquilino](
	[id_Inquilino] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](15) NULL,
	[rg] [varchar](15) NULL,
	[dataNascimento] [date] NULL,
	[estadoCivil] [varchar](10) NULL,
	[id_Contato] [int] NULL,
	[id_Divida] [int] NULL,
	[id_Endereco] [int] NULL,
	[id_Unidade] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Inquilino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proprietario]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proprietario](
	[id_Proprietario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](15) NULL,
	[rg] [varchar](15) NULL,
	[dataNascimento] [date] NULL,
	[estadoCivil] [varchar](10) NULL,
	[id_Contato] [int] NULL,
	[id_Divida] [int] NULL,
	[id_Endereco] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Proprietario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Unidade]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unidade](
	[id_Unidade] [int] IDENTITY(1,1) NOT NULL,
	[nomeUnidade] [varchar](50) NOT NULL,
	[bloco] [varchar](20) NULL,
	[ruaInterna] [varchar](50) NULL,
	[numAP] [varchar](10) NULL,
	[id_Proprietario] [int] NULL,
	[id_Inquilino] [int] NULL,
	[id_Divida] [int] NULL,
	[id_Endereco] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Unidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Contato] ON 

INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (1, N'3476-8842', N'982324748', N'cooperton4@hotmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (2, N'3333-3333', N'2222-2222', N'elton@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (4, N'11999999999', N'11999999999', N'11')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (5, N'112222222', N'112222222', N'jordan@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (6, N'1132497473', N'1197882372', N'patricia@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (7, N'734434343', N'739837273', N'victor@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (8, N'1124675833', N'1193746582', N'Silviosantos.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (9, N'1124675833', N'1193746582', N'gugu@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (10, N'1124675833', N'1193746582', N'xuxa@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (11, N'1124675833', N'1193746582', N'Jascson@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (12, N'1124675833', N'1193746582', N'vimdiesel@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (13, N'1124675833', N'1193746582', N'Paola@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (14, N'1124675833', N'1193746582', N'Paloma.junior@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (15, N'1124675833', N'1193746582', N'Fausto@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (16, N'1124675833', N'1193746582', N'Galvão@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (17, N'1124675833', N'1193746582', N'ana maria@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (18, N'1124675833', N'1193746582', N'elton@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (19, N'1124675833', N'1193746582', N'joãoPimenta@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (20, N'1124675833', N'1193746582', N'fabio@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (21, N'1124675833', N'1193746582', N'sureya@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (22, N'1124675833', N'1193746582', N'henrique@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (23, N'1124675833', N'1193746582', N'miqueias@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (24, N'1124675833', N'1193746582', N'jurandir.junior@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (25, N'1124675833', N'1193746582', N'jordan@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (26, N'1124675833', N'1193746582', N'rafael@gmail.com')
INSERT [dbo].[Contato] ([id_Contato], [residencial], [celular], [email]) VALUES (27, N'1124675833', N'1193746582', N'caique@gmail.com')
SET IDENTITY_INSERT [dbo].[Contato] OFF
SET IDENTITY_INSERT [dbo].[Divida] ON 

INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (1, N'IPTU', CAST(N'2017-02-13' AS Date), 50.0000, 1, 1, 4)
INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (2, N'Aluguel', CAST(N'2017-05-01' AS Date), 50.0000, 2, 3, 4)
INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (3, N'Água', CAST(N'2017-05-13' AS Date), 50.0000, 3, 2, 4)
INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (5, N'IPTU', CAST(N'2017-01-29' AS Date), 50.0000, 4, 5, 4)
INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (6, N'Condomínio', CAST(N'2017-06-12' AS Date), 50.0000, 5, 6, 4)
INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (7, N'Luz', CAST(N'2017-06-11' AS Date), 50.0000, 6, 7, 4)
INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (8, N'Telefone', CAST(N'2017-06-20' AS Date), 50.0000, 2, 4, 4)
INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (9, N'Comdomínio', CAST(N'2017-02-16' AS Date), 50.0000, 4, 3, 4)
INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (10, N'Água', CAST(N'2017-03-19' AS Date), 50.0000, 2, 7, 4)
INSERT [dbo].[Divida] ([id_Divida], [descricaoDivida], [dataVencimento], [valorDivida], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (15, N'IPTU', CAST(N'2017-02-13' AS Date), 350.0000, 1, 1, 2)
SET IDENTITY_INSERT [dbo].[Divida] OFF
SET IDENTITY_INSERT [dbo].[Endereco] ON 

INSERT [dbo].[Endereco] ([id_Endereco], [logradouro], [numero], [complemento], [cep], [estado], [uf], [bairro], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (1, N'Rua São Digo', N'21', N'Interlagos', N'0004989', N'São PAulo', N'SP', N'Campo Grande', 1, 2, 1)
INSERT [dbo].[Endereco] ([id_Endereco], [logradouro], [numero], [complemento], [cep], [estado], [uf], [bairro], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (2, N'Rua Doze de Maio', N'2340', N'PEdreira', N'32340230', N'Rio de Janeiro', N'RJ', N'São Golsaulo', 2, 1, 2)
INSERT [dbo].[Endereco] ([id_Endereco], [logradouro], [numero], [complemento], [cep], [estado], [uf], [bairro], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (3, N'Rua Antonio do Campo', N'247', N'Interlagos', N'04459000', N'São PAulo', N'SP', N'PEdreira', 2, 1, 3)
INSERT [dbo].[Endereco] ([id_Endereco], [logradouro], [numero], [complemento], [cep], [estado], [uf], [bairro], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (4, N'Rua Nove', N'34', N're', N'435353', N'Bahia', N'BA', N'Vila Velha', 1, 2, 4)
INSERT [dbo].[Endereco] ([id_Endereco], [logradouro], [numero], [complemento], [cep], [estado], [uf], [bairro], [id_Proprietario], [id_Inquilino], [id_Unidade]) VALUES (7, N'Rua São Diogo', N'21', N'Interlagos', N'004475560', N'São Paulo', N'SP', N'Campo Grande', 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Endereco] OFF
SET IDENTITY_INSERT [dbo].[Inquilino] ON 

INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (1, N'Patricia Ribeiro', N'3333333333', N'3333333333', CAST(N'2017-07-04' AS Date), N'CAsada', NULL, NULL, NULL, NULL)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (2, N'Victor', N'324223234', N'324243242', CAST(N'2017-07-24' AS Date), N'Solteiro', NULL, NULL, NULL, NULL)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (4, N'Gugu Liberato', N'58395859330', N'444959604', CAST(N'1976-05-13' AS Date), N'Solteiro', 1, 2, 1, 2)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (5, N'Xuxa Meneguel', N'49304954039', N'433467865', CAST(N'1979-03-19' AS Date), N'Solteiro', 2, 3, 1, 3)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (7, N'Vim Diesel', N'58394853034', N'857839544', CAST(N'1990-08-14' AS Date), N'Solteiro', 4, 5, 1, 5)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (8, N'Paola de Oliveira', N'58630340675', N'759343094', CAST(N'1987-09-13' AS Date), N'Solteiro', 5, 6, 1, 6)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (9, N'Paloma Duarte', N'56385953395', N'764835045', CAST(N'1934-12-24' AS Date), N'Casado', 6, 7, 1, 7)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (12, N'Gugu Liberato', N'58395859330', N'444959604', CAST(N'1976-05-13' AS Date), N'Solteiro', 1, 2, 1, 2)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (13, N'Xuxa Meneguel', N'49304954039', N'433467865', CAST(N'1979-03-19' AS Date), N'Solteiro', 2, 3, 1, 3)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (15, N'Vim Diesel', N'58394853034', N'857839544', CAST(N'1990-08-14' AS Date), N'Solteiro', 4, 5, 1, 5)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (16, N'Paola de Oliveira', N'58630340675', N'759343094', CAST(N'1987-09-13' AS Date), N'Solteiro', 5, 6, 1, 6)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (17, N'Paloma Duarte', N'56385953395', N'764835045', CAST(N'1934-12-24' AS Date), N'Casado', 6, 7, 1, 7)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (18, N'Fausto Silva', N'85958393435', N'754933495', CAST(N'1934-02-21' AS Date), N'Casado', 7, 8, 1, 8)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (21, N'Silvio Santos', N'21340494395', N'32018450X', CAST(N'1980-01-01' AS Date), N'Casado', 10, 1, 1, 1)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (22, N'Gugu Liberato', N'58395859330', N'444959604', CAST(N'1976-05-13' AS Date), N'Solteiro', 1, 2, 1, 2)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (23, N'Xuxa Meneguel', N'49304954039', N'433467865', CAST(N'1979-03-19' AS Date), N'Solteiro', 2, 3, 1, 3)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (25, N'Vim Diesel', N'58394853034', N'857839544', CAST(N'1990-08-14' AS Date), N'Solteiro', 4, 5, 1, 5)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (26, N'Paola de Oliveira', N'58630340675', N'759343094', CAST(N'1987-09-13' AS Date), N'Solteiro', 5, 6, 1, 6)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (27, N'Paloma Duarte', N'56385953395', N'764835045', CAST(N'1934-12-24' AS Date), N'Casado', 6, 7, 1, 7)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (28, N'Fausto Silva', N'85958393435', N'754933495', CAST(N'1934-02-21' AS Date), N'Casado', 7, 8, 1, 8)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (29, N'Galvão Bueno', N'95850383224', N'665537232', CAST(N'1956-03-27' AS Date), N'Solteiro', 8, 9, 1, 9)
INSERT [dbo].[Inquilino] ([id_Inquilino], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco], [id_Unidade]) VALUES (30, N'Ana Maria Braga', N'75837923378', N'653292033', CAST(N'1930-10-30' AS Date), N'Casado', 9, 10, 1, 10)
SET IDENTITY_INSERT [dbo].[Inquilino] OFF
SET IDENTITY_INSERT [dbo].[Proprietario] ON 

INSERT [dbo].[Proprietario] ([id_Proprietario], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco]) VALUES (2, N'Elton dos Santos', N'1111111111', N'1111111111', CAST(N'2017-08-13' AS Date), N'Casado', 1, 1, 2)
INSERT [dbo].[Proprietario] ([id_Proprietario], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco]) VALUES (3, N'Jordan Senna', N'2222222222', N'2222222222', CAST(N'2017-02-08' AS Date), N'Solteiro', 2, 2, 1)
INSERT [dbo].[Proprietario] ([id_Proprietario], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco]) VALUES (6, N'Gugu Liberato', N'58395859330', N'444959604', CAST(N'1976-05-13' AS Date), N'Solteiro', 1, 2, 1)
INSERT [dbo].[Proprietario] ([id_Proprietario], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco]) VALUES (7, N'Xuxa Meneguel', N'49304954039', N'433467865', CAST(N'1979-03-19' AS Date), N'Solteiro', 2, 3, 1)
INSERT [dbo].[Proprietario] ([id_Proprietario], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco]) VALUES (9, N'Vim Diesel', N'58394853034', N'857839544', CAST(N'1990-08-14' AS Date), N'Solteiro', 4, 5, 1)
INSERT [dbo].[Proprietario] ([id_Proprietario], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco]) VALUES (10, N'Paola de Oliveira', N'58630340675', N'759343094', CAST(N'1987-09-13' AS Date), N'Solteiro', 5, 6, 1)
INSERT [dbo].[Proprietario] ([id_Proprietario], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco]) VALUES (11, N'Paloma Duarte', N'56385953395', N'764835045', CAST(N'1934-12-24' AS Date), N'Casado', 6, 7, 1)
INSERT [dbo].[Proprietario] ([id_Proprietario], [nome], [cpf], [rg], [dataNascimento], [estadoCivil], [id_Contato], [id_Divida], [id_Endereco]) VALUES (12, N'Fausto Silva', N'85958393435', N'754933495', CAST(N'1934-02-21' AS Date), N'Casado', 7, 8, 1)
SET IDENTITY_INSERT [dbo].[Proprietario] OFF
SET IDENTITY_INSERT [dbo].[Unidade] ON 

INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (1, N'Primavera', N'BL 01', N'Rua 10', N'03', NULL, NULL, 1, NULL)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (2, N'Santos', N'02', N'Sem Nome', N'40', 2, NULL, 2, NULL)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (3, N'1', N'04', N'sem', N'3', 3, NULL, 3, NULL)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (4, N'Salvador', N'', N'', N'45', 2, NULL, NULL, NULL)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (8, N'Primavera', N'BL 02', N'Rua Treze', N'3', 2, NULL, 1, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (9, N'Primavera', N'BL 02', N'Rua Treze', N'3', 2, 1, 1, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (10, N'350', N'BL 03', N'Rua Treze', N'4', 2, 1, 1, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (11, N'Primavera', N'BL 04', N'Rua Cinco', N'5', 2, 1, 1, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (12, N'Primavera', N'BL 05', N'Rua Treze', N'3', 2, 1, 1, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (13, N'Primavera', N'BL 06', N'Rua Três', N'2', 2, 1, 1, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (14, N'Primavera', N'BL 07', N'Rua Um', N'4', 2, 1, 1, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (15, N'Primavera', N'BL 08', N'Rua Dez', N'4', 2, 1, 1, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (26, N'Primavera', N'BL 08', N'Rua Dez', N'4', 2, 1, 1, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (29, N'Condomínio Primavera', N'BLOCO 2', N'RUA DEZ', N'02', 2, 2, 8, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (34, N'Condomínio Primavera', N'BLOCO 7', N'RUA TREZE', N'02', 7, 7, 3, 1)
INSERT [dbo].[Unidade] ([id_Unidade], [nomeUnidade], [bloco], [ruaInterna], [numAP], [id_Proprietario], [id_Inquilino], [id_Divida], [id_Endereco]) VALUES (36, N'Condomínio Primavera', N'BLOCO 9', N'RUA QUATORZE', N'02', 9, 9, NULL, 1)
SET IDENTITY_INSERT [dbo].[Unidade] OFF
ALTER TABLE [dbo].[Inquilino]  WITH CHECK ADD FOREIGN KEY([id_Contato])
REFERENCES [dbo].[Contato] ([id_Contato])
GO
ALTER TABLE [dbo].[Inquilino]  WITH CHECK ADD FOREIGN KEY([id_Divida])
REFERENCES [dbo].[Divida] ([id_Divida])
GO
ALTER TABLE [dbo].[Inquilino]  WITH CHECK ADD FOREIGN KEY([id_Endereco])
REFERENCES [dbo].[Endereco] ([id_Endereco])
GO
ALTER TABLE [dbo].[Proprietario]  WITH CHECK ADD FOREIGN KEY([id_Contato])
REFERENCES [dbo].[Contato] ([id_Contato])
GO
ALTER TABLE [dbo].[Proprietario]  WITH CHECK ADD FOREIGN KEY([id_Divida])
REFERENCES [dbo].[Divida] ([id_Divida])
GO
ALTER TABLE [dbo].[Proprietario]  WITH CHECK ADD FOREIGN KEY([id_Endereco])
REFERENCES [dbo].[Endereco] ([id_Endereco])
GO
ALTER TABLE [dbo].[Unidade]  WITH CHECK ADD FOREIGN KEY([id_Divida])
REFERENCES [dbo].[Divida] ([id_Divida])
GO
ALTER TABLE [dbo].[Unidade]  WITH CHECK ADD FOREIGN KEY([id_Endereco])
REFERENCES [dbo].[Endereco] ([id_Endereco])
GO
ALTER TABLE [dbo].[Unidade]  WITH CHECK ADD FOREIGN KEY([id_Inquilino])
REFERENCES [dbo].[Inquilino] ([id_Inquilino])
GO
ALTER TABLE [dbo].[Unidade]  WITH CHECK ADD FOREIGN KEY([id_Proprietario])
REFERENCES [dbo].[Proprietario] ([id_Proprietario])
GO
/****** Object:  StoredProcedure [dbo].[INADIMPLENTE]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[INADIMPLENTE]
	
AS
BEGIN
	
	SELECT  
	nome,valorDivida, descricaoDivida
FROM 
	Divida

JOIN Proprietario ON Divida.valorDivida  < 0

END

GO
/****** Object:  StoredProcedure [dbo].[NewSelectCommand]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        prop.nome, unid.nomeUnidade
FROM            Unidade AS unid INNER JOIN
                         Proprietario AS prop ON unid.id_Proprietario = prop.id_Proprietario
GO
/****** Object:  StoredProcedure [dbo].[PROPRIETARIO_UNIDADE]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Elton>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PROPRIETARIO_UNIDADE] 
	
	
AS
BEGIN
	SELECT 
	nome, nomeUnidade
FROM
	Proprietario
JOIN Unidade ON Unidade.id_Proprietario = Proprietario.id_Proprietario AND Proprietario.nome = Proprietario.nome
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Inserir_Inquilino]    Script Date: 30/05/2017 19:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Inserir_Inquilino]

@nome varchar, 
@cpf varchar, 
@rg varchar,
@dataNascimento datetime,  
@estadoCivil varchar, 

@logradouro varchar, 
@numero varchar, 
@complemento varchar, 
@cep varchar, 
@bairro varchar, 
@estado varchar, 
@uf char,

@residencial varchar,
@celular varchar,
@email varchar,

@nomeUnidade varchar, 
@bloco varchar, 
@ruaInterna varchar, 
@numAP varchar

AS
BEGIN

INSERT INTO Inquilino(nome, cpf, rg, dataNascimento, estadoCivil)
VALUES (@nome, @cpf, @rg, @dataNascimento, @estadoCivil)

INSERT INTO Endereco (logradouro, numero, complemento, cep, bairro, estado, uf)
VALUES (@logradouro, @numero, @complemento, @cep, @bairro, @estado, @uf)

INSERT INTO Contato(residencial, celular, email)
VALUES (@residencial, @celular, @email)

INSERT INTO Unidade(nomeUnidade, bloco, ruaInterna, numAP)
VALUES(@nomeUnidade, @bloco, @ruaInterna, @numAP)

DECLARE
@InquilinoCadastrado int,
@EnderecoCadastrado int,
@ContatoCadastrado int,
@UnidadeCadastrada int

SET @EnderecoCadastrado = IDENT_CURRENT('dbo.Inquilino')
SET @InquilinoCadastrado = IDENT_CURRENT('dbo.Endereco')
SET @ContatoCadastrado = IDENT_CURRENT('dbo.Contato')
SET @UnidadeCadastrada = IDENT_CURRENT('dbo.Unidade')

END
GO
USE [master]
GO
ALTER DATABASE [PROJETOS] SET  READ_WRITE 
GO
