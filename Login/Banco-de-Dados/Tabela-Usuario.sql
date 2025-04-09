CREATE DATABASE senac_sarah;

CREATE TABLE senac_sarah (
	id INT KEY AUTO_INCREMENT,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR (20) NOT NULL
    );
    
    INSERT INTO senac_sarah (email, senha) VALUES
    ('neymar.jr@email.com','Bruna@123'),
    ('pablo.vitar@email.com','12345Abc!'),
    ('sukuna.silva@email.com','Sete7sete!');
    
    SELECT 
		*
	FROM
		senac_sarah
	WHERE 
		email = 'pablo.vitar@email.com';