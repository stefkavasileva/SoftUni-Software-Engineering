CREATE FUNCTION ufn_CalculateFutureValue (@Sum MONEY, @Rate FLOAT , @Years INT)
RETURNS MONEY AS
BEGIN
 RETURN @Sum * POWER(1+@Rate,@Years)
END