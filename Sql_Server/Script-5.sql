select * from Clientes c 
inner join Enderecos e 
	on c.ID = e.IDCliente
where c.ID = 4;

select
	c.Nome,
	c.Sobrenome,
	c.Email,
	e.Rua,
	e.Bairro,
	e.Cidade,
	e.Estado 
from Clientes c 
inner join Enderecos e 
	on c.ID = e.IDCliente 
where c.ID = 4;