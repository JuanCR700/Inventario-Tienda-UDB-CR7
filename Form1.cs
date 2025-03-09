using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Inventario_Machote
{


    public partial class Form1 : Form
    {
        private List<Producto> inventario = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            // Configurar las columnas del DataGridView
            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("ID", "ID");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Categoria", "Categoría");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("CantidadStock", "Cantidad en Stock");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Validar que el ID ingresado sea un número válido
            int idManual;
            if (!int.TryParse(txtIDProducto.Text, out idManual))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            // Validar que el ID no exista en la lista de inventario
            if (inventario.Any(p => p.ID == idManual))
            {
                MessageBox.Show("El ID ingresado ya existe. Por favor, utiliza otro ID.");
                return;
            }

            // Validar que el precio sea un número válido
            if (!double.TryParse(txtPrecioProducto.Text, out double precio) || precio < 0)
            {
                MessageBox.Show("Por favor, ingresa un precio válido.");
                return;
            }

            // Validar que la cantidad en stock sea un número válido
            if (!int.TryParse(txtStockProducto.Text, out int cantidadStock) || cantidadStock < 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad en stock válida.");
                return;
            }

            // Crear el nuevo producto con el ID manual
            Producto nuevoProducto = new Producto
            {
                ID = idManual,
                Nombre = txtNombreProducto.Text,
                Categoria = cbCategoriaProducto.Text,
                Precio = double.Parse(txtPrecioProducto.Text),
                CantidadStock = int.Parse(txtStockProducto.Text)
            };

            // Agregar el producto a la lista
            inventario.Add(nuevoProducto);

            // Mostrar mensaje de éxito
            MessageBox.Show("Producto registrado correctamente.");

            // Actualizar el DataGridView
            ActualizarListaProductos();

            // Limpiar los campos después de agregar el producto
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            txtIDProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecioProducto.Text = "0.0";
            txtStockProducto.Text = "0";
            cbCategoriaProducto.SelectedIndex = -1;
        }


        private void ActualizarListaProductos()
        {
            dgvProductos.Rows.Clear();
            foreach (var producto in inventario)
            {
                dgvProductos.Rows.Add(producto.ID, producto.Nombre, producto.Categoria, producto.Precio, producto.CantidadStock);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarStock_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            foreach (var producto in inventario)
            {
                dgvProductos.Rows.Add(producto.ID, producto.Nombre, producto.Categoria, producto.Precio, producto.CantidadStock);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)

                // Verificar si hay una fila seleccionada en el DataGridView
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    // Obtener el ID del producto seleccionado
                    int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value);

                    // Buscar y eliminar el producto de la lista
                    Producto productoAEliminar = inventario.Find(p => p.ID == idProducto);
                    if (productoAEliminar != null)
                    {
                        inventario.Remove(productoAEliminar);
                        MessageBox.Show($"Producto con ID {idProducto} eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado en el inventario.");
                    }

                    // Actualizar el DataGridView
                    ActualizarListaProductos();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un producto para eliminar.");
                }
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView antes de mostrar los resultados de la búsqueda
            dgvProductos.Rows.Clear();

            // Obtener el texto ingresado para buscar
            string idBusqueda = txtIDProducto.Text.Trim();
            string nombreBusqueda = txtNombreProducto.Text.Trim().ToLower();

            // Lista para los resultados de la búsqueda
            List<Producto> productosEncontrados = new List<Producto>();

            // Realizar la búsqueda por ID si el campo ID no está vacío
            if (!string.IsNullOrEmpty(idBusqueda))
            {
                if (int.TryParse(idBusqueda, out int id))
                {
                    productosEncontrados = inventario.Where(p => p.ID == id).ToList();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido.");
                    return;
                }
            }
            // Realizar la búsqueda por nombre si el campo Nombre no está vacío
            else if (!string.IsNullOrEmpty(nombreBusqueda))
            {
                productosEncontrados = inventario.Where(p => p.Nombre.ToLower().Contains(nombreBusqueda)).ToList();
            }
            else
            {
                MessageBox.Show("Por favor, completa el campo ID o Nombre para realizar la búsqueda.");
                return;
            }

            // Verificar si se encontraron productos
            if (productosEncontrados.Any())
            {
                foreach (var producto in productosEncontrados)
                {
                    dgvProductos.Rows.Add(producto.ID, producto.Nombre, producto.Categoria, producto.Precio, producto.CantidadStock);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron productos con los criterios de búsqueda ingresados.");
            }
        }

        public class Producto
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public double Precio { get; set; }
            public int CantidadStock { get; set; }
        }
    }
}