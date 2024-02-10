select f.Nome,
		g.Genero 
from FilmesGenero fg
inner join Filmes f
	on f.Id = fg.IdFilme
inner join Generos g 
	on g.Id = fg.IdGenero;