using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeudoresMorosos.Entidades
{
    public class Servicio
    {
        private int _id;
        private double _PunitorioDiario;
        private string _Nombre;

        public Servicio()
        { }
        public Servicio(int id, string Nombre, double Punitorioxdia)
        {
            this._id = id;
            this._Nombre = Nombre;
            this._PunitorioDiario = Punitorioxdia;
        }

        public int Id { get => _id; set => _id = value; }
        public double PunitorioDiario { get => _PunitorioDiario; set => _PunitorioDiario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        public string DisplayServicio
        {
            get { return (Id + " - " + Nombre); }
        }
    }

}
