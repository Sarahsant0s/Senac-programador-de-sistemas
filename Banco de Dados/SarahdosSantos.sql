-- TABELA PRODUTO
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

  -- TABELA FORNECEDOR  
CREATE TABLE IF NOT EXISTS fornecedor (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	cidade VARCHAR (20) NOT NULL
);

SELECT 
	*
FROM produto
;

INSERT INTO fornecedor (
	nome,
    cidade)
    
VALUES
('TechBrasil','São Paulo'),
('Computech','Rio de Janeiro'),
('Moveis&Co','Curitiba');

-- TABELA PEDIDO
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
-- TABELA CLIENTE
CREATE TABLE IF NOT EXISTS cliente (
		id INT PRIMARY KEY AUTO_INCREMENT,
		nome VARCHAR(20) NOT NULL,
		cidade VARCHAR(20) NOT NULL,
        idade INT NOT NULL
    );
	
    INSERT INTO cliente(
		nome,
		cidade,
        idade
        )
		
    VALUES 
		('João Silva','São Paulo',35),
		('Maria Santos','Belo Horizonte',28),
		('Carlos Lima','Rio de Janeiro',42),
		('Fernanda Rocha', 'Curitiba',30);
        
	-- EXERCÍCIO 2.1.
	SELECT 
		categoria,
        preco
	FROM
		produto
	WHERE
		preco > 3000.00
	ORDER BY preco DESC;
    
    -- EXERCÍCIO 2.2.
    SELECT 
		nome,
        cidade,
        idade
	FROM
		cliente
	WHERE
		cidade != 'São Paulo' AND
        idade > 30;
        
    -- EXERCÍCIO 2.3.    
	SELECT 
		*
	FROM 
		pedido
	WHERE
		data_pedido >= '2024-03-10'
        AND data_pedido <= '2024-03-15'
        ORDER BY data_pedido;
        
     -- EXERCÍCIO 2.4.   
	SELECT 
		*
	FROM
		produto
	WHERE
		estoque < 10
		ORDER BY estoque;
        
	-- EXERCÍCIO 2.5.
    SELECT 
		*
	FROM
		fornecedor
	WHERE
        nome LIKE 'T%' AND 
        cidade != 'Rio de Janeiro';
        
	-- EXERCÍCIO AGREGAÇÃO E AGRUPAMENTO 1.
	SELECT
		categoria,
		AVG(preco) AS Valor_medio
    FROM 
		produto
        GROUP BY categoria;
        
     -- EXERCÍCIO AGREGAÇÃO E AGRUPAMENTO 2.   
	SELECT 
		cliente_id, COUNT(quantidade) AS Quantidade_de_Pedidos
	FROM 
		pedido
	GROUP BY
		cliente_id;
        
     -- EXERCÍCIO AGREGAÇÃO E AGRUPAMENTO 3.   
	SELECT
		categoria,
        SUM(estoque) AS Total_Produtos
	FROM
		produto
	GROUP BY
		categoria;
        
	-- EXERCÍCIO AGREGAÇÃO E AGRUPAMENTO 4.
    SELECT 
		id,
        produto_id,
        quantidade AS Quantidade_Maxima
	FROM
		pedido
    ORDER BY quantidade DESC
    LIMIT 1;
    
    INSERT INTO cliente (
		nome,
        cidade,
        idade
        )
        
	VALUES
		('Sarah Santos','São Paulo', 19);
        
     -- EXERCÍCIO AGREGAÇÃO E AGRUPAMENTO 5.  
    SELECT
		cidade,
		COUNT(cliente.nome) AS Quantidade_Cientes_por_Cidade
	FROM
		cliente
	GROUP BY cidade
	ORDER BY cidade DESC;
    
    -- JUNÇÕES 1.
    SELECT 
		fornecedor.nome AS Nome_Fornecedor,
		produto.nome
	FROM
		produto
	INNER JOIN
		fornecedor ON produto.fornecedor_id = fornecedor.id
	ORDER BY fornecedor.nome;
    
    -- JUNÇÕES 2.
	SELECT 
		pedido.data_pedido,
		pedido.id, 
		cliente.nome AS Nome_Cliente,
		produto.nome AS Produto
	FROM 
		pedido
	INNER JOIN 
		cliente ON pedido.cliente_id = cliente.id
	INNER JOIN 
		produto ON pedido.produto_id = produto.id
	ORDER BY pedido.data_pedido;
    
    -- JUNÇÕES 3.
	SELECT 
		pedido.id,
        cliente.nome AS Nome_Cliente,
        produto.nome AS Produto,
        fornecedor.nome AS Nome_Fornecedor
	FROM 
		pedido
	INNER JOIN 
		cliente ON pedido.cliente_id = cliente.id
	INNER JOIN 
		produto ON pedido.produto_id = produto.id
	INNER JOIN 
		fornecedor ON produto.fornecedor_id = fornecedor.id;
       
	-- JUNÇÕES 4.
	SELECT 
		cliente.nome AS Nome_Cliente,
		SUM(pedido.quantidade) AS Total_de_Produtos
	FROM 
		pedido
	INNER JOIN 
		cliente ON pedido.cliente_id = cliente.id
	GROUP BY cliente.nome;
    
	-- SUBCONSULTAS E MODIFICAÇÕES DE DADOS 1.
    
    SELECT 
		nome, 
		categoria, 
		preco
	FROM 
		produto p1
	WHERE 
		preco > (
    SELECT 
		AVG(preco)
    FROM 
		produto p2
    WHERE 
		p1.categoria = p2.categoria
);
	
    -- SUBCONSULTAS E MODIFICAÇÕES DE DADOS 2.
	UPDATE 
		produto
	SET 
		preco = preco * 1.10
	WHERE 
		categoria = 'Eletrônicos';
    
    -- SUBCONSULTAS E MODIFICAÇÕES DE DADOS 3.
	DELETE FROM 
		pedido
	WHERE 
		cliente_id IN (
    SELECT 
		id
    FROM 
		cliente
    WHERE 
		cidade = 'Curitiba'
);

	-- SUBCONSULTAS E MODIFICAÇÕES DE DADOS 4.
	INSERT INTO 
		cliente (nome, cidade, idade)
	VALUES 
		('Ricardo Lopes', 'Porto Alegre', 38);
      
	-- SUBCONSULTAS E MODIFICAÇÕES DE DADOS 5.
	INSERT INTO pedido (
		produto_id,
		quantidade,
		data_pedido,
        cliente_id)
	VALUES (
    (SELECT 
		id 
	FROM 
		produto 
	WHERE 
		nome = 'Notebook Y'),
		2,
		'2024-03-25',
    (SELECT 
		id 
	FROM 
		cliente 
	WHERE 
		nome = 'João Silva')
);

	-- SUBCONSULTAS E MODIFICAÇÕES DE DADOS 6.
	SELECT DISTINCT 
		cliente.nome
	FROM 
		cliente
	INNER JOIN 
		pedido ON cliente.id = pedido.cliente_id
	INNER JOIN
		produto ON pedido.produto_id = produto.id
	WHERE 
		produto.categoria = 'Móveis';



    
	
        
		
	
     


