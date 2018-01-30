using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_new
{
    class Divide
    {
        public string dividir(string num1, string num2)
        {
            double resultado = 0;
            resultado = Convert.ToDouble(num1) / Convert.ToDouble(num2);
            return (Convert.ToString(resultado));
        }
    }
}
