using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esepsioones
{
    class Program
    {
        public class operacion
        {
            public int num;
            public operacion(int num)
            {
                this.num = num;
            }
           
            public double elevar()
            {
                return Math.Pow(num, 2);
            }

            public void despliegue()
            {
                Console.WriteLine(num + " al cuadrado = {0}",elevar());
            }
        }
        static void Main(string[] args)
        {
            int num;
            string sino;
            do
            {
                try
                {

                    Console.Write("Ingrese el numero a elevar al cuadrado:");
                    num = int.Parse(Console.ReadLine());
                    operacion o1 = new operacion(num);
                    o1.elevar();
                    o1.despliegue();
                    
                }catch(Exception e)
                {
                    Console.WriteLine("Error inesperado " + e.Message);

                }
                Console.WriteLine("Repetir operacion? s/n");
                sino = Convert.ToString(Console.ReadLine());
            } while (sino =="s" || sino == "S");

        }
    }
}
