namespace TPN7TorresMariano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var repo = new EmpleadoRepository();
            dgvEmpleados.DataSource = repo.ObtenerTodos();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado nuevoEmpleado = new Empleado
                {
                    NombreCompleto = txtNombre.Text,
                    DNI = txtDni.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    Casado = ckbCasado.Checked,
                    Salario = Convert.ToDecimal(txtSalario.Text)
                };

                // Guardar en base de datos
                EmpleadoRepository repo = new EmpleadoRepository();
                repo.AgregarEmpleado(nuevoEmpleado);

                MessageBox.Show("Empleado agregado correctamente.");

                tabControl1.SelectedTab = tabPage1;
                dgvEmpleados.DataSource = repo.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el empleado:\n" + ex.Message);

            }
        }
    }
}
