namespace Tienda_Naturista
{
    partial class Gestion_Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxProductoInventario = new System.Windows.Forms.ComboBox();
            this.BtnConsultarInventario = new System.Windows.Forms.Button();
            this.BtnMostrarInventario = new System.Windows.Forms.Button();
            this.dtgInventario = new System.Windows.Forms.DataGridView();
            this.btnExpoExcel = new System.Windows.Forms.Button();
            this.btnExpoPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(408, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(211, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // CbxProductoInventario
            // 
            this.CbxProductoInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxProductoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProductoInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.CbxProductoInventario.FormattingEnabled = true;
            this.CbxProductoInventario.Location = new System.Drawing.Point(327, 86);
            this.CbxProductoInventario.Name = "CbxProductoInventario";
            this.CbxProductoInventario.Size = new System.Drawing.Size(299, 24);
            this.CbxProductoInventario.TabIndex = 2;
            // 
            // BtnConsultarInventario
            // 
            this.BtnConsultarInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.BtnConsultarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarInventario.ForeColor = System.Drawing.Color.White;
            this.BtnConsultarInventario.Location = new System.Drawing.Point(356, 130);
            this.BtnConsultarInventario.Name = "BtnConsultarInventario";
            this.BtnConsultarInventario.Size = new System.Drawing.Size(91, 34);
            this.BtnConsultarInventario.TabIndex = 3;
            this.BtnConsultarInventario.Text = "Consultar";
            this.BtnConsultarInventario.UseVisualStyleBackColor = false;
            this.BtnConsultarInventario.Click += new System.EventHandler(this.BtnConsultarInventario_Click);
            // 
            // BtnMostrarInventario
            // 
            this.BtnMostrarInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.BtnMostrarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarInventario.ForeColor = System.Drawing.Color.White;
            this.BtnMostrarInventario.Location = new System.Drawing.Point(483, 130);
            this.BtnMostrarInventario.Name = "BtnMostrarInventario";
            this.BtnMostrarInventario.Size = new System.Drawing.Size(129, 34);
            this.BtnMostrarInventario.TabIndex = 4;
            this.BtnMostrarInventario.Text = "Mostrar Todo";
            this.BtnMostrarInventario.UseVisualStyleBackColor = false;
            this.BtnMostrarInventario.Click += new System.EventHandler(this.BtnMostrarInventario_Click);
            // 
            // dtgInventario
            // 
            this.dtgInventario.AllowUserToAddRows = false;
            this.dtgInventario.AllowUserToDeleteRows = false;
            this.dtgInventario.AllowUserToResizeColumns = false;
            this.dtgInventario.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.dtgInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInventario.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgInventario.EnableHeadersVisualStyles = false;
            this.dtgInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.dtgInventario.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtgInventario.Location = new System.Drawing.Point(60, 170);
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.ReadOnly = true;
            this.dtgInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgInventario.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgInventario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgInventario.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dtgInventario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgInventario.ShowRowErrors = false;
            this.dtgInventario.Size = new System.Drawing.Size(804, 255);
            this.dtgInventario.TabIndex = 5;
            // 
            // btnExpoExcel
            // 
            this.btnExpoExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.btnExpoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpoExcel.ForeColor = System.Drawing.Color.White;
            this.btnExpoExcel.Location = new System.Drawing.Point(704, 35);
            this.btnExpoExcel.Name = "btnExpoExcel";
            this.btnExpoExcel.Size = new System.Drawing.Size(129, 34);
            this.btnExpoExcel.TabIndex = 6;
            this.btnExpoExcel.Text = "Exportar Excel";
            this.btnExpoExcel.UseVisualStyleBackColor = false;
            this.btnExpoExcel.Click += new System.EventHandler(this.btnExpoExcel_Click);
            // 
            // btnExpoPDF
            // 
            this.btnExpoPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.btnExpoPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpoPDF.ForeColor = System.Drawing.Color.White;
            this.btnExpoPDF.Location = new System.Drawing.Point(704, 75);
            this.btnExpoPDF.Name = "btnExpoPDF";
            this.btnExpoPDF.Size = new System.Drawing.Size(129, 34);
            this.btnExpoPDF.TabIndex = 7;
            this.btnExpoPDF.Text = "Exportar PDF";
            this.btnExpoPDF.UseVisualStyleBackColor = false;
            this.btnExpoPDF.Click += new System.EventHandler(this.btnExpoPDF_Click);
            // 
            // Gestion_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(900, 430);
            this.Controls.Add(this.btnExpoPDF);
            this.Controls.Add(this.btnExpoExcel);
            this.Controls.Add(this.dtgInventario);
            this.Controls.Add(this.BtnMostrarInventario);
            this.Controls.Add(this.BtnConsultarInventario);
            this.Controls.Add(this.CbxProductoInventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Inventario";
            this.Text = "Gestion_Inventario";
            this.Load += new System.EventHandler(this.Gestion_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxProductoInventario;
        private System.Windows.Forms.Button BtnConsultarInventario;
        private System.Windows.Forms.Button BtnMostrarInventario;
        private System.Windows.Forms.DataGridView dtgInventario;
        private System.Windows.Forms.Button btnExpoExcel;
        private System.Windows.Forms.Button btnExpoPDF;
    }
}