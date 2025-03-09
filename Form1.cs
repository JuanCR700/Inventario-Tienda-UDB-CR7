using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Inventario_Machote.Form1;



namespace Inventario_Machote
{


    public partial class Form1 : Form


    {   //Variables Globales

        private List<Producto> inventario = new List<Producto>();
        private List<Cliente> listaClientes = new List<Cliente>();
        private Dictionary<int, Venta> ventas = new Dictionary<int, Venta>(); // Diccionario para las ventas
        private double totalVenta = 0.0; // Campo para almacenar el total de la venta
        private int ultimoIDVenta = 0; // Contador para el ID de venta

        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarDataGridViewClientes();
            ConfigurarDataGridViewVentas();
        }

        // Métodos buscar clientes
        private Cliente BuscarCliente(string entrada)
        {
            // Buscar por ID
            if (int.TryParse(entrada, out int idCliente))
            {
                return listaClientes.Find(c => c.ID == idCliente);
            }

            // Buscar por nombre
            return listaClientes.Find(c => c.Nombre.Equals(entrada, StringComparison.OrdinalIgnoreCase));
        }

        // Métodos buscar clientes y productos
        private Producto BuscarProducto(string entrada)
        {
            // Buscar por ID
            if (int.TryParse(entrada, out int idProducto))
            {
                return inventario.Find(p => p.ID == idProducto);
            }

            // Buscar por nombre
            return inventario.Find(p => p.Nombre.Equals(entrada, StringComparison.OrdinalIgnoreCase));
        }

        private void ConfigurarDataGridView()
        {
            // DataGridView Productos
            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("ID", "ID");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Categoria", "Categoría");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("CantidadStock", "Cantidad en Stock");
        }

        // DataGridView Clientes
        private void ConfigurarDataGridViewClientes()
        {
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("ID", "ID");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Direccion", "Dirección");
            dgvClientes.Columns.Add("Telefono", "Teléfono");
        }

        // DataGridView ventas
        private void ConfigurarDataGridViewVentas()
        {
            dgvVentas.Columns.Clear();
            dgvVentas.Columns.Add("ID", "ID VENTA");
            dgvVentas.Columns.Add("ClienteID", "ID Cliente");
            dgvVentas.Columns.Add("Cliente", "Cliente");
            dgvVentas.Columns.Add("Producto", "Producto");
            dgvVentas.Columns.Add("CantidadProductos", "Cantidad");
            dgvVentas.Columns.Add("Precio", "Precio");
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

            public override string ToString()
            {
                return $"{ID} - {Nombre}"; // Formato que muestra ID y Nombre
            }

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

            public override string ToString()
            {
                return $"{ID} - {Nombre}"; // Formato que muestra ID y Nombre
            }

        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            ActualizarListaClientes();
        }
        

        //Codigo pestana ventas

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void lblProductosVentas_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadVentas_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProductoVenta_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un producto
            if (string.IsNullOrEmpty(txtProductoVenta.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID o nombre del producto.");
                return;
            }

            // Buscar el producto
            Producto productoSeleccionado = BuscarProducto(txtProductoVenta.Text);
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            // Validar que la cantidad ingresada sea un número válido
            if (!int.TryParse(txtCantidadVenta.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida.");
                return;
            }

            // Verificar si hay suficiente stock
            if (productoSeleccionado.CantidadStock >= cantidad)
            {
                // Agregar el producto al DataGridView de ventas
                dgvVentas.Rows.Add(productoSeleccionado.ID, productoSeleccionado.Nombre, cantidad, productoSeleccionado.Precio, cantidad * productoSeleccionado.Precio);

                // Actualizar el stock del producto
                productoSeleccionado.CantidadStock -= cantidad;

                // Actualizar el total de la venta
                totalVenta += productoSeleccionado.Precio * cantidad;
                txtTotalVenta.Text = $"{totalVenta:F2}";

                // Limpiar el campo de producto y cantidad
                txtProductoVenta.Text = string.Empty;
                txtCantidadVenta.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Stock insuficiente.");
            }

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un cliente
            if (string.IsNullOrEmpty(txtClienteVenta.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID o nombre del cliente.");
                return;
            }

            // Buscar el cliente
            Cliente clienteSeleccionado = BuscarCliente(txtClienteVenta.Text);
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            // Generar un nuevo ID de venta
            int nuevoIDVenta = ventas.Count + 1;
            while (ventas.ContainsKey(nuevoIDVenta))
            {
                nuevoIDVenta++;
            }

            // Crear una nueva venta
            Venta nuevaVenta = new Venta
            {
                ID = nuevoIDVenta,
                Cliente = clienteSeleccionado,
                Total = totalVenta
            };

            // Agregar la nueva venta al diccionario
            ventas[nuevaVenta.ID] = nuevaVenta;

            // Mostar ID de la venta en el TextBox
            txtIDVenta.Text = nuevaVenta.ID.ToString();

            // Actualizar la interfaz
            ActualizarListaVentas();
            ActualizarListaProductos();

            // Reiniciar el total de la venta
            totalVenta = 0.0;
            txtTotalVenta.Text = $"{totalVenta:F2}";

            // Limpiar los campos
            txtClienteVenta.Text = string.Empty;
            txtProductoVenta.Text = string.Empty;
            txtCantidadVenta.Text = string.Empty;

            MessageBox.Show("Venta registrada correctamente.");
        }

        // Actualizar la lista de ventas
        private void ActualizarListaVentas()
        {
            dgvVentas.Rows.Clear(); // Limpiar el DataGridView antes de mostrar los datos
            foreach (var venta in ventas.Values)
            {
                string productos = string.Join(", ", venta.ProductosVendidos.Select(p => $"ID: {p.Key}, Cantidad: {p.Value}"));
                dgvVentas.Rows.Add(venta.ID, venta.Cliente.ID, venta.Cliente.Nombre, productos, venta.Total); // Mostrar el total
            }
        
        }

        private void btnMostarVentas_Click(object sender, EventArgs e)
        {

        }

        private void lblIDVenta_Click(object sender, EventArgs e)
        {

        }

        private void txtIDVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una venta para eliminar.");
                return;
            }

            int idVenta = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells[0].Value);
            if (ventas.TryGetValue(idVenta, out Venta ventaAEliminar))
            {
                // Devolver los productos al stock
                foreach (var producto in ventaAEliminar.ProductosVendidos)
                {
                    Producto productoEnInventario = inventario.Find(p => p.ID == producto.Key);
                    if (productoEnInventario != null)
                    {
                        productoEnInventario.CantidadStock += producto.Value; // Devolver la cantidad al stock
                    }
                }
            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalVenta_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalVenta_TextChanged(object sender, EventArgs e)
        {

        }

        // Clase Venta
        public class Venta
        {
            public int ID { get; set; }
            public Cliente Cliente { get; set; }
            public Dictionary<int, int> ProductosVendidos { get; set; } = new Dictionary<int, int>(); // ID del producto y cantidad
            public double Total { get; set; }
        }
    }
}