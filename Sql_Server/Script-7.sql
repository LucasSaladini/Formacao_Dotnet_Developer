CREATE PROCEDURE InserirNovoProduto
@Nome VARCHAR(255),
@Cor VARCHAR(50),
@Preco DECIMAL,
@Tamanho VARCHAR(5),
@Genero CHAR(1)

AS 

INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
VALUES (@Nome, @Cor, @Preco, @Tamanho,  @Genero)

EXECUTE InserirNovoProduto
'NOVO PRODUTO PROCEDURE',
'COLORIDO',
50,
'G',
'U';

EXECUTE InserirNovoProduto
@Nome = 'NOVO PRODUTO PROCEDURE',
@Cor = 'COLORIDO',
@Preco = 50,
@Tamanho = 'G',
@Genero = 'U';

SELECT * FROM Produtos p WHERE p.Nome = 'NOVO PRODUTO PROCEDURE';

CREATE PROCEDURE ObterProdutosPorTamanho
@TamanhoProduto VARCHAR(5)

AS

SELECT * FROM Produtos WHERE Tamanho = @TamanhoProduto

EXEC ObterProdutosPorTamanho 'M';