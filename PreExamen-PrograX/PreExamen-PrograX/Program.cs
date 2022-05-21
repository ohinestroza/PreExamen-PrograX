using PreExamen_PrograX.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamen_PrograX
{
    internal class Program
    {   
        //Factory Method
        static void Main(string[] args)
        {
            Vehiculo vehiculos = Creador.vehiculo(Creador.motocicleta);
            Console.WriteLine("Una motocicleta tiene " + vehiculos.Llantas() + " llantas.");

            Console.ReadLine();
        }
    }
}
