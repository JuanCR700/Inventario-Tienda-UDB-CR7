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


    {   //Variables Globales

        private List<Producto> inventario = new List<Producto>();
        private List<Cliente> listaClientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarDataGridViewClientes();
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

        private void ConfigurarDataGridViewClientes()
        {
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("ID", "ID");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Direccion", "Dirección");
            dgvClientes.Columns.Add("Telefono", "Teléfono");
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

        //Codigo pestana Clientes

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNombreCliente_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void IDCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtIDCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void cbCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccionCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCliente(out Cliente nuevoCliente))
            {
                return; // La validación falló, se muestra el mensaje correspondiente
            }

            // Agregarlo a la lista
            listaClientes.Add(nuevoCliente);
            MessageBox.Show("Cliente registrado correctamente.");
            ActualizarListaClientes();
            LimpiarCamposClientes();
        }

        // Validar cliente
        private bool ValidarCliente(out Cliente cliente)
        {
            cliente = null;

            // Validar que el ID sea un número válido y único
            if (string.IsNullOrEmpty(txtIDCliente.Text) || !int.TryParse(txtIDCliente.Text, out int idCliente) || idCliente <= 0)
            {
                MessageBox.Show("Por favor, ingresa un ID de cliente válido (mayor a 0).");
                return false;
            }

            if (listaClientes.Any(c => c.ID == idCliente))
            {
                MessageBox.Show("El ID ingresado ya existe. Por favor, utiliza otro ID.");
                return false;
            }

            // Validar que el nombre no esté vacío
            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del cliente.");
                return false;
            }

            // Validar que la dirección no esté vacía
            if (string.IsNullOrEmpty(txtDireccionCliente.Text))
            {
                MessageBox.Show("Por favor, ingresa la dirección del cliente.");
                return false;
            }

            // Validar que el teléfono sea válido
            if (!EsTelefonoValido(txtTelefonoCliente.Text))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido (mínimo 8 dígitos).");
                return false;
            }

            // Crear el nuevo cliente
            cliente = new Cliente
            {
                ID = idCliente,
                Nombre = txtNombreCliente.Text.Trim(),
                Direccion = txtDireccionCliente.Text.Trim(),
                Telefono = txtTelefonoCliente.Text.Trim()
            };

            return true;
        }

        // Validar formato de teléfono
        private bool EsTelefonoValido(string telefono)
        {
            return !string.IsNullOrEmpty(telefono) && telefono.Length >= 8 && long.TryParse(telefono, out _);
        }

        // Limpiar campos de entrada de clientes
        private void LimpiarCamposClientes()
        {
            txtIDCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtDireccionCliente.Text = string.Empty;
            txtTelefonoCliente.Text = string.Empty;
        }

        // Actualizar el DataGridView con los clientes actuales
        private void ActualizarListaClientes()
        {
            dgvClientes.Rows.Clear();
            foreach (var cliente in listaClientes)
            {
                dgvClientes.Rows.Add(cliente.ID, cliente.Nombre, cliente.Direccion, cliente.Telefono);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.");
                return;
            }

            int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
            Cliente clienteAEliminar = listaClientes.Find(c => c.ID == idCliente);

            if (clienteAEliminar != null)
            {
                listaClientes.Remove(clienteAEliminar);
                MessageBox.Show($"Cliente con ID {idCliente} eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }

            ActualizarListaClientes();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();

            if (string.IsNullOrEmpty(txtIDCliente.Text) && string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                MessageBox.Show("Por favor, completa al menos el campo ID o Nombre para buscar un cliente.");
                return;
            }

            string idBusqueda = txtIDCliente.Text.Trim();
            string nombreBusqueda = txtNombreCliente.Text.Trim().ToLowerInvariant();

            List<Cliente> clientesEncontrados = new List<Cliente>();

            if (!string.IsNullOrEmpty(idBusqueda) && int.TryParse(idBusqueda, out int id))
            {
                clientesEncontrados = listaClientes.Where(c => c.ID == id).ToList();
            }
            else if (!string.IsNullOrEmpty(nombreBusqueda))
            {
                clientesEncontrados = listaClientes.Where(c => c.Nombre.ToLowerInvariant().Contains(nombreBusqueda)).ToList();
            }

            if (clientesEncontrados.Any())
            {
                foreach (var cliente in clientesEncontrados)
                {
                    dgvClientes.Rows.Add(cliente.ID, cliente.Nombre, cliente.Direccion, cliente.Telefono);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron clientes con los criterios ingresados.");
            }
        }

        // Clase Cliente
        public class Cliente
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            ActualizarListaClientes();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}