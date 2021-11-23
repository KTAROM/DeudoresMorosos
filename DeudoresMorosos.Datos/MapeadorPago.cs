using DeudoresMorosos.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeudoresMorosos.Datos
{
    public class MapeadorPago
    {
        public MapeadorPago()
        {

        }
        public List<Pagos> TraerPagos()
        {
            string json = WebHelper.Get("836465");
            List<Pagos> _lstPagos = JsonConvert.DeserializeObject<List<Pagos>>(json);
            return _lstPagos;
        }

        public Resultado AltaPagos(Pagos NuevoPago)
        {
            NameValueCollection n = ReversoMap(NuevoPago);
            string json = WebHelper.Post("", n);
            Resultado Operacion = JsonConvert.DeserializeObject<Resultado>(json);
            return Operacion;
        }

        private NameValueCollection ReversoMap(Pagos NuevoPago)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idServicio", NuevoPago.IdServicio.ToString());
            n.Add("ImporteAdeudado", NuevoPago.ImporteAdeudado.ToString("0,00"));
            n.Add("FechaVencimiento", NuevoPago.FechaVencimiento.ToString("yy-MM-dd"));
            n.Add("FechaPago", NuevoPago.FechaPago.ToString("yyyy-MM-dd"));
            n.Add("InteresPunitorio", NuevoPago.InteresPunitorio.ToString("0,00"));
            n.Add("Usuario", NuevoPago.Usuario);
            n.Add("id", "0");
            n.Add("idCliente", "0");
            return n;
        }
    }
}
