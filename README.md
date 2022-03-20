# ProjetoMakeYourPlate
Projeto desenvolvido na faculdade, este projeto é contituido por cadastro de ingredientes e cadastro de pratos. Onde na tela principal faz uma busca pelos ingredientes contidos no modo de preparo do prato

Intuito testar meus conhecimentos em C#

## Imagem referente a tela inicial do projeto
![image](https://user-images.githubusercontent.com/31415863/159174193-10b53f18-adc2-492f-ba48-36f450f61cc2.png)


## Para Funcionar é necessario criar um banco de dados com esta estrutura abaixo
### Banco utilizado MySQL.

```

CREATE DATABASE makeyourplate;

CREATE TABLE ingredientes (
    id INT AUTO_INCREMENT,
    nome VARCHAR(255),
    PRIMARY KEY(id)
);

CREATE TABLE pratos (
	id INT AUTO_INCREMENT,
    nome VARCHAR(20),
    preco FLOAT,
    modopreparo VARCHAR(2000),
    imagem LONGBLOB,
    PRIMARY KEY(id)
)

```