using Xunit;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    public class CafeteraTests
    {
        [Fact]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(5);

            Assert.True(resultado);
        }

        [Fact]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(11);

            Assert.False(resultado);
        }

        [Fact]
        public void DeberiaRestarCantidadDeCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            cafetera.GiveCafe(7);

            Assert.Equal(3, cafetera.GetCantidadCafe());
        }
    }
}