using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garcia.Ian._2A
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;


        public int Codigo { get { return this._codigo; } }
        public bool EsIndustrial { get { return this._esIndustrial; } }
        public double Precio { get { return this._precio; } }


        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;

        }
        public override bool Equals(object obj)
        {
            bool retornado = false;
            if (obj != null && obj is Cocina)
            {
                retornado = (this == ((Cocina)obj));
            }
            return retornado;
        }
        public static bool operator ==(Cocina a, Cocina a1)
        {
            return (a.Codigo == a1.Codigo);
        }
        public static bool operator !=(Cocina a, Cocina a1)
        {
            return !(a == a1);
        }
        public override string ToString()
        {
            return $"Codigo: {this.Codigo} - Precio: {this.Precio} - EsIndustrial: {this.EsIndustrial}";
        }
    }
}
