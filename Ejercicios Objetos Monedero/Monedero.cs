using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Objetos_Monedero
{
    class Monedero
    {
        private  double dinero;

        public Monedero(double dinero)
        {
            this.dinero = dinero;
        }
        public void MeterDinero(double dinero)
        {
            this.dinero = this.dinero + dinero;
        }
        public void SacarDinero(double dinero)
        {
            if (dinero > this.dinero)
            {
                Console.WriteLine("No puede sacar mas dinero del que dispone");
            }
            else
            {
                this.dinero = this.dinero - dinero;
            }
        }
        public double ConsultaSaldo()
        {
            return dinero;
        }
  

    }
}
//Define una clase Monedero que permita gestionar la cantidad de dinero del que una persona dispone en un momento dado.
//La clase deberá tener un constructor que permitirá crear un monedero con una cantidad de dinero inicial y deberá definir
//un método para meter dinero en el monedero, otro para sacarlo y finalmente, otro para consultar el disponible; solo podrá conocerse
//la cantidad de dinero del monedero a través de este último método.Por supuesto, no se podrá sacar más dinero del que haya en un 
//momento dado en el monedero.Desde el método main() de la clase principal probar su funcionamiento