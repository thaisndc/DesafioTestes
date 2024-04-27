using System;
using Xunit;
using Calculadora.Services;
namespace CalculadoraTests;

public class CalculadoraTests
{
    public CalculadoraCode ConstruirClasse()
    {
        CalculadoraCode calc = new CalculadoraCode("31/10/2023");
        return calc;
    }
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(2,2,4)]
    public void TesteSomar(int val1, int val2, int resultado  )
    {
        CalculadoraCode calc = ConstruirClasse();
        
        int resultadoCalculadora = calc.Somar(val1,val2);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Theory]
    [InlineData(6,3,3)]
    [InlineData(10,2,8)]
    public void TesteSubtrair(int val1, int val2, int resultado  )
    {
        CalculadoraCode calc = ConstruirClasse();
        
        int resultadoCalculadora = calc.Subtrair(val1,val2);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Theory]
    [InlineData(3,3,9)]
    [InlineData(2,2,4)]
    public void TesteMultiplicar(int val1, int val2, int resultado  )
    {
        CalculadoraCode calc = ConstruirClasse();
        
        int resultadoCalculadora = calc.Multiplicar(val1,val2);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Theory]
    [InlineData(8,2,4)]
    [InlineData(15,3,5)]
    public void TesteDividir(int val1, int val2, int resultado  )
    {
        CalculadoraCode calc = ConstruirClasse();
        
        int resultadoCalculadora = calc.Dividir(val1,val2);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
      CalculadoraCode calc = ConstruirClasse();

      Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
      CalculadoraCode calc = ConstruirClasse();

      calc.Somar(1,2);
      calc.Somar(2,8);
      calc.Somar(3,7);
      calc.Somar(4,1);

      var lista = calc.Historico();

      Assert.NotEmpty(lista);

      Assert.Equal(3,lista.Count);
    }
    
}