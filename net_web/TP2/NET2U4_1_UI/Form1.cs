using NET2U4_2_BLL;

namespace NET2U4_1_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNombre.Text))
            {
                MessageBox.Show("Ingrese su nombre");
            }
            else
            {
                var bll = new ClassBll();
                var respuesta = bll.LlamarHola(tbxNombre.Text);

                if(respuesta != null)
                {
                    MessageBox.Show(respuesta);
                }
            }
        }
    }
}
