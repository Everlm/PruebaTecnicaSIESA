namespace PruebaTecnicaSIESA
{
    public class Ask_17
    {
        public double Division(int numero1, int numero2)
        {
            if (numero2 == 0)
            {
                throw new ArgumentException("El segundo número no puede ser cero");
            }

            double resultado = (double)numero1 / numero2;
            return resultado;
        }
    }
}
