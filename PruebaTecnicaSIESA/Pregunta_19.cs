namespace PruebaTecnicaSIESA
{
    public class Pregunta_19
    {
        public int Valor { get; set; }
        public List<Pregunta_19> Subarboles { get; set; }

        public Pregunta_19(int valor)
        {
            Valor = valor;
            Subarboles = new List<Pregunta_19>();
        }
    }

    public class ArbolConPeso
    {
        public Pregunta_19 Raiz { get; set; }

        public ArbolConPeso(Pregunta_19 raiz)
        {
            Raiz = raiz;
        }

        public int CalcularPeso()
        {
            return CalcularPesoRecursivo(Raiz);
        }

        private int CalcularPesoRecursivo(Pregunta_19 nodo)
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

        private int CalcularAlturaRecursivo(Pregunta_19 nodo)
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

        private int ContarNodos(Pregunta_19 nodo)
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
