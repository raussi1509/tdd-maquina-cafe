namespace MaquinaCafe
{
    public class Vaso
    {
        private int cantidadVasos;
        private int capacidadVaso;

        public Vaso(int cantidadVasos, int capacidadVaso)
        {
            this.cantidadVasos = cantidadVasos;
            this.capacidadVaso = capacidadVaso;
        }

        public bool HasVasos(int cantidad)
        {
            return cantidadVasos >= cantidad;
        }

        public void GiveVasos(int cantidad)
        {
            cantidadVasos -= cantidad;
        }

        public int GetCantidadVasos()
        {
            return cantidadVasos;
        }

        public int GetCapacidadVaso()
        {
            return capacidadVaso;
        }
    }
}