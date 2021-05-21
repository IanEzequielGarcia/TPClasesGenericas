using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garcia.Ian._2A
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color { get {return this._color;} }
        public string Marca { get { return this._marca; } }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        public override bool Equals(object obj)
        {
            bool retornado = false;
            if (obj != null && obj is Auto)
            {
                retornado = (this == ((Auto)obj));
            }
            return retornado;
        }
        public static bool operator ==(Auto a,Auto a1)
        {
            return (a.Marca == a1.Marca && a.Color == a1.Color);
        }
        public static bool operator !=(Auto a, Auto a1)
        {
            return !(a == a1);
        }
        public override string ToString()
        {
            return $"Marca:{this.Marca} - Color: {this.Color} ";
        }
    }
}
