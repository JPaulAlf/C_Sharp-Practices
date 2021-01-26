using System;
using System.Collections.Generic;
using System.Text;

namespace CapaObjetos
{
    public class Automovil : Transporte
    {
        private int codigoChasis;

        public int CodigoChasis
        {
            get { return codigoChasis; }
            set { codigoChasis = value; }
        }


        public Automovil()
            : base()
        {
            this.CodigoChasis = 0;
        }


        public Automovil(string placa, int kilometraje, int modelo, int codigoChasis)
          :base(placa,  modelo, kilometraje)
        {
            this.CodigoChasis = codigoChasis;
        }

        //Recibe una a una las llantas, no acepta m�s de 4.
        public override bool asignaLlantas(Llanta unaLlanta)
        {
            //revisar que no se pase de la cantidad max
            if (this.ArrayLlantas.Count < 4)
            {
                this.ArrayLlantas.Add(unaLlanta);
                return true;
            }
            else
            {
                return false;
            }
        }


        public override double gastoCombustible()
        {
            // por cada kil�metro 500 colones
            return (this.Kilometraje * 500);
        }

        public override string ToString()
        {
            StringBuilder hilera = new StringBuilder("Autom�vil: ");
            hilera.Append(base.ToString());
            hilera.Append("\nC�digo de Chas�s: " + this.codigoChasis);
            return hilera.ToString();
        }

  
    }
}
