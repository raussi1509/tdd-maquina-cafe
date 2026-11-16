using Xunit;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    public class AzucareroTests
    {
        [Fact]
        public void DeberiaDevolverVerdaderoSiExisteAzucar()
        {
            Azucarero azucarero = new Azucarero(10);

            bool resultado = azucarero.HasAzucar(5);

            Assert.True(resultado);
        }

        [Fact]
        public void DeberiaDevolverFalsoSiNoExisteAzucar()
        {
            Azucarero azucarero = new Azucarero(10);

            bool resultado = azucarero.HasAzucar(15);

            Assert.False(resultado);
        }

        [Fact]
        public void DeberiaRestarCantidadDeAzucar()
        {
            Azucarero azucarero = new Azucarero(10);

            azucarero.GiveAzucar(5);
            Assert.Equal(5, azucarero.GetCantidadAzucar());

            azucarero.GiveAzucar(2);
            Assert.Equal(3, azucarero.GetCantidadAzucar());
        }
    }
}