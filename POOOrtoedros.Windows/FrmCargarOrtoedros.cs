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
    public partial class FrmCargarOrtoedros : Form
    {
        public FrmCargarOrtoedros()
        {
            InitializeComponent();
        }

        private Ortoedros ortoedro;
        private bool edicion = false;
        private RepositorioDeOrtoedros repositorio = new RepositorioDeOrtoedros();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboRellenos();
            
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (ortoedro == null)
                {
                    ortoedro = new Ortoedros();
                }

                ortoedro.aristasA = int.Parse(textBoxAristaA.Text);
                ortoedro.aristaB = int.Parse(textBoxAristaB.Text);
                ortoedro.aristaC = int.Parse(textBoxAristaA.Text);
                ortoedro.colorRelleno = (ColorRelleno)ColorRellenoComboBox.SelectedItem;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (!edicion)
            {
                if (!int.TryParse(textBoxAristaA.Text, out int aristaA))
                {
                    valido = false;
                    errorProvider1.SetError(textBoxAristaA, "Debe ingresar un un valor numerico");
                }
                if (!int.TryParse(textBoxAristaB.Text, out int aristaB))
                {
                    valido = false;
                    errorProvider1.SetError(textBoxAristaB, "Debe ingresar un un valor numerico");
                }
                if (!int.TryParse(textBoxAristaC.Text, out int aristaC))
                {
                    valido = false;
                    errorProvider1.SetError(textBoxAristaC, "Debe ingresar un un valor numerico");
                }

            }

            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CargarDatosComboRellenos()
        {
            var lista = Enum.GetValues(typeof(ColorRelleno)).Cast<ColorRelleno>().ToList();

            ColorRellenoComboBox.DataSource = lista;
            ColorRellenoComboBox.SelectedIndex = 0;

        }

        public Ortoedros GetOrtoedro()
        {
            return ortoedro;
        }

        public void SetOrtoedro(Ortoedros pEditar)
        {
            ortoedro = pEditar;
        }
    }
}
