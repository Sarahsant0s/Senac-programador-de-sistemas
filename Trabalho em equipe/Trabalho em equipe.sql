CREATE TABLE IF NOT EXISTS produto (
		id INT PRIMARY KEY AUTO_INCREMENT,
		nome VARCHAR(100) NOT NULL,
		data_tempo DATETIME NOT NULL
        );
        
CREATE TABLE IF NOT EXISTS estoque (
		id INT PRIMARY KEY AUTO_INCREMENT,
        quantidade VARCHAR(20) NOT NULL,
        id_produto INT NOT NULL,
        data_tempo DATETIME NOT NULL
        );
        