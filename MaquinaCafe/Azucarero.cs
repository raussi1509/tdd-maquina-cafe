namespace MaquinaCafe
{
    public class Azucarero
    {
        private int cantidadAzucar;

        public Azucarero(int cantidadAzucar)
        {
            this.cantidadAzucar = cantidadAzucar;
        }

        public bool HasAzucar(int cantidad)
        {
            return cantidadAzucar >= cantidad;
        }

        public void GiveAzucar(int cantidad)
        {
            cantidadAzucar -= cantidad;
        }

        public int GetCantidadAzucar()
        {
            return cantidadAzucar;
        }
    }
}