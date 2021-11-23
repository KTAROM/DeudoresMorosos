using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeudoresMorosos.Entidades
{
    public class Pagos
    {
        private int _id;
        private int _idServicio;
        private int _idCliente;
        private DateTime _FechaVencimiento;
        private DateTime _FechaPago;
        private double _ImporteAdeudado;
        private double _InteresPunitorio;
        private string _Usuario;
        private double _ImporteTotal;
        private Servicio _Servicio;
        private List<Servicio> _lstServicio;

        public Pagos()
        {
            this._lstServicio = new List<Servicio>();
            this._lstServicio.Add(new Servicio(0, "Otros", 5.20));
            this._lstServicio.Add(new Servicio(1, "Edenor", 8.45));
            this._lstServicio.Add(new Servicio(2, "Expensas", 5.20));
            this._lstServicio.Add(new Servicio(3, "Telecom", 2.21));
            this._Usuario = "836465";
        }
        public Pagos(int idServicio, int idCliente, DateTime FechaVencimiento, DateTime FechaPago, double ImporteAdeudado, double InteresPunitorio)
        {
            this._lstServicio = new List<Servicio>();
            this._lstServicio.Add(new Servicio(0, "Otros", 5.20));
            this._lstServicio.Add(new Servicio(1, "Edenor", 8.45));
            this._lstServicio.Add(new Servicio(2, "Expensas", 5.20));
            this._lstServicio.Add(new Servicio(3, "Telecom", 2.21));
            
            this._idServicio = idServicio;
            this._idCliente = idCliente;
            this._FechaVencimiento = FechaVencimiento;
            this._FechaPago = FechaPago;
            this._ImporteAdeudado = ImporteAdeudado;
            this._InteresPunitorio = InteresPunitorio;
            this._Usuario = "836465";

        }
        public List<Servicio> lstServicio
        { get { return this._lstServicio; } }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int Id { get => _id; set => _id = value; }
        public int IdServicio { get => _idServicio; set => _idServicio = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
        public DateTime FechaPago { get => _FechaPago; set => _FechaPago = value; }
        public double ImporteAdeudado { get => _ImporteAdeudado; set => _ImporteAdeudado = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        

        public double InteresPunitorio
        {
            set { this._InteresPunitorio = value; }
            get {
                double interes = (this._FechaPago.Day - this._FechaVencimiento.Day) * Servicio().PunitorioDiario;
                return interes; }
        }

        public Servicio Servicio()
        {
            Servicio serv = new Servicio();
                          
                foreach (Servicio s in lstServicio)
                {
                    if (s.Id == this._idServicio)
                    {
                        serv = s;
                    }
                }
                return serv;            
        }

        public double ImporteTotal
        {
           get { double Total = this._ImporteAdeudado + this._InteresPunitorio;
                return Total; }
        }
        
        public string MostrarPago
        {
            get { return (Id + " ) " +Servicio().Nombre + " - " + ImporteTotal.ToString()+" atraso " + (FechaPago.Day - FechaVencimiento.Day) + " días"); }
        }
    }
}
