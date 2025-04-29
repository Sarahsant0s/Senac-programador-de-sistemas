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
    
    INSERT INTO clientes (
		Nome,
		Idade,
		Cidade,
		Valor)
    
	VALUES
		('Carlos','45','São Paulo','2500.00'),
		('Mariana','32','Rio de Janeiro','3200.50'),
		('Pedro','27','Belo Horizonte','1500.75'),
		('Fernanda','38','Curitiba','4200.00');
    
    SELECT 
    *
	FROM
		clientes
	WHERE
		Cidade = 'Rio de Janeiro';
    
    SELECT 
		*
	FROM
		clientes
	WHERE
		Valor > '2000.00'
	ORDER BY Valor DESC;
    
	SELECT 
		Nome, Idade
    FROM 
		Clientes 
    WHERE 
		Idade > '30';
    
    SELECT 
		*
    FROM
		clientes 
    WHERE 
		Idade >= '25'
	AND Idade <= '40'
	ORDER BY Idade;
    
    SELECT 
		*
    FROM 
		clientes
	WHERE
		Nome LIKE  'F%';
    
    SELECT 
		*
	FROM
		clientes
	WHERE
		Cidade != 'São Paulo'
    AND Cidade != 'Curitiba';
    
    CREATE TABLE IF NOT EXISTS pedido (
		id INT PRIMARY KEY AUTO_INCREMENT,
		cliente_id iNT NOT NULL,
		Valor INT NOT NULL,
		Data_pedido DATETIME NOT NULL
    );
    
    INSERT INTO pedido(
		cliente_id,
		Valor,
		Data_pedido)
    
    VALUES 
		('1','500.00','2024-03-10'),
		('2','1200.00','2024-03-12'),
		('3','300.50','2024-03-15'),
		('1','800.00','2024-03-18');
    
    SELECT 
		SUM(cliente_id)
	FROM
		pedido;
    
    SELECT 
		AVG(Valor)
    FROM 
		pedido;
    
    SELECT 
		cliente_id, SUM(Valor)
    FROM 
		pedido
    GROUP BY
		cliente_id;
    
    DROP TABLE clientes;
    DROP TABLE pedido;
    
    CREATE TABLE IF NOT EXISTS cliente (
		id INT PRIMARY KEY AUTO_INCREMENT,
		Nome VARCHAR(20) NOT NULL,
		Cidade VARCHAR(20) NOT NULL
    );
	
    INSERT INTO cliente(
		Nome,
		Cidade)
		
    VALUES 
		('Carlos','São Paulo'),
		('Mariana','Rio de Janeiro'),
		('Pedro', 'Belo Horizonte'),
		('Fernanda', 'Curitiba');
		
	CREATE TABLE IF NOT EXISTS pedido (
		id INT PRIMARY KEY AUTO_INCREMENT,
		cliente_id INT NOT NULL,
		valor INT NOT NULL
    );
	
    INSERT INTO pedido(
		cliente_id,
		valor)
    
    VALUES 
		(1,500.00),
		(2,1200.00),
		(3, 300.50),
		(1, 800.00);
    
    SELECT 
		pedido.id,
		cliente.nome,
		pedido.valor
    FROM
		pedido
	INNER JOIN 
		cliente ON cliente.id = pedido.cliente_id;
	
    SELECT 
		cliente.id,
		cliente.nome,
        pedido.valor
	FROM
		cliente
	LEFT JOIN 
		pedido ON cliente.id =  pedido.cliente_id;
	
    SELECT
		cliente.nome, 
        pedido.valor
	FROM 
		pedido
	INNER JOIN 
		cliente ON pedido.cliente_id = cliente.id
	WHERE 
		pedido.valor > (SELECT AVG(pedido.valor) FROM pedido);
        
	SELECT 
		cliente.nome,
		pedido.valor
	FROM
		pedido
	INNER JOIN 
		cliente ON pedido.cliente_id = cliente.id
	WHERE 
		pedido.valor > 1000;
		
	INSERT INTO cliente (
		nome,
        cidade
	)
    
    VALUES 
    ('Rafael','Porto Alegre');
    
    UPDATE
		cliente
	SET
		valor = valor + (valor * 0.10);
        
	DELETE FROM
		pedido
	WHERE
		pedido.valor < 500;
	

    
    DROP TABLE cliente;
    
    
    
		
        
    
    
    
    
    