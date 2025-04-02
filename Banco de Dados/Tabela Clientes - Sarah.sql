CREATE TABLE IF NOT EXISTS clientes (
    id INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(50) NOT NULL,
    Idade VARCHAR(10) NOT NULL,
    Cidade VARCHAR(50) NOT NULL,
    Valor VARCHAR(30) NOT NULL
);
    
    SELECT 
    *
    FROM
    clientes;