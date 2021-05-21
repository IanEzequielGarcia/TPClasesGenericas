using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garcia.Ian._2A
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }
        private int GetIndice(Auto a)
        {
            int retornado = 0;
            if(((object)a)!=null)
            {
                foreach(Auto autos in this._lista)
                {
                    if (autos.Equals(a))
                        return retornado;
                    retornado++;
                }
            }
            return -1;
        }


        static public bool operator +(DepositoDeAutos d, Auto a)
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
        public bool Agregar(Auto a)
        {
            if(this._capacidadMaxima > this._lista.Count)
            {
                this._lista.Add(a);
                return true;
            }
            return false;
        }
        static public bool operator -(DepositoDeAutos d, Auto a)
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
        public bool Remover(Auto a)
        {
            if(this.GetIndice(a)>=0)
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

            foreach (Auto autos in this._lista)
            {
                if((object)autos!=null)
                {
                    sb.AppendLine(autos.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
