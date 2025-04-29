CREATE TABLE cliente (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR (100) NOT NULL,
    nome_social VARCHAR (100) NOT NULL,
    data_nascimento DATE NOT NULL,
    email VARCHAR (50) NOT NULL UNIQUE,
    telefone VARCHAR (11)NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco)
	REFERENCES endereco (id)
    );

    INSERT INTO cliente 
    (
    nome,
    data_nascimento,
    email,
    telefone,
    tipo,
    etnia,
    genero,
    estrangeiro,
    id_endereco
    )
    
    VALUES
    ('Sarah','24/01/2006','sarahcosta8989@email.com','11977373074', 0, 1, 1, 0, (SELECT id FROM endereco WHERE logradouro = "Rua Luiza Carioba")),
    ('Leticia','09/03/2004','leticiapurple@email.com','11940028922', 0, 0, 1, 0, (SELECT id FROM endereco WHERE logradouro = "Rua Pera Natal")),
    ('Claudia','06/03/1989','claudiasantosdecor@email.com','11979511319', 0, 0, 1, 0, (SELECT id FROM endereco WHERE logradouro = "Rua Joaquim Pires")); 
   
