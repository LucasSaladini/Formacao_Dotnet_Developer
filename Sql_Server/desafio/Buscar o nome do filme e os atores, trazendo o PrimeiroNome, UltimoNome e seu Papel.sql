select f.Nome,
		a.PrimeiroNome,
		a.UltimoNome,
		ef.Papel
from ElencoFilme ef
inner join Filmes f
	on f.Id = ef.IdFilme
inner join Atores a 
	on a.Id = ef.IdAtor;