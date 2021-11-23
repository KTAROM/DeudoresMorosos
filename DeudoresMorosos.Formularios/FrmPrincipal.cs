using DeudoresMorosos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeudoresMorosos.Entidades;

namespace DeudoresMorosos.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private Pagos_Negocio _PagosNegocio;
        public FrmPrincipal()
        {
            _PagosNegocio = new Pagos_Negocio();
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            Limpiar();
          
        }

        private void Limpiar()
        {
            cmbServicio.Items.Add("--seleccione--");
            cmbServicio.SelectedIndex= 0;
            txtFechaPago.Text = string.Empty;
            txtImpAdeudado.Text = string.Empty;
            Refrescar();
            
        }
        private void Refrescar()
        {
            lstPagos.DataSource = null;
            lstPagos.DataSource = _PagosNegocio.ListarPagos();
            lstPagos.DisplayMember = "MostrarPago";
            txtIntPromedio.Text = _PagosNegocio.IntPromedio().ToString();
            txtDiasAtraso.Text = _PagosNegocio.DiasPromedio().ToString();

        }
        

        private void cmbServicio_Click(object sender, EventArgs e)
        {
            cmbServicio.DataSource = null;
            cmbServicio.DataSource = _PagosNegocio.ListarServicios();
            cmbServicio.DisplayMember = "DisplayServicio";

        }

        private void cmbServicio_Select(object sender,EventArgs e)
        {
            try
            {
                Servicio ServicioSelec = (Servicio)cmbServicio.SelectedItem;
                txtPunitorioxdia.Text = ServicioSelec.PunitorioDiario.ToString();
            }
            catch(Exception ex)
            { }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Pagos NuevoPago = CrearPago();
            txtIntPunitorio.Text = NuevoPago.InteresPunitorio.ToString();
            txtImpTotal.Text = NuevoPago.ImporteTotal.ToString();
           
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Pagos NuevoPago = CrearPago();
            NuevoPago.InteresPunitorio = double.Parse(txtIntPunitorio.Text);
            Resultado Operacion = _PagosNegocio.AltaPago(NuevoPago);
            if(Operacion.Isok)
            {
                MessageBox.Show("Se ha registrado el pago");
                
               

            }
            else
            {
                MessageBox.Show(Operacion.Error);
            }
            Refrescar();
        }
        private Pagos CrearPago()
        {
            Pagos NuevoPago = new Pagos();
            NuevoPago.FechaPago = DateTime.Parse(txtFechaPago.Text);
            NuevoPago.FechaVencimiento = DateTime.Parse(txtFechaVto.Text);
            NuevoPago.ImporteAdeudado = double.Parse(txtImpAdeudado.Text);
            NuevoPago.IdServicio = ((Servicio)cmbServicio.SelectedItem).Id;
            return NuevoPago;
            
           
        }
    }
}
