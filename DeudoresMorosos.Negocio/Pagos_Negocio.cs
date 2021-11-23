using DeudoresMorosos.Datos;
using DeudoresMorosos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeudoresMorosos.Negocio
{
    public class Pagos_Negocio
    {
        private MapeadorPago _MapPagos;
        private List<Pagos> _lstPagos;
        private List<Servicio> _lstServicios;
        public Pagos_Negocio()
        {
            this._MapPagos = new MapeadorPago();
            this._lstServicios = new List<Servicio>();
            this._lstPagos = new List<Pagos>();
           
        }

        public List<Pagos> ListarPagos()
        {
            _lstPagos = _MapPagos.TraerPagos();
            return _lstPagos;
            
        }

        public List<Servicio> ListarServicios()
        {
            Pagos pago = new Pagos();
            _lstServicios = pago.lstServicio;
                return _lstServicios;
           
        }

       public Resultado AltaPago(Pagos NuevoPago)
        {
            Resultado Operacion = _MapPagos.AltaPagos(NuevoPago);
            return Operacion;

        }

        public double IntPromedio()
        {
            double suma = 0;
            foreach(Pagos p in _lstPagos)
            {
                suma += p.InteresPunitorio;
            }
            double promedio = suma / _lstPagos.Count();
            return promedio;
        }

        public double DiasPromedio()
        {
            int dias = 0;
            foreach(Pagos p in _lstPagos)
            {
                dias += p.FechaPago.Day - p.FechaVencimiento.Day;
            }
            double diasprom = dias / _lstPagos.Count();
            return diasprom;
        }
}
}
