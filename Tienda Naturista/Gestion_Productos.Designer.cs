namespace Tienda_Naturista
{
    partial class Gestion_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.BtnMostrarTodo = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.CbxProductos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TxtCantidadModificar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnConsultarModifi = new System.Windows.Forms.Button();
            this.CbxProductoModificar = new System.Windows.Forms.ComboBox();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.TxtValorModificar = new System.Windows.Forms.TextBox();
            this.TxtDescripcionModificar = new System.Windows.Forms.TextBox();
            this.TxtCodigoModificar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CbxEliminar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Productos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(123, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 365);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.tabPage1.Controls.Add(this.BtnLimpiar);
            this.tabPage1.Controls.Add(this.BtnGuardar);
            this.tabPage1.Controls.Add(this.TxtCantidad);
            this.tabPage1.Controls.Add(this.TxtValor);
            this.tabPage1.Controls.Add(this.TxtDescripcion);
            this.tabPage1.Controls.Add(this.TxtCodigo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Producto";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(366, 249);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(103, 38);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(223, 249);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(101, 38);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.TxtCantidad.Location = new System.Drawing.Point(243, 190);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(262, 27);
            this.TxtCantidad.TabIndex = 7;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged);
            // 
            // TxtValor
            // 
            this.TxtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.TxtValor.Location = new System.Drawing.Point(243, 137);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(262, 27);
            this.TxtValor.TabIndex = 6;
            this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.TxtDescripcion.Location = new System.Drawing.Point(243, 84);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(262, 27);
            this.TxtDescripcion.TabIndex = 5;
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.TxtCodigo.Location = new System.Drawing.Point(243, 30);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(262, 27);
            this.TxtCodigo.TabIndex = 4;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(126, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(126, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(126, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(126, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.tabPage2.Controls.Add(this.DgvProductos);
            this.tabPage2.Controls.Add(this.BtnMostrarTodo);
            this.tabPage2.Controls.Add(this.BtnConsultar);
            this.tabPage2.Controls.Add(this.CbxProductos);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar producto";
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.AllowUserToResizeColumns = false;
            this.DgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.DgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProductos.EnableHeadersVisualStyles = false;
            this.DgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.DgvProductos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DgvProductos.Location = new System.Drawing.Point(0, 136);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvProductos.ShowRowErrors = false;
            this.DgvProductos.Size = new System.Drawing.Size(679, 207);
            this.DgvProductos.TabIndex = 4;
            // 
            // BtnMostrarTodo
            // 
            this.BtnMostrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.BtnMostrarTodo.ForeColor = System.Drawing.Color.White;
            this.BtnMostrarTodo.Location = new System.Drawing.Point(341, 97);
            this.BtnMostrarTodo.Name = "BtnMostrarTodo";
            this.BtnMostrarTodo.Size = new System.Drawing.Size(151, 33);
            this.BtnMostrarTodo.TabIndex = 3;
            this.BtnMostrarTodo.Text = "Mostrar Todo";
            this.BtnMostrarTodo.UseVisualStyleBackColor = false;
            this.BtnMostrarTodo.Click += new System.EventHandler(this.BtnMostrarTodo_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.BtnConsultar.ForeColor = System.Drawing.Color.White;
            this.BtnConsultar.Location = new System.Drawing.Point(198, 97);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(105, 33);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // CbxProductos
            // 
            this.CbxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxProductos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.CbxProductos.FormattingEnabled = true;
            this.CbxProductos.Location = new System.Drawing.Point(178, 50);
            this.CbxProductos.Name = "CbxProductos";
            this.CbxProductos.Size = new System.Drawing.Size(353, 24);
            this.CbxProductos.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(71, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.tabPage3.Controls.Add(this.TxtCantidadModificar);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.BtnConsultarModifi);
            this.tabPage3.Controls.Add(this.CbxProductoModificar);
            this.tabPage3.Controls.Add(this.BtnGuardarCambios);
            this.tabPage3.Controls.Add(this.TxtValorModificar);
            this.tabPage3.Controls.Add(this.TxtDescripcionModificar);
            this.tabPage3.Controls.Add(this.TxtCodigoModificar);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(679, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar Producto";
            // 
            // TxtCantidadModificar
            // 
            this.TxtCantidadModificar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.TxtCantidadModificar.Location = new System.Drawing.Point(400, 219);
            this.TxtCantidadModificar.Name = "TxtCantidadModificar";
            this.TxtCantidadModificar.Size = new System.Drawing.Size(262, 23);
            this.TxtCantidadModificar.TabIndex = 33;
            this.TxtCantidadModificar.TextChanged += new System.EventHandler(this.TxtCantidadModificar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(297, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cantidad";
            // 
            // BtnConsultarModifi
            // 
            this.BtnConsultarModifi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.BtnConsultarModifi.ForeColor = System.Drawing.Color.White;
            this.BtnConsultarModifi.Location = new System.Drawing.Point(72, 131);
            this.BtnConsultarModifi.Name = "BtnConsultarModifi";
            this.BtnConsultarModifi.Size = new System.Drawing.Size(111, 33);
            this.BtnConsultarModifi.TabIndex = 31;
            this.BtnConsultarModifi.Text = "Consultar";
            this.BtnConsultarModifi.UseVisualStyleBackColor = false;
            this.BtnConsultarModifi.Click += new System.EventHandler(this.BtnConsultarModifi_Click);
            // 
            // CbxProductoModificar
            // 
            this.CbxProductoModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxProductoModificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProductoModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.CbxProductoModificar.FormattingEnabled = true;
            this.CbxProductoModificar.Location = new System.Drawing.Point(9, 87);
            this.CbxProductoModificar.Name = "CbxProductoModificar";
            this.CbxProductoModificar.Size = new System.Drawing.Size(262, 22);
            this.CbxProductoModificar.TabIndex = 30;
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.BtnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCambios.Location = new System.Drawing.Point(59, 194);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(158, 34);
            this.BtnGuardarCambios.TabIndex = 29;
            this.BtnGuardarCambios.Text = "Guardar Cambios";
            this.BtnGuardarCambios.UseVisualStyleBackColor = false;
            this.BtnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            // 
            // TxtValorModificar
            // 
            this.TxtValorModificar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.TxtValorModificar.Location = new System.Drawing.Point(400, 164);
            this.TxtValorModificar.Name = "TxtValorModificar";
            this.TxtValorModificar.Size = new System.Drawing.Size(262, 23);
            this.TxtValorModificar.TabIndex = 27;
            this.TxtValorModificar.TextChanged += new System.EventHandler(this.TxtValorModificar_TextChanged);
            // 
            // TxtDescripcionModificar
            // 
            this.TxtDescripcionModificar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.TxtDescripcionModificar.Location = new System.Drawing.Point(400, 111);
            this.TxtDescripcionModificar.Name = "TxtDescripcionModificar";
            this.TxtDescripcionModificar.Size = new System.Drawing.Size(262, 23);
            this.TxtDescripcionModificar.TabIndex = 26;
            this.TxtDescripcionModificar.TextChanged += new System.EventHandler(this.TxtDescripcionModificar_TextChanged);
            // 
            // TxtCodigoModificar
            // 
            this.TxtCodigoModificar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.TxtCodigoModificar.Location = new System.Drawing.Point(400, 58);
            this.TxtCodigoModificar.Name = "TxtCodigoModificar";
            this.TxtCodigoModificar.ReadOnly = true;
            this.TxtCodigoModificar.Size = new System.Drawing.Size(262, 23);
            this.TxtCodigoModificar.TabIndex = 25;
            this.TxtCodigoModificar.TextChanged += new System.EventHandler(this.TxtCodigoModificar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label10.Location = new System.Drawing.Point(292, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Valor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label11.Location = new System.Drawing.Point(292, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Descripcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label12.Location = new System.Drawing.Point(292, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Codigo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label13.Location = new System.Drawing.Point(86, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "Producto";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.tabPage4.Controls.Add(this.BtnEliminar);
            this.tabPage4.Controls.Add(this.CbxEliminar);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(679, 339);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Producto";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(299, 180);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(103, 35);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CbxEliminar
            // 
            this.CbxEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.CbxEliminar.FormattingEnabled = true;
            this.CbxEliminar.Location = new System.Drawing.Point(206, 121);
            this.CbxEliminar.Name = "CbxEliminar";
            this.CbxEliminar.Size = new System.Drawing.Size(345, 22);
            this.CbxEliminar.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(105, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Producto";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Gestion_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(900, 430);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Productos";
            this.Text = "Gestion_Productos";
            this.Load += new System.EventHandler(this.Gestion_Productos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.TextBox TxtValorModificar;
        private System.Windows.Forms.TextBox TxtDescripcionModificar;
        private System.Windows.Forms.TextBox TxtCodigoModificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Button BtnMostrarTodo;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ComboBox CbxProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnConsultarModifi;
        private System.Windows.Forms.ComboBox CbxProductoModificar;
        private System.Windows.Forms.TextBox TxtCantidadModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ComboBox CbxEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}