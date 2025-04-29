CREATE TABLE endereco (
	id INT PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR (100) NOT NULL,
    numero VARCHAR (10) NOT NULL,
    complemento VARCHAR (50) NULL,
    bairro VARCHAR (50) NOT NULL,
    municipio VARCHAR (50) NOT NULL,
    estado VARCHAR (2) NOT NULL,
    cep VARCHAR (8) NOT NULL
    );
 
    INSERT INTO endereco
    (logradouro, 
    numero, 
    bairro, 
    municipio, 
    estado, 
    cep
    )
    
    VALUES 
    ('Rua Luiza Carioba','72','Jardim Monte Verde','São Paulo','SP','04851519'),
    ('Rua Pera Natal','140','Jardim São Bernardo','São Paulo', 'SP','04863320'),
    ('Rua Joaquim Pires','165','Vila Narciso', 'São Paulo','SP','04851803');