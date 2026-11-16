namespace MaquinaCafe
{
    public class MaquinaDeCafe
    {
        private Vaso vasosPequeno;
        private Vaso vasosMediano;
        private Vaso vasosGrande;
        private Cafetera cafetera;
        private Azucarero azucarero;

        public void SetVasosPequeno(Vaso vaso)
        {
            vasosPequeno = vaso;
        }

        public void SetVasosMediano(Vaso vaso)
        {
            vasosMediano = vaso;
        }

        public void SetVasosGrande(Vaso vaso)
        {
            vasosGrande = vaso;
        }

        public Vaso GetTipoDeVaso(string tipoVaso)
        {
            switch (tipoVaso.ToLower())
            {
                case "pequeno":
                    return vasosPequeno;

                case "mediano":
                    return vasosMediano;

                case "grande":
                    return vasosGrande;

                default:
                    return null;
            }
        }

        public void SetCafetera(Cafetera cafetera)
        {
            this.cafetera = cafetera;
        }

        public void SetAzucarero(Azucarero azucarero)
        {
            this.azucarero = azucarero;
        }

        public string GetVasoDeCafe(Vaso vaso, int cantidadVasos, int cantidadAzucar)
        {
            if (!vaso.HasVasos(cantidadVasos))
            {
                return "No hay Vasos";
            }

            int cantidadCafe = vaso.GetCapacidadVaso() * cantidadVasos;

            if (!cafetera.HasCafe(cantidadCafe))
            {
                return "No hay Cafe";
            }

            if (!azucarero.HasAzucar(cantidadAzucar))
            {
                return "No hay Azucar";
            }

            cafetera.GiveCafe(cantidadCafe);
            vaso.GiveVasos(cantidadVasos);
            azucarero.GiveAzucar(cantidadAzucar);

            return "Felicitaciones";
        }
    }
}