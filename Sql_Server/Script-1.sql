INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
values ('Lucas', 'Saladini', 'email@email.com', 1, getdate())

select * from Clientes c 
where c.Nome = 'Lucas'

insert into Clientes values ('Lucas', 'Saladini', 'email@email.com', 1, getdate())

select * from Clientes c 
where c.Nome = 'Lucas'

update Clientes 
set Email = 'emailatualizado@email.com', 
	AceitaComunicados = 0
where ID = 1001

begin tran
rollback

update Clientes 
set Email = 'emailatualizado@email.com', 
	AceitaComunicados = 0
	
select * from Clientes c 

begin tran
rollback

delete Clientes
where ID = 1001

select * from Clientes c 
where c.ID = 1001