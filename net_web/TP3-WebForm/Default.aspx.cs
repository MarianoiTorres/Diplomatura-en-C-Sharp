using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3TorresMariano
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string seleccionado = DropDownList1.SelectedValue;
            ListBox1.Items.Add(seleccionado);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            string ruta = Server.MapPath("~/App_Data/compras.txt");
            string nombre = TextBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Label4.Text = "Por favor ingrese su nombre.";
                return;
            }
            if (ListBox1.Items.Count == 0)
            {
                Label4.Text = "El carrito está vacío.";
                return;
            }

            int nuevoIDCompra = 1;
            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                if (lineas.Length > 0)
                {
                    string ultimaLinea = lineas[lineas.Length - 1];
                    int.TryParse(ultimaLinea.Split(',')[0], out nuevoIDCompra);
                    nuevoIDCompra += 1;
                }
            }

            using (StreamWriter sw = File.AppendText(ruta))
            {
                int idItem = 1;
                foreach (ListItem item in ListBox1.Items)
                {
                    sw.WriteLine($"{nuevoIDCompra},{idItem},{nombre},{item.Text}");
                    idItem++;
                }
            }

            Label4.Text = "Compra realizada con exito";
        }
    }
}