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