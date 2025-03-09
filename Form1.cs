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

        // Métodos para configurar columnas
        private void ConfigurarColumnasAgregarProductos()
        {
            dgvVentas.Columns.Clear();
            dgvVentas.Columns.Add("IDProducto", "ID Producto");
            dgvVentas.Columns.Add("NombreProducto", "Nombre del Producto");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("Precio", "Precio");
        }

        private void ConfigurarColumnasMostrarVentas()
        {
            dgvVentas.Columns.Clear();
            dgvVentas.Columns.Add("IDVenta", "ID Venta");
            dgvVentas.Columns.Add("Cliente", "Cliente");
            dgvVentas.Columns.Add("IDProducto", "ID Producto");
            dgvVentas.Columns.Add("NombreProducto", "Nombre del Producto");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvVentas.Columns.Add("Total", "Total");
        }

        // Métodos buscar clientes
        private Cliente BuscarCliente(string idCliente)
        {
            // Buscar por ID
            if (int.TryParse(idCliente, out int id))
            {
                return listaClientes.Find(c => c.ID == id);
            }

            // Buscar por nombre
            return listaClientes.Find(c => c.Nombre.Equals(idCliente, StringComparison.OrdinalIgnoreCase));
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
            dgvVentas.Columns.Add("ProductoID", "ID Producto");
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
            ConfigurarColumnasAgregarProductos();

            // Validar que se haya ingresado un producto
            if (string.IsNullOrEmpty(txtIDProductoVenta.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del producto.");
                return;
            }

            // Buscar el producto
            Producto productoSeleccionado = BuscarProducto(txtIDProductoVenta.Text);
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

                // Limpiar el campo de producto venta, cantidad venta, nombre de producto venta y nombre cliente venta
                txtIDProductoVenta.Text = string.Empty;
                txtCantidadVenta.Text = string.Empty;
                txtNombreProductoVentas.Text = string.Empty;
                txtNombreClienteVenta.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Stock insuficiente.");
            }

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un cliente
            if (string.IsNullOrEmpty(txtIDClienteVenta.Text))
            {
                MessageBox.Show("Por favor ingresa el ID del Cliente");
                return;
            }

            // Buscar el cliente
            Cliente clienteSeleccionado = listaCliente(txtIDClienteVenta.Text);
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            // Validar que hay productos en la venta
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.");
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
                ID = ventas.Count + 1,
                Cliente = clienteSeleccionado,
                Total = totalVenta,
                ProductosVendidos = new Dictionary<int, int>()
            };

            // Recorrer las filas del DataGridView para agregar los productos vendidos
            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                int idProducto = Convert.ToInt32(fila.Cells["IDProducto"].Value);
                int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                nuevaVenta.ProductosVendidos.Add(idProducto, cantidad); // Agregar producto vendido
            }

            // Agregar la nueva venta al diccionario
            ventas[nuevaVenta.ID] = nuevaVenta;

            // Mostrar mensaje de éxito
            MessageBox.Show("Venta registrada correctamente.");

            // Mostar ID de la venta en el TextBox
            txtIDVenta.Text = nuevaVenta.ID.ToString();

            // Actualizar la interfaz
            ActualizarListaVentas();
            ActualizarListaProductos();

            // Reiniciar el total de la venta
            totalVenta = 0.0;
            txtTotalVenta.Text = $"{totalVenta:F2}";

            // Limpiar los campos
            dgvVentas.Rows.Clear();
            txtIDClienteVenta.Text = string.Empty;
            txtNombreClienteVenta.Text = string.Empty;
            txtIDProductoVenta.Text = string.Empty;
            txtNombreProductoVentas.Text = string.Empty;
            txtCantidadVenta.Text = string.Empty;
            txtTotalVenta.Text = "0.00";

            // Reiniciar el total de la venta
            totalVenta = 0.0;
            txtTotalVenta.Text = $"{totalVenta:F2}";

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
            ConfigurarColumnasMostrarVentas();

            // Limpiar el DataGridView antes de mostrar las ventas
            dgvVentas.Rows.Clear();

            // Verificar si hay ventas registradas
            if (ventas.Count == 0)
            {
                MessageBox.Show("No hay ventas registradas.");
                return;
            }

            // Recorrer todas las ventas registradas
            foreach (var venta in ventas.Values)
            {
                // Obtener el cliente de la venta
                Cliente cliente = venta.Cliente;

                // Recorrer los productos vendidos en la venta
                foreach (var productoVendido in venta.ProductosVendidos)
                {
                    int idProducto = productoVendido.Key; // ID del producto
                    int cantidad = productoVendido.Value; // Cantidad vendida

                    // Buscar el producto en el inventario
                    Producto producto = inventario.Find(p => p.ID == idProducto);
                    if (producto != null)
                    {
                        // Agregar una fila al DataGridView con los detalles de la venta
                        dgvVentas.Rows.Add(
                            venta.ID,               // ID de la venta
                            cliente.Nombre,         // Nombre del cliente
                            producto.ID,            // ID del producto
                            producto.Nombre,        // Nombre del producto
                            cantidad,               // Cantidad vendida
                            producto.Precio,        // Precio unitario
                            cantidad * producto.Precio // Total
                        );
                    }
                }
            }
        }

        private void lblIDVenta_Click(object sender, EventArgs e)
        {

        }

        private void txtIDVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una venta para eliminar.");
                return;
            }

            // Obtener el ID de la venta seleccionada
            int idVenta = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells["IDVenta"].Value);

            // Buscar la venta en el diccionario
            if (ventas.TryGetValue(idVenta, out Venta ventaAEliminar))
            {
                // Devolver los productos al stock
                foreach (var productoVendido in ventaAEliminar.ProductosVendidos)
                {
                    int idProducto = productoVendido.Key; // ID del producto
                    int cantidad = productoVendido.Value; // Cantidad vendida

                    // Buscar el producto en el inventario
                    Producto productoEnInventario = inventario.Find(p => p.ID == idProducto);
                    if (productoEnInventario != null)
                    {
                        productoEnInventario.CantidadStock += cantidad; // Devolver la cantidad al stock
                    }
                }

                // Eliminar la venta del diccionario
                ventas.Remove(idVenta);

                // Mostrar mensaje de éxito
                MessageBox.Show($"Venta con ID {idVenta} eliminada correctamente.");

                // Actualizar el DataGridView
                ActualizarListaVentas();
            }
            else
            {
                MessageBox.Show("Venta no encontrada.");
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

        private void txtNombreClienteVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDProductoVenta_TextChanged(object sender, EventArgs e)
        {
            // Buscar el cliente por ID o nombre
            Cliente clienteSeleccionado = listaCliente(txtIDClienteVenta.Text);
            if (clienteSeleccionado != null)
            {
                txtNombreClienteVenta.Text = clienteSeleccionado.Nombre; // Asignar el nombre del cliente
            }
            else
            {
                txtNombreClienteVenta.Text = string.Empty; // Limpiar el nombre si no se encuentra
            }
        }

        private void txtIDClienteVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarClienteVenta_Click(object sender, EventArgs e)
        {
            // Obtener el código del cliente ingresado
            string codigoCliente = txtIDClienteVenta.Text;

            // Buscar el cliente por ID
            Cliente clienteSeleccionado = listaCliente(codigoCliente);
            if (clienteSeleccionado != null)
            {
                // Si se encuentra, mostrar el nombre en txtNombreClienteVenta
                txtNombreClienteVenta.Text = clienteSeleccionado.Nombre;
            }
            else
            {
                // Si no se encuentra, limpiar el campo de nombre
                txtNombreClienteVenta.Text = string.Empty;
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        // Método para buscar cliente (ejemplo)
        private Cliente listaCliente(string idCliente)
        {
            // Suponiendo que tienes una lista o diccionario de clientes
            return listaClientes.FirstOrDefault(c => c.ID.ToString() == idCliente || c.Nombre.Equals(idCliente, StringComparison.OrdinalIgnoreCase));
        }

        private void btnBuscarProductoVentas_Click(object sender, EventArgs e)
        {
            // Obtener el ID del producto ingresado
            string idProducto = txtIDProductoVenta.Text.Trim();

            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(idProducto))
            {
                MessageBox.Show("Por favor, ingresa el ID del producto.");
                return;
            }

            // Buscar el producto por ID
            Producto productoEncontrado = BuscarProducto(idProducto);

            // Verificar si se encontró el producto
            if (productoEncontrado != null)
            {
                // Mostrar el nombre del producto en txtNombreProductoVentas
                txtNombreProductoVentas.Text = productoEncontrado.Nombre;
            }
            else
            {
                // Limpiar el campo si no se encuentra el producto
                txtNombreProductoVentas.Text = string.Empty;
                MessageBox.Show("Producto no encontrado.");
            }
        }
    }
}