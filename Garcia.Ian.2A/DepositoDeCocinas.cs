using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garcia.Ian._2A
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }
        private int GetIndice(Cocina a)
        {
            int retornado = 0;
            if(((object)a)!=null)
            {
                foreach(Cocina Cocinas in this._lista)
                {
                    if (Cocinas.Equals(a))
                        return retornado;
                    retornado++;
                }
            }
            return -1;
        }


        static public bool operator +(DepositoDeCocinas d, Cocina a)
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
        public bool Agregar(Cocina a)
        {
            if(this._capacidadMaxima > this._lista.Count)
            {
                this._lista.Add(a);
                return true;
            }
            return false;
        }
        static public bool operator -(DepositoDeCocinas d, Cocina a)
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
        public bool Remover(Cocina a)
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

            foreach (Cocina Cocinas in this._lista)
            {
                if((object)Cocinas!=null)
                {
                    sb.AppendLine(Cocinas.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
