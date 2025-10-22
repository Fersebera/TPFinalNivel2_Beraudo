using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo;

        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            try
            {                   
                txtCodigoDetalle.Text = articulo.Codigo;
                txtNombreDetalle.Text = articulo.Nombre;
                txtDescripcionDetalle.Text = articulo.Descripcion;
                txtMarcaDetalle.Text = articulo.Brand.Descripcion;
                txtCategoriaDetalle.Text = articulo.Category.Descripcion;
                txtUrlImagenDetalle.Text = articulo.ImagenUrl;
                cargarImagen(articulo.ImagenUrl);
                txtPrecioDetalle.Text = articulo.Precio.ToString();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenDetalle.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenDetalle.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
    }
}
