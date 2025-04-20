namespace TPN6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string autor = textBoxAutor.Text;
            string genero = comboBoxGenero.Text;
            string pagina = textBoxPaginas.Text;
            bool esImportado = checkBox1.Checked;
            string precio = textBoxPrecio.Text;

            string importado = esImportado == true ? "Importado" : "Nacional";

            listBox1.Items.Add($"{nombre} - {autor} - {genero} - {pagina} - {importado} - {precio}");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
