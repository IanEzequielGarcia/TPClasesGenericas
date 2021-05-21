using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garcia.Ian._2A
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }
        private int GetIndice(T a)
        {
            int retornado = 0;
            if (((object)a) != null)
            {
                foreach (T Ts in this._lista)
                {
                    if (Ts.Equals(a))
                        return retornado;
                    retornado++;
                }
            }
            return -1;
        }


        static public bool operator +(Deposito<T> d, T a)
        {
            if (d.Agregar(a))
            {
                return true;
            }
            else
            {
                Console.WriteLine("El deposito esta lleno");
                return false;
            }
        }
        public bool Agregar(T a)
        {
            if (this._capacidadMaxima > this._lista.Count)
            {
                this._lista.Add(a);
                return true;
            }
            return false;
        }
        static public bool operator -(Deposito<T> d, T a)
        {
            if (d.Remover(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Remover(T a)
        {
            if (this.GetIndice(a) >= 0)
            {
                this._lista.Remove(a);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad: {this._capacidadMaxima}");
            sb.AppendLine("Listado:");

            foreach (T Ts in this._lista)
            {
                if ((object)Ts != null)
                {
                    sb.AppendLine(Ts.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
