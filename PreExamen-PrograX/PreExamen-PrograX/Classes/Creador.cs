using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamen_PrograX.Classes
{
    public class Creador
    {
        public const int motocicleta = 1;
        public const int sedan = 2;

        public static Vehiculo vehiculo(int Tipo)
        {
            switch (Tipo)
            {
                case motocicleta:
                    return new Motocicleta();
                case sedan:
                    return new Sedan();
                default: return null;
            }
        }
    }
}
