SELECT 
    *
FROM
    livro
WHERE
    data_publicacao >= '1990-01-01 00:00:00'
AND 
	data_publicacao <= '1999-12-31 23:59:59';
    
SELECT * FROM livro
WHERE (data_publicacao) BETWEEN '1990-01-01 00:00:00' and '1999-12-31 23:59:59';

SELECT * FROM livro 
WHERE YEAR (data_publicacao) BETWEEN '1990' and '1999';

SELECT autor FROM livro;

SELECT DISTINCT (autor) FROM lçivro;

SELECT sum(preco), AVG(preco), max(preco), min(preco) FROM livro 
WHERE autor = 'rafael souza';

SELECT count(id) FROM livro;

SELECT * FROM livro
ORDER BY titulo DESC;