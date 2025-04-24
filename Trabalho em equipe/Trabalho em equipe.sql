	CREATE TABLE IF NOT EXISTS produto (
			id INT PRIMARY KEY AUTO_INCREMENT,
			nome VARCHAR(100) NOT NULL,
			dat DATETIME NOT NULL
			);
			
	CREATE TABLE IF NOT EXISTS estoque (
			id INT PRIMARY KEY AUTO_INCREMENT,
			quantidade VARCHAR(20) NOT NULL,
			id_produto INT NOT NULL,
			id_dataEntrada DATETIME NOT NULL,
			FOREIGN KEY (id_produto)
			REFERENCES produto (id),
            FOREIGN KEY (id_dataEntrada)
			REFERENCES produto (id)
            
			);
			
		
	CREATE TABLE IF NOT EXISTS vendas (
			id INT PRIMARY KEY AUTO_INCREMENT,
			id_produto INT NOT NULL,
			id_estoque INT NOT NULL,
			data_tempo DATETIME NOT NULL,
			FOREIGN KEY (id_produto)
			REFERENCES produto (id),
			FOREIGN KEY (id_estoque)
			REFERENCES estoque (id)
			);

	INSERT INTO produto (
		nome,
		data_tempo
		) 
	VALUES 
		(@nome, @data_tempo);

	DELETE FROM produto WHERE id = @id;

	INSERT INTO estoque (
		quantidade,
        id_produto,
        data_tempo
        )
	VALUES 
		(@quantidade, @id_produto, @data_tempo);

