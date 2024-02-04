SELECT
	p.Nome,
	p.Preco,
	dbo.CalcularDesconto(Preco, 10) PrecoComDesconto
FROM Produtos p WHERE p.Tamanho = 'M';


CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13, 2), @Porcentagem INT)
RETURNS DECIMAL(13,2)

BEGIN
	RETURN @Preco - @Preco / 100 * @Porcentagem
END
