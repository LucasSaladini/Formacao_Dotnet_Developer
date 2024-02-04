select count(*) QuantidadeProdutos from Produtos p;
select count(*) QuantidadeProdutosTamanhoM from Produtos p where p.Tamanho = 'M';

select sum(Preco) SomaPreco from Produtos p;
select sum(Preco) SomaPrecoTamanhoM from Produtos p where p.Tamanho = 'M';

select max(Preco) ProdutoMaisCaro from Produtos p;
select max(Preco) ProdutoMaisCaroTamanhoM from Produtos p where p.Tamanho = 'M';

select min(Preco) ProdutoMaisBarato from Produtos p;
select min(Preco) ProdutoMaisBaratoTamanhoM from Produtos p where p.Tamanho = 'M';

select avg(Preco) from Produtos p;

select 
	p.Nome + ', Cor: ' + p.Cor as ProdutoComCor,
	UPPER(p.Nome)  Nome,
	LOWER(p.Cor) Cor 
from Produtos p;


select * from Produtos p;

alter table Produtos 
add DataCadastro datetime2;

update Produtos set DataCadastro = getdate();

alter table Produtos 
drop column DataCadastro;

select 
	p.Nome + ', Cor: ' + p.Cor as ProdutoComCor,
	UPPER(p.Nome)  Nome,
	LOWER(p.Cor) Cor,
	format(p.DataCadastro, 'dd-MM-yyyy HH:mm') Data
from Produtos p;


select
	p.Tamanho,
	count(*) Quantidade
from Produtos p 
where p.Tamanho <> ''
group by p.Tamanho
order by Quantidade desc;


ALTER TABLE Clientes 
ADD CONSTRAINT PK_ID PRIMARY KEY CLUSTERED (ID);



create table Enderecos (
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IDCliente INT NULL,
	Rua VARCHAR(255) NULL,
	Bairro VARCHAR(255) NULL,
	Cidade VARCHAR(255) NULL,
	Estado CHAR(2) NULL,
	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente)
	REFERENCES Clientes(ID) 
);

select * from Enderecos;

insert into Enderecos values (4, 'Rua Teste', 'Bairro Teste', 'Cidade Teste', 'SP');

select * from Clientes c where c.ID = 4;
select * from Enderecos e where e.IDCliente = 4;