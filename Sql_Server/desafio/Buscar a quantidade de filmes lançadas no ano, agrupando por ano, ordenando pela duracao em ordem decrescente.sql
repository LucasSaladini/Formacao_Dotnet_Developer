select f.Ano, 
	count(*) Quantidade
from Filmes f
group by f.Ano
order by count(*) desc;