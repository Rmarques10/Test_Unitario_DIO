using Calculadora.Services;

namespace CauculadoraTeste
{
    public class CalculadoraTests
    {
        private CalculadoraImp _calc;

        public CalculadoraTests() 
        { 
            _calc = new CalculadoraImp();
        }

        [Fact]
        public void DeveSomar5Com10Retornar15()
        {
            //Arrange
            int num1 = 5, num2 = 10;

            //Act
            int resultado = _calc.Somar(num1, num2);

            //Assert
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void DeveSomar10Com10Retornar20()
        {
            //Arrange
            int num1 = 10, num2 = 10;

            //Act
            int resultado = _calc.Somar(num1, num2);

            //Assert
            Assert.Equal(20, resultado);
        }

        [Fact]
        public void DeveVerificarSeONumeroEPar()
        {
            //Arrange
            int num1 = 4;

            //Act
            bool resultado = _calc.EhPar(num1);

            //Assert
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(new int[] {2, 4, 8, 10})]
        public void DeveVerificarSeOsNumerosSaoPares(int[] numeros)
        {

            Assert.All(numeros, x => Assert.True(_calc.EhPar(x)));
        }
    }
}