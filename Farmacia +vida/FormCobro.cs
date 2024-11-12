using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia__vida
{
    public partial class FormCobro : Form
    {
        string SqlConection = "Server = localhost; Port=3306; Database=Farmacia_Unach; Uid = root;  Pwd=12345;";

        public FormCobro()
        {
            InitializeComponent();
            this.CenterToParent();

        }
        public void SetData(string datosConcatenados)
        {
            // Asigna los datos al Label en el formulario
            LabelMostrar.Text = datosConcatenados;
        }

        // Constructor que recibe un texto como parámetro
      /*  public FormCobro(string texto)
        {
            InitializeComponent();
            // Asigna el texto al Label (asegúrate de que labelMostrar esté en tu formulario)
            LabelMostrar.Text = texto;
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Monto_Click(object sender, EventArgs e)
        {

        }

        private void FormCobro_Load(object sender, EventArgs e)
        {

        }

        private void BFinalizar_Click(object sender, EventArgs e)
        {
            string Pagar = textPagar.Text;
            string Recibido = textRecibido.Text;
            double RecibidoD = double.Parse(Recibido); // Convierte a int
            double PagarD = double.Parse(Pagar); // Convierte a int
            double cambio = RecibidoD - PagarD;
            string CambioS = cambio.ToString();
            MessageBox.Show("Productos adquiridos: \n\nTotal: " + Pagar, "\n\nRecibido: " + Recibido);            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void SetData(List<(string Nombre, string Precio)> productos, decimal sumaTotal)
        {
            // Limpiar cualquier dato anterior en el DataGridView
            dataGridViewProductos.Rows.Clear();

            // Agregar cada producto a la tabla
            foreach (var producto in productos)
            {
                dataGridViewProductos.Rows.Add(producto.Nombre, producto.Precio);
            }

            // Mostrar la suma total en el TextBox
            textPagar.Text = sumaTotal.ToString("C"); // "C" muestra el valor en formato de moneda
        }

        private void BContinuar_Click(object sender, EventArgs e)
        {
            string Pagar = textPagar.Text;
            string Recibido = textRecibido.Text;
            double RecibidoD = double.Parse(Recibido); // Convierte a int
            double PagarD = double.Parse(Pagar); // Convierte a int
            double cambio = RecibidoD - PagarD;
            labelCambio.Text = "$ "+ cambio;


        }

        private void LabelMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void textPagar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
