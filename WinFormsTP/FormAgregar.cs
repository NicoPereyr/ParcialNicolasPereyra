using WinFormsTP.Entidades;

namespace WinFormsTP
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private Rectangulo esfera;

        public Rectangulo GetEsfera()
        { return esfera; }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            if (esfera != null)
            {
                txtRadio.Text = esfera.Radio.ToString();
                txtBorde.Text = esfera.Borde.ToString();
                txtColor.Text = esfera.Color.ToString();
            }
        }

        public void SetEsfera(Rectangulo esfera)
        {
            this.esfera = esfera;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int radio = int.Parse(txtRadio.Text);
                string borde = (txtBorde.Text);
                string color = (txtColor.Text);
                esfera = new Rectangulo(radio, borde, color);
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            lado1ErrorProvider.Clear();
            //lado2ErrorProvider.Clear();

            if (!int.TryParse(txtRadio.Text, out int radio) || radio <= 0)
            {
                valido = false;
                lado1ErrorProvider.SetError(txtRadio, "Número no válido");
            }

            //if (!string(txtBorde.Text, out string borde))
            //{
            //    valido = false;
            //    lado2ErrorProvider.SetError(txtBorde, "Número no válido");
            //}
            return valido;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtRadio.Text = "0";
            txtBorde.Clear();
            txtColor.Clear();
        }

        private void LabelAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}