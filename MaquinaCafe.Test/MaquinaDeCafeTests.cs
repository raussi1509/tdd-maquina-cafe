using Xunit;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    public class MaquinaDeCafeTests
    {
        [Fact]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vasosPequenos = new Vaso(5, 10);

            MaquinaDeCafe maquina = new MaquinaDeCafe();
            maquina.SetVasosPequeno(vasosPequenos);

            Vaso resultado = maquina.GetTipoDeVaso("pequeno");

            Assert.Same(vasosPequenos, resultado);
        }

        [Fact]
        public void DeberiaDevolverUnVasoMediano()
        {
            Vaso vasosMedianos = new Vaso(5, 20);

            MaquinaDeCafe maquina = new MaquinaDeCafe();
            maquina.SetVasosMediano(vasosMedianos);

            Vaso resultado = maquina.GetTipoDeVaso("mediano");

            Assert.Same(vasosMedianos, resultado);
        }

        [Fact]
        public void DeberiaDevolverUnVasoGrande()
        {
            Vaso vasosGrandes = new Vaso(5, 30);

            MaquinaDeCafe maquina = new MaquinaDeCafe();
            maquina.SetVasosGrande(vasosGrandes);

            Vaso resultado = maquina.GetTipoDeVaso("grande");

            Assert.Same(vasosGrandes, resultado);
        }

        [Fact]
        public void DeberiaDevolverNoHayVasos()
        {
            Cafetera cafetera = new Cafetera(50);
            Azucarero azucarero = new Azucarero(20);
            Vaso vasosPequenos = new Vaso(5, 10);

            MaquinaDeCafe maquina = new MaquinaDeCafe();

            maquina.SetCafetera(cafetera);
            maquina.SetAzucarero(azucarero);
            maquina.SetVasosPequeno(vasosPequenos);

            string resultado = maquina.GetVasoDeCafe(vasosPequenos, 10, 2);

            Assert.Equal("No hay Vasos", resultado);
        }

        [Fact]
        public void DeberiaDevolverNoHayCafe()
        {
            Cafetera cafetera = new Cafetera(5);
            Azucarero azucarero = new Azucarero(20);
            Vaso vasosPequenos = new Vaso(5, 10);

            MaquinaDeCafe maquina = new MaquinaDeCafe();

            maquina.SetCafetera(cafetera);
            maquina.SetAzucarero(azucarero);
            maquina.SetVasosPequeno(vasosPequenos);

            string resultado = maquina.GetVasoDeCafe(vasosPequenos, 1, 2);

            Assert.Equal("No hay Cafe", resultado);
        }

        [Fact]
        public void DeberiaDevolverNoHayAzucar()
        {
            Cafetera cafetera = new Cafetera(50);
            Azucarero azucarero = new Azucarero(2);
            Vaso vasosPequenos = new Vaso(5, 10);

            MaquinaDeCafe maquina = new MaquinaDeCafe();

            maquina.SetCafetera(cafetera);
            maquina.SetAzucarero(azucarero);
            maquina.SetVasosPequeno(vasosPequenos);

            string resultado = maquina.GetVasoDeCafe(vasosPequenos, 1, 3);

            Assert.Equal("No hay Azucar", resultado);
        }

        [Fact]
        public void DeberiaRestarCafe()
        {
            Cafetera cafetera = new Cafetera(50);
            Azucarero azucarero = new Azucarero(20);
            Vaso vasosPequenos = new Vaso(5, 10);

            MaquinaDeCafe maquina = new MaquinaDeCafe();

            maquina.SetCafetera(cafetera);
            maquina.SetAzucarero(azucarero);
            maquina.SetVasosPequeno(vasosPequenos);

            maquina.GetVasoDeCafe(vasosPequenos, 1, 3);

            Assert.Equal(40, cafetera.GetCantidadCafe());
        }

        [Fact]
        public void DeberiaRestarVaso()
        {
            Cafetera cafetera = new Cafetera(50);
            Azucarero azucarero = new Azucarero(20);
            Vaso vasosPequenos = new Vaso(5, 10);

            MaquinaDeCafe maquina = new MaquinaDeCafe();

            maquina.SetCafetera(cafetera);
            maquina.SetAzucarero(azucarero);
            maquina.SetVasosPequeno(vasosPequenos);

            maquina.GetVasoDeCafe(vasosPequenos, 1, 3);

            Assert.Equal(4, vasosPequenos.GetCantidadVasos());
        }

        [Fact]
        public void DeberiaRestarAzucar()
        {
            Cafetera cafetera = new Cafetera(50);
            Azucarero azucarero = new Azucarero(20);
            Vaso vasosPequenos = new Vaso(5, 10);

            MaquinaDeCafe maquina = new MaquinaDeCafe();

            maquina.SetCafetera(cafetera);
            maquina.SetAzucarero(azucarero);
            maquina.SetVasosPequeno(vasosPequenos);

            maquina.GetVasoDeCafe(vasosPequenos, 1, 3);

            Assert.Equal(17, azucarero.GetCantidadAzucar());
        }

        [Fact]
        public void DeberiaDevolverFelicitaciones()
        {
            Cafetera cafetera = new Cafetera(50);
            Azucarero azucarero = new Azucarero(20);
            Vaso vasosPequenos = new Vaso(5, 10);

            MaquinaDeCafe maquina = new MaquinaDeCafe();

            maquina.SetCafetera(cafetera);
            maquina.SetAzucarero(azucarero);
            maquina.SetVasosPequeno(vasosPequenos);

            string resultado = maquina.GetVasoDeCafe(vasosPequenos, 1, 3);

            Assert.Equal("Felicitaciones", resultado);
        }
    }
}