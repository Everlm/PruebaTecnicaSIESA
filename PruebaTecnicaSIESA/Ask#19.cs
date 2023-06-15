namespace PruebaTecnicaSIESA
{
    public class Ask_19
    {
        public int Valor { get; set; }
        public List<Ask_19> Subarboles { get; set; }

        public Ask_19(int valor)
        {
            Valor = valor;
            Subarboles = new List<Ask_19>();
        }
    }

    public class ArbolConPeso
    {
        public Ask_19 Raiz { get; set; }

        public ArbolConPeso(Ask_19 raiz)
        {
            Raiz = raiz;
        }

        public int CalcularPeso()
        {
            return CalcularPesoRecursivo(Raiz);
        }

        private int CalcularPesoRecursivo(Ask_19 nodo)
        {
            int peso = nodo.Valor;

            foreach (var subarbol in nodo.Subarboles)
            {
                peso += CalcularPesoRecursivo(subarbol);
            }

            return peso;
        }

        public double CalcularPesoPromedio()
        {
            int pesoTotal = CalcularPeso();
            int cantidadNodos = ContarNodos(Raiz);

            if (cantidadNodos == 0)
                return 0;

            return (double)pesoTotal / cantidadNodos;
        }

        public int CalcularAltura()
        {
            return CalcularAlturaRecursivo(Raiz);
        }

        private int CalcularAlturaRecursivo(Ask_19 nodo)
        {
            if (nodo.Subarboles.Count == 0)
                return 0;

            int alturaMaxima = 0;

            foreach (var subarbol in nodo.Subarboles)
            {
                int alturaSubarbol = CalcularAlturaRecursivo(subarbol);
                if (alturaSubarbol > alturaMaxima)
                    alturaMaxima = alturaSubarbol;
            }

            return alturaMaxima + 1;
        }

        private int ContarNodos(Ask_19 nodo)
        {
            if (nodo.Subarboles.Count == 0)
                return 1;

            int cantidadNodos = 1;

            foreach (var subarbol in nodo.Subarboles)
            {
                cantidadNodos += ContarNodos(subarbol);
            }

            return cantidadNodos;
        }
    }
    
}
