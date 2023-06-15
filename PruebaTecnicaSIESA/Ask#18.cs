namespace PruebaTecnicaSIESA
{
    public class Ask_18
    {
        public string ConvertirBase(string numero, int baseOrigen, int baseDestino)
        {
            int decimalValue = ConvertirBaseDecimal(numero, baseOrigen);
            string resultado = ConvertirDecimalBase(decimalValue, baseDestino);
            return resultado;
        }

        private int ConvertirBaseDecimal(string numero, int baseOrigen)
        {
            int decimalValue = 0;
            int power = 0;

            for (int i = numero.Length - 1; i >= 0; i--)
            {
                int digit = Convert.ToInt32(numero[i].ToString(), baseOrigen);
                decimalValue += digit * (int)Math.Pow(baseOrigen, power);
                power++;
            }

            return decimalValue;
        }

        private string ConvertirDecimalBase(int numero, int baseDestino)
        {
            if (numero == 0)
                return "0";

            string resultado = string.Empty;

            while (numero > 0)
            {
                int residuo = numero % baseDestino;
                resultado = ObtenerDigitoEnBase(residuo) + resultado;
                numero /= baseDestino;
            }

            return resultado;
        }

        private string ObtenerDigitoEnBase(int numero)
        {
            if (numero < 10)
                return numero.ToString();

            char letra = (char)('A' + (numero - 10));
            return letra.ToString();
        }
    }
}
