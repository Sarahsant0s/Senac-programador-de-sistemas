CREATE TABLE IF NOT EXISTS produto (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	categoria VARCHAR(20) NOT NULL,
	preco DECIMAL (8,2) NOT NULL,
	estoque INT NOT NULL,
	fornecedor_id INT NOT NULL
);

SELECT 
	*
FROM produto;

INSERT INTO produto (
	nome,
    categoria,
    preco,
    estoque,
    fornecedor_id)
    
VALUES
('Celular x','Eletrônicos',2500.00,30,1),
('Notebook Y','Eletrônicos',4800.00,15,2),
('Mesa de Madeira','Móveis',750.00,10,3),
('Cadeira Z','Móveis',300.00,25,3),
('TV 50"','Eletrônicos',3500.00,8,1);

    
CREATE TABLE IF NOT EXISTS fornecedor (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	cidade VARCHAR (20) NOT NULL
);

SELECT 
	*
FROM fornecedor;

INSERT INTO produto (
	nome,
    cidade)
    
VALUES
('TechBrasil','São Paulo'),
('Computech','Rio de Janeiro'),
('Moveis&Co','Curitiba');

CREATE TABLE IF NOT EXISTS pedido (
		id INT PRIMARY KEY AUTO_INCREMENT,
		produto_id INT NOT NULL,
		quantidade INT NOT NULL,
        data_pedido DATETIME NOT NULL,
        cliente_id INT NOT NULL
    );
	
    INSERT INTO pedido(
		produto_id,
        quantidade,
        data_pedido,
		cliente_id
        )
    
    VALUES 
		(1,2,'2024-03-10',1),
		(3,1,'2024-03-11',2),
        (2,1,'2024-03-15',3),
		(5,3,'2024-03-18',1),
		(4,4,'2024-03-20',4);





