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

            // Habilitar la selección múltiple
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void CargarDatos()
        {
            using (MySqlConnection connection = new MySqlConnection(SqlConection))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM producto"; // Ajusta la consulta según tus necesidades
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Crear una lista para almacenar el nombre y precio de los productos seleccionados
                List<(string Nombre, string Precio)> productos = new List<(string, string)>();
                decimal sumaTotal = 0;

                // Recorrer todas las filas seleccionadas
                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    string nombreProducto = fila.Cells["Nombre_Producto"].Value.ToString();
                    string precioUnitario = fila.Cells["Precio_Unitario"].Value.ToString();

                    if (decimal.TryParse(precioUnitario, out decimal precio))
                    {
                        sumaTotal += precio;
                    }

                    // Agregar el producto a la lista
                    productos.Add((nombreProducto, precioUnitario));
                }

                // Crear una instancia del segundo formulario (FormCobro)
                FormCobro formCobro = new FormCobro();

                // Pasar la lista de productos al segundo formulario
                formCobro.SetData(productos, sumaTotal);

                // Mostrar el segundo formulario
                formCobro.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos una fila.");
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
                    string consulta = "SELECT * FROM Producto";

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarDatos();

        }
    }
}
