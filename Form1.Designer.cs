namespace Inventario_Machote
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IDCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.cbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.CantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarStock = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.tabControlInventario = new System.Windows.Forms.TabControl();
            this.cbClientesVentas = new System.Windows.Forms.ComboBox();
            this.lblClienteVenta = new System.Windows.Forms.Label();
            this.lblProductosVentas = new System.Windows.Forms.Label();
            this.cbProductosVentas = new System.Windows.Forms.ComboBox();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtIDVenta = new System.Windows.Forms.TextBox();
            this.lblIDVenta = new System.Windows.Forms.Label();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnMostarVentas = new System.Windows.Forms.Button();
            this.btnAgregarProductoVenta = new System.Windows.Forms.Button();
            this.IDVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductosVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProductoVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabControlInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(743, 446);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Estadisticas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtTotalVenta);
            this.tabPage3.Controls.Add(this.lblTotalVenta);
            this.tabPage3.Controls.Add(this.btnAgregarProductoVenta);
            this.tabPage3.Controls.Add(this.btnMostarVentas);
            this.tabPage3.Controls.Add(this.btnEliminarVenta);
            this.tabPage3.Controls.Add(this.lblIDVenta);
            this.tabPage3.Controls.Add(this.txtIDVenta);
            this.tabPage3.Controls.Add(this.dgvVentas);
            this.tabPage3.Controls.Add(this.btnRegistrarVenta);
            this.tabPage3.Controls.Add(this.lblCantidadVentas);
            this.tabPage3.Controls.Add(this.txtCantidadVenta);
            this.tabPage3.Controls.Add(this.cbProductosVentas);
            this.tabPage3.Controls.Add(this.lblProductosVentas);
            this.tabPage3.Controls.Add(this.lblClienteVenta);
            this.tabPage3.Controls.Add(this.cbClientesVentas);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(743, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvClientes);
            this.tabPage2.Controls.Add(this.btnAgregarCliente);
            this.tabPage2.Controls.Add(this.btnBuscarCliente);
            this.tabPage2.Controls.Add(this.btnEliminarCliente);
            this.tabPage2.Controls.Add(this.btnMostrarClientes);
            this.tabPage2.Controls.Add(this.txtTelefonoCliente);
            this.tabPage2.Controls.Add(this.txtDireccionCliente);
            this.tabPage2.Controls.Add(this.txtNombreCliente);
            this.tabPage2.Controls.Add(this.txtIDCliente);
            this.tabPage2.Controls.Add(this.lblTelefono);
            this.tabPage2.Controls.Add(this.lblDireccion);
            this.tabPage2.Controls.Add(this.lblNombreCliente);
            this.tabPage2.Controls.Add(this.IDCliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // IDCliente
            // 
            this.IDCliente.AutoSize = true;
            this.IDCliente.Location = new System.Drawing.Point(62, 25);
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.Size = new System.Drawing.Size(64, 16);
            this.IDCliente.TabIndex = 13;
            this.IDCliente.Text = "ID Cliente";
            this.IDCliente.Click += new System.EventHandler(this.IDCliente_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(62, 87);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(100, 16);
            this.lblNombreCliente.TabIndex = 15;
            this.lblNombreCliente.Text = "Nombre Cliente";
            this.lblNombreCliente.Click += new System.EventHandler(this.lblNombreCliente_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(62, 142);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(62, 195);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.AcceptsReturn = true;
            this.txtIDCliente.Location = new System.Drawing.Point(168, 19);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(173, 22);
            this.txtIDCliente.TabIndex = 21;
            this.txtIDCliente.TextChanged += new System.EventHandler(this.txtIDCliente_TextChanged);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(168, 81);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(252, 22);
            this.txtNombreCliente.TabIndex = 22;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(168, 131);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(173, 22);
            this.txtDireccionCliente.TabIndex = 23;
            this.txtDireccionCliente.TextChanged += new System.EventHandler(this.txtDireccionCliente_TextChanged);
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(168, 195);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(173, 22);
            this.txtTelefonoCliente.TabIndex = 24;
            this.txtTelefonoCliente.TextChanged += new System.EventHandler(this.txtTelefonoCliente_TextChanged);
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Location = new System.Drawing.Point(527, 131);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(135, 36);
            this.btnMostrarClientes.TabIndex = 16;
            this.btnMostrarClientes.Text = "Mostrar Clientes";
            this.btnMostrarClientes.UseMnemonic = false;
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(527, 77);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(135, 40);
            this.btnEliminarCliente.TabIndex = 26;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(527, 182);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(135, 35);
            this.btnBuscarCliente.TabIndex = 27;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(527, 19);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(135, 40);
            this.btnAgregarCliente.TabIndex = 28;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvClientes.Location = new System.Drawing.Point(0, 257);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(731, 171);
            this.dgvClientes.TabIndex = 29;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre Clientes";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 50F;
            this.dataGridViewTextBoxColumn6.HeaderText = "ID Clientes";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 25000;
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarProducto);
            this.tabPage1.Controls.Add(this.btnEliminarProducto);
            this.tabPage1.Controls.Add(this.btnAgregarProducto);
            this.tabPage1.Controls.Add(this.btnMostrarStock);
            this.tabPage1.Controls.Add(this.dgvProductos);
            this.tabPage1.Controls.Add(this.cbCategoriaProducto);
            this.tabPage1.Controls.Add(this.txtStockProducto);
            this.tabPage1.Controls.Add(this.txtPrecioProducto);
            this.tabPage1.Controls.Add(this.txtNombreProducto);
            this.tabPage1.Controls.Add(this.txtIDProducto);
            this.tabPage1.Controls.Add(this.lblStock);
            this.tabPage1.Controls.Add(this.lblPrecio);
            this.tabPage1.Controls.Add(this.lblCategoria);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblID);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(62, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(62, 121);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(62, 168);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(62, 220);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.AcceptsReturn = true;
            this.txtIDProducto.Location = new System.Drawing.Point(142, 20);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(173, 22);
            this.txtIDProducto.TabIndex = 5;
            this.txtIDProducto.TextChanged += new System.EventHandler(this.txtIDProducto_TextChanged);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(142, 62);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(252, 22);
            this.txtNombreProducto.TabIndex = 6;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(142, 162);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(173, 22);
            this.txtPrecioProducto.TabIndex = 8;
            this.txtPrecioProducto.TextChanged += new System.EventHandler(this.txtPrecioProducto_TextChanged);
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(142, 214);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(173, 22);
            this.txtStockProducto.TabIndex = 9;
            // 
            // cbCategoriaProducto
            // 
            this.cbCategoriaProducto.FormattingEnabled = true;
            this.cbCategoriaProducto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCategoriaProducto.Location = new System.Drawing.Point(142, 113);
            this.cbCategoriaProducto.Name = "cbCategoriaProducto";
            this.cbCategoriaProducto.Size = new System.Drawing.Size(173, 24);
            this.cbCategoriaProducto.TabIndex = 10;
            this.cbCategoriaProducto.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaProducto_SelectedIndexChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Categoria,
            this.Precio,
            this.CantidadStock});
            this.dgvProductos.Location = new System.Drawing.Point(6, 257);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(731, 171);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // CantidadStock
            // 
            this.CantidadStock.HeaderText = "Stock";
            this.CantidadStock.MinimumWidth = 6;
            this.CantidadStock.Name = "CantidadStock";
            this.CantidadStock.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 25000;
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // btnMostrarStock
            // 
            this.btnMostrarStock.Location = new System.Drawing.Point(527, 132);
            this.btnMostrarStock.Name = "btnMostrarStock";
            this.btnMostrarStock.Size = new System.Drawing.Size(135, 39);
            this.btnMostrarStock.TabIndex = 2;
            this.btnMostrarStock.Text = "Mostrar Stock";
            this.btnMostrarStock.UseVisualStyleBackColor = true;
            this.btnMostrarStock.Click += new System.EventHandler(this.btnMostrarStock_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(527, 26);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(135, 37);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(527, 78);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(135, 40);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(527, 188);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(135, 39);
            this.btnBuscarProducto.TabIndex = 12;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // tabControlInventario
            // 
            this.tabControlInventario.Controls.Add(this.tabPage1);
            this.tabControlInventario.Controls.Add(this.tabPage2);
            this.tabControlInventario.Controls.Add(this.tabPage3);
            this.tabControlInventario.Controls.Add(this.tabPage4);
            this.tabControlInventario.Location = new System.Drawing.Point(37, 12);
            this.tabControlInventario.Name = "tabControlInventario";
            this.tabControlInventario.SelectedIndex = 0;
            this.tabControlInventario.Size = new System.Drawing.Size(751, 475);
            this.tabControlInventario.TabIndex = 0;
            // 
            // cbClientesVentas
            // 
            this.cbClientesVentas.FormattingEnabled = true;
            this.cbClientesVentas.Location = new System.Drawing.Point(114, 48);
            this.cbClientesVentas.Name = "cbClientesVentas";
            this.cbClientesVentas.Size = new System.Drawing.Size(230, 24);
            this.cbClientesVentas.TabIndex = 0;
            // 
            // lblClienteVenta
            // 
            this.lblClienteVenta.AutoSize = true;
            this.lblClienteVenta.Location = new System.Drawing.Point(27, 56);
            this.lblClienteVenta.Name = "lblClienteVenta";
            this.lblClienteVenta.Size = new System.Drawing.Size(48, 16);
            this.lblClienteVenta.TabIndex = 1;
            this.lblClienteVenta.Text = "Cliente";
            this.lblClienteVenta.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblProductosVentas
            // 
            this.lblProductosVentas.AutoSize = true;
            this.lblProductosVentas.Location = new System.Drawing.Point(27, 103);
            this.lblProductosVentas.Name = "lblProductosVentas";
            this.lblProductosVentas.Size = new System.Drawing.Size(68, 16);
            this.lblProductosVentas.TabIndex = 2;
            this.lblProductosVentas.Text = "Productos";
            // 
            // cbProductosVentas
            // 
            this.cbProductosVentas.FormattingEnabled = true;
            this.cbProductosVentas.Location = new System.Drawing.Point(114, 95);
            this.cbProductosVentas.Name = "cbProductosVentas";
            this.cbProductosVentas.Size = new System.Drawing.Size(230, 24);
            this.cbProductosVentas.TabIndex = 3;
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(114, 144);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadVenta.TabIndex = 4;
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Location = new System.Drawing.Point(27, 150);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(61, 16);
            this.lblCantidadVentas.TabIndex = 5;
            this.lblCantidadVentas.Text = "Cantidad";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(495, 40);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(149, 32);
            this.btnRegistrarVenta.TabIndex = 6;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVentas,
            this.ClienteVentas,
            this.ProductosVentas,
            this.PrecioProductoVentas});
            this.dgvVentas.Location = new System.Drawing.Point(0, 277);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(550, 166);
            this.dgvVentas.TabIndex = 7;
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Location = new System.Drawing.Point(567, 159);
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.ReadOnly = true;
            this.txtIDVenta.Size = new System.Drawing.Size(100, 22);
            this.txtIDVenta.TabIndex = 8;
            // 
            // lblIDVenta
            // 
            this.lblIDVenta.AutoSize = true;
            this.lblIDVenta.Location = new System.Drawing.Point(492, 165);
            this.lblIDVenta.Name = "lblIDVenta";
            this.lblIDVenta.Size = new System.Drawing.Size(58, 16);
            this.lblIDVenta.TabIndex = 9;
            this.lblIDVenta.Text = "ID Venta";
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(495, 213);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(149, 32);
            this.btnEliminarVenta.TabIndex = 10;
            this.btnEliminarVenta.Text = "Eliminar Venta";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            // 
            // btnMostarVentas
            // 
            this.btnMostarVentas.Location = new System.Drawing.Point(495, 103);
            this.btnMostarVentas.Name = "btnMostarVentas";
            this.btnMostarVentas.Size = new System.Drawing.Size(149, 32);
            this.btnMostarVentas.TabIndex = 11;
            this.btnMostarVentas.Text = "Mostrar Ventas";
            this.btnMostarVentas.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProductoVenta
            // 
            this.btnAgregarProductoVenta.Location = new System.Drawing.Point(114, 211);
            this.btnAgregarProductoVenta.Name = "btnAgregarProductoVenta";
            this.btnAgregarProductoVenta.Size = new System.Drawing.Size(139, 34);
            this.btnAgregarProductoVenta.TabIndex = 12;
            this.btnAgregarProductoVenta.Text = "Agregar Producto";
            this.btnAgregarProductoVenta.UseVisualStyleBackColor = true;
            // 
            // IDVentas
            // 
            this.IDVentas.HeaderText = "ID";
            this.IDVentas.MinimumWidth = 6;
            this.IDVentas.Name = "IDVentas";
            this.IDVentas.Width = 125;
            // 
            // ClienteVentas
            // 
            this.ClienteVentas.HeaderText = "Cliente";
            this.ClienteVentas.MinimumWidth = 6;
            this.ClienteVentas.Name = "ClienteVentas";
            this.ClienteVentas.Width = 125;
            // 
            // ProductosVentas
            // 
            this.ProductosVentas.HeaderText = "Productos";
            this.ProductosVentas.MinimumWidth = 6;
            this.ProductosVentas.Name = "ProductosVentas";
            this.ProductosVentas.Width = 125;
            // 
            // PrecioProductoVentas
            // 
            this.PrecioProductoVentas.HeaderText = "Precio";
            this.PrecioProductoVentas.MinimumWidth = 6;
            this.PrecioProductoVentas.Name = "PrecioProductoVentas";
            this.PrecioProductoVentas.Width = 125;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(597, 324);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(112, 16);
            this.lblTotalVenta.TabIndex = 13;
            this.lblTotalVenta.Text = "Total de la Venta:";
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(600, 353);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(109, 22);
            this.txtTotalVenta.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.tabControlInventario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabControlInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label IDCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnMostrarStock;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadStock;
        private System.Windows.Forms.ComboBox cbCategoriaProducto;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TabControl tabControlInventario;
        private System.Windows.Forms.ComboBox cbClientesVentas;
        private System.Windows.Forms.Label lblClienteVenta;
        private System.Windows.Forms.Label lblProductosVentas;
        private System.Windows.Forms.ComboBox cbProductosVentas;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Label lblIDVenta;
        private System.Windows.Forms.TextBox txtIDVenta;
        private System.Windows.Forms.Button btnMostarVentas;
        private System.Windows.Forms.Button btnAgregarProductoVenta;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductosVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProductoVentas;
        private System.Windows.Forms.TextBox txtTotalVenta;
    }
}

