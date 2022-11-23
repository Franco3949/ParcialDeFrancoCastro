using POOEntidades.Ortoedros;
using POOOrtoedros.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOOrtoedros.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private RepositorioDeOrtoedros repositorio;
        private List<Ortoedros> lista;

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmCargarOrtoedros frm = new FrmCargarOrtoedros();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            Ortoedros o = frm.GetOrtoedro();

            repositorio.Agregar(o);
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, o);
            AgregarFila(r);

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Ortoedros o)
        {
            r.Cells[clmAristaA.Index].Value = o.aristasA;
            r.Cells[clmAristaB.Index].Value = o.aristaB;
            r.Cells[clmAristaC.Index].Value = o.aristaC;
            r.Cells[clmColorRelleno.Index].Value = o.colorRelleno;
            r.Cells[clmArea.Index].Value = o.GetArea();
            r.Cells[clmVolumen.Index].Value = o.GetVolumen();
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarComboColorRellenos();
            repositorio = new RepositorioDeOrtoedros();
            if (repositorio.GetCantidad() > 0)
            {
                RecargarGrilla();
            }
        }

        private void RecargarGrilla()
        {
            lista = repositorio.GetLista();
            MostrarLista();
        }

        private void MostrarLista()
        {
            dgvDatos.Rows.Clear();
            foreach (var persona in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, persona);
                AgregarFila(r);
            }
        }

        private void CargarComboColorRellenos()
        {
            var listaRellenos = Enum.GetValues(typeof(ColorRelleno)).Cast<ColorRelleno>().ToList();
            foreach (var colorRelleno in listaRellenos)
            {
                tscboLocalidades.ComboBox.Items.Add(colorRelleno);
            };
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Ortoedros pEditar = r.Tag as Ortoedros;
            FrmCargarOrtoedros frm = new FrmCargarOrtoedros() { Text = "Editar Ortoedros" };
            frm.SetOrtoedro(pEditar);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            pEditar = frm.GetOrtoedro();
            SetearFila(r, pEditar);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Ortoedros pBorrar = r.Tag as Ortoedros;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el ortoedro con las medidas {pBorrar.aristasA}, {pBorrar.aristaB} y {pBorrar.aristaC}?",
                "Confirmar Borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            repositorio.Borrar(pBorrar);
            dgvDatos.Rows.Remove(r);
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
    }
}
