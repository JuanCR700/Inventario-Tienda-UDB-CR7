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


    public partial class Form1: Form
    {
        private List<Producto> inventario = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
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
    }
}
