using InventarioLaboratorio.Busquedas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioLaboratorio
{
    public partial class FrmReactivos : Form
    {
        public FrmReactivos()
        {
            InitializeComponent();
        }

        public Reactivo ReactivoSeleccionado { get; set; }
        public Reactivo ReactivoActual { get; set; }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmCatalogo formCatalogo = new FrmCatalogo();
            formCatalogo.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaReactivo AltasReactivo = AltaReactivo.ObtenerInstanciaReactivo();
            AltasReactivo.Show();
        }

        private void FrmReactivos_Load(object sender, EventArgs e)
        {
        
        }
        public void filtro(string lab, string tipo)
        {
            Sql s = new Sql();
            string query = string.Format("select Id, Nombre, Numero, Clasificacion, Laboratorio, Caducidad, Catalogo, Unidad, Observaciones from Reactivo where Laboratorio = '{0}' and Clasificacion = '{1}'",lab,tipo);          
                    s.dgrid(dgvReactivo,query);
             
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtro(lstLaboratorio.Text,lstTipo.Text);
         //   filtro();
       //    dgvReactivo.DataSource = ReactivoDB.BuscarReactivo(lstLaboratorio.Text, lstTipo.Text);

            lblNombre.Visible = true;
            txtReacNom.Visible = true;
            lblNumero.Visible = true;
            txtReacNum.Visible = true;
            lblCaducidad.Visible = true;
            txtBscCad.Visible = true;
            lblCatalogo.Visible = true;
            txtReacCat.Visible = true;
            lblUnidad.Visible = true;
            txtReacUni.Visible = true;
            lblObservacion.Visible = true;
            txtReacObs.Visible = true;
            btnExportar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            ModificarReactivo ModRea = new ModificarReactivo();
            if (dgvReactivo.SelectedRows.Count > 0)
            {
                ModRea.txtReacID.Text = dgvReactivo.CurrentRow.Cells[0].Value.ToString();
                ModRea.txtReacNom.Text = dgvReactivo.CurrentRow.Cells[1].Value.ToString();
                ModRea.txtReacNum.Text = dgvReactivo.CurrentRow.Cells[2].Value.ToString();
                ModRea.lstClasificacion.Text = dgvReactivo.CurrentRow.Cells[3].Value.ToString();
                ModRea.lstLaboratorio.Text = dgvReactivo.CurrentRow.Cells[4].Value.ToString();
                ModRea.txtReacCad.Text = dgvReactivo.CurrentRow.Cells[5].Value.ToString();
                ModRea.txtReacCat.Text = dgvReactivo.CurrentRow.Cells[6].Value.ToString();
                ModRea.txtReacUni.Text = dgvReactivo.CurrentRow.Cells[7].Value.ToString();
                ModRea.txtReacObs.Text = dgvReactivo.CurrentRow.Cells[8].Value.ToString();

                ModRea.ShowDialog();
            }
            else
            {
                MessageBox.Show("Asegúrese de seleccionar una fila", "Dato no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvReactivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Login CerrarSesion = new Login();
            CerrarSesion.Show();
            this.Hide();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar exportar = new Exportar();
            exportar.ExportarDataGridViewExcel(dgvReactivo);
        }
        BusquedasP p = new BuscarPor();
        private void txtReacNom_TextChanged(object sender, EventArgs e)
        {
            p.Buscar(dgvReactivo, "Nombre", txtReacNom);
        }

        private void txtReacNum_TextChanged(object sender, EventArgs e)
        {
            p.Buscar(dgvReactivo, "Numero", txtReacNum);

        }

        private void txtBscCad_TextChanged(object sender, EventArgs e)
        {
            p.Buscar(dgvReactivo, "Caducidad", txtBscCad);

        }

        private void txtReacCat_TextChanged(object sender, EventArgs e)
        {
            p.Buscar(dgvReactivo, "Catalogo", txtReacCat);
        }

        private void txtReacUni_TextChanged(object sender, EventArgs e)
        {
            p.Buscar(dgvReactivo, "Unidad", txtReacUni);
        }

        private void txtReacObs_TextChanged(object sender, EventArgs e)
        {
            p.Buscar(dgvReactivo, "Observaciones", txtReacObs);
        }
    }
}
