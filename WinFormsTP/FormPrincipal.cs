using WinFormsTP.Datos;
using WinFormsTP.Entidades;
//Profe no llegué a practicar como poner los bordes y colores seleccionables
//pero intente hacer algo parecido, el repositorio y entidades dicen cuadrado y rectangulo
//porque use un forms que estuve practicando y si le cambio el nombre se rompe
namespace WinFormsTP
{
    public partial class FormPrincipal : Form
    {
        private RepositorioDeCuadrados repo;
        private List<Rectangulo> lista;
        int valorFiltro;
        bool filterOn = false;
        public FormPrincipal()
        {
            InitializeComponent();
            repo = new RepositorioDeCuadrados();
            ActualizarCantidadDeRegistros();
            txtCantidad.Text = repo.GetCantidad().ToString();
        }

        private void SalirPrograma(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FormAgregar Form = new FormAgregar() { Text = "Agregar Esfera" };
            DialogResult dr = Form.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            Rectangulo esfera = Form.GetEsfera();

            if (!repo.Existe(esfera))
            {
                repo.Agregar(esfera);
                ActualizarCantidadDeRegistros();
                DataGridViewRow l = ConstruirFila();
                SetearFila(l, esfera);
                AgregarFila(l);

                MessageBox.Show("Fila agregada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarFila(DataGridViewRow l)
        {
            dgvDatos.Rows.Add(l);
        }

        private void SetearFila(DataGridViewRow l, Rectangulo esfera)
        {
            l.Cells[colRadio.Index].Value = esfera.GetRadio();
            l.Cells[colBorde.Index].Value = esfera.GetBorde();
            l.Cells[colColor.Index].Value = esfera.GetColor();
            l.Cells[ColArea.Index].Value = esfera.GetArea().ToString(".000");
            l.Cells[ColVolumen.Index].Value = esfera.GetVolumen().ToString(".000");
            l.Tag = esfera;
        }

        private DataGridViewRow ConstruirFila()
        {
            var l = new DataGridViewRow();
            l.CreateCells(dgvDatos);
            return l;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (repo.GetCantidad() > 0)
            {
                RecargarGrilla();
            }
        }

        private void RecargarGrilla()
        {
            valorFiltro = 0;
            filterOn = false;
            TsbFiltrar.BackColor = SystemColors.Control;
            lista = repo.GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var rect in lista)
            {
                DataGridViewRow l = ConstruirFila();
                SetearFila(l, rect);
                AgregarFila(l);
            }
        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Desea eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            else
            {
                var l = dgvDatos.SelectedRows[0];
                QuitarFila(l);
                var circBorrar = (Rectangulo)l.Tag;
                repo.Borrar(circBorrar);
                ActualizarCantidadDeRegistros();
                MessageBox.Show("Fila eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarCantidadDeRegistros()
        {
            if (valorFiltro > 0)
            {
                txtCantidad.Text = repo.GetCantidad(valorFiltro).ToString();
            }
            else
            {
                txtCantidad.Text = repo.GetCantidad().ToString();
            }
        }

        private void QuitarFila(DataGridViewRow l)
        {
            dgvDatos.Rows.Remove(l);
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var FilaSeleccionada = dgvDatos.SelectedRows[0];
            Rectangulo esfera = (Rectangulo)FilaSeleccionada.Tag;
            Rectangulo esferaCopia = (Rectangulo)esfera.Clone();
            FormAgregar frm = new FormAgregar() { Text = "Editar esfera" };
            frm.SetEsfera(esfera);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            esfera = frm.GetEsfera();
            if (!repo.Existe(esfera))
            {
                repo.Editar(esferaCopia, esfera);
                SetearFila(FilaSeleccionada, esfera);
                MessageBox.Show("Fila editada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SetearFila(FilaSeleccionada, esferaCopia);
                MessageBox.Show("Registro existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbFiltrar_Click(object sender, EventArgs e)
        {
            if (!filterOn)
            {
                var lado1Filtro = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor para filtrar",
            "Filtrar por Mayor",
            "0", 200, 200);
                if (!int.TryParse(lado1Filtro, out valorFiltro))
                {
                    return;
                }
                if (valorFiltro <= 0)
                {
                    return;
                }
                lista = repo.Filtrar(valorFiltro);
                TsbFiltrar.BackColor = Color.LightBlue;
                filterOn = true;
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros();

            }
            else
            {
                MessageBox.Show("Filtro aplicado! \n Debe actualizar la grilla",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TsbRefrescar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void ascendenteL1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarAscL1();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void descendenteL1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDescL1();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void ascendenteL2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarAscL2();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void descendenteL2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDescL2();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }
    }
}