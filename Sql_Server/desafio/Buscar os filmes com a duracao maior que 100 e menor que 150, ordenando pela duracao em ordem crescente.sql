select f.Nome,
		f.Ano,
		f.Duracao 
from Filmes f
where f.Duracao > 100 and f.Duracao < 150
order by f.Duracao;