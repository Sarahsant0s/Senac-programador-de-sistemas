SELECT 
    livro.id,
    livro.titulo,
    livro.data_publicacao,
    livro.numero_paginas,
    livro.preco,
    livro.isbn,
    livro.apagado,
    livro.criado_em,
    genero.nome AS genero,
    editora.nome AS editora,
    autor.nome AS autor
FROM
    livro,
    genero,
    editora,
    autor
WHERE
    livro.id_genero = genero.id
        AND livro.id_editora = editora.id
        AND livro.id_autor = autor.id;
        
SELECT 
	livro.id,
	livro.titulo,
	livro.data_publicacao,
	livro.numero_paginas,
	livro.preco,
	livro.isbn,
	genero.nome AS genero,
	editora.nome AS editora,
	autor.nome AS autor1
FROM
	livro 
		INNER JOIN 
	genero ON livro.id_genero - genero.id
		INNER JOIN
	editora ON livro.id_editora - editora.id
		INNER JOIN
	autor ON livro.id_autor - autor.id
