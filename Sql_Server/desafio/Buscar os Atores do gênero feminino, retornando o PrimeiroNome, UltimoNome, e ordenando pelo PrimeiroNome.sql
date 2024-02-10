select a.PrimeiroNome,
		a.UltimoNome,
		a.Genero 
from Atores a
where a.Genero = 'F'
order by a.PrimeiroNome;