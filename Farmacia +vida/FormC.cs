using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Farmacia__vida
{
    public partial class FormC : Form
    {
        string SqlConection = "Server = localhost; Port=3306; Database=Farmacia_Unach; Uid = root;  Pwd=12345;";

        public FormC()
        {
            InitializeComponent();
            this.CenterToParent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instanciar el nuevo formulario
            // FormCobro newForm = new FormCobro();

            // Mostrar el formulario
            //newForm.Show();

            //string textoSeleccionado = string.Join(", ", listBox1.SelectedItems.Cast<string>());


            // Instanciar FormCobro usando el constructor con un argumento
            //FormCobro formCobro = new FormCobro(textoSeleccionado);

            // Mostrar FormCobro
            //formCobro.Show();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                string idProducto = dataGridView1.SelectedRows[0].Cells["Id_inventario"].Value.ToString();
                string nombreProducto = dataGridView1.SelectedRows[0].Cells["Nombre_Producto"].Value.ToString();
                string categoria = dataGridView1.SelectedRows[0].Cells["Categoría"].Value.ToString();
                string cantidad = dataGridView1.SelectedRows[0].Cells["Cantidad"].Value.ToString();
                string precioUnitario = dataGridView1.SelectedRows[0].Cells["Precio_Unitario"].Value.ToString();

                // Concatenar todos los datos en un solo string
                string datosConcatenados = $"ID Producto: {idProducto}, Nombre: {nombreProducto}, Categoría: {categoria}, Cantidad: {cantidad}, Precio: ${precioUnitario}";

                // Crear una instancia del segundo formulario (Form2)
                FormCobro formCobro = new FormCobro();

                // Pasar los datos concatenados al segundo formulario
                formCobro.SetData(datosConcatenados);

                // Abrir el segundo formulario
                formCobro.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }
        }

        private void FormC_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();

        }
        private void LlenarDataGridView()
        {
            using (MySqlConnection conexion = new MySqlConnection(SqlConection))
            {
                try
                {
                    conexion.Open();

                    // Consulta para obtener los datos de la tabla Inventario
                    string consulta = "SELECT * FROM Inventario";

                    // Adaptador para llenar el DataTable
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);

                    // Crear un DataTable y llenarlo con los datos
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    // Asignar el DataTable como fuente de datos del DataGridView
                    dataGridView1.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
