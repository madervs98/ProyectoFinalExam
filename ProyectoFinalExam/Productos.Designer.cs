namespace ProyectoFinalExam
{
    partial class Productos
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tb_buscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CantPro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_CodPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_DescPro = new System.Windows.Forms.RichTextBox();
            this.tb_CodCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_NomCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.dgv_DetallesProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.tbn_actualizar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetallesProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(331, 56);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 32;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // tb_buscador
            // 
            this.tb_buscador.Location = new System.Drawing.Point(21, 58);
            this.tb_buscador.Name = "tb_buscador";
            this.tb_buscador.Size = new System.Drawing.Size(300, 20);
            this.tb_buscador.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // tb_Precio
            // 
            this.tb_Precio.Location = new System.Drawing.Point(492, 217);
            this.tb_Precio.Name = "tb_Precio";
            this.tb_Precio.Size = new System.Drawing.Size(141, 20);
            this.tb_Precio.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Precio";
            // 
            // tb_CantPro
            // 
            this.tb_CantPro.Location = new System.Drawing.Point(492, 169);
            this.tb_CantPro.Name = "tb_CantPro";
            this.tb_CantPro.Size = new System.Drawing.Size(141, 20);
            this.tb_CantPro.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Descripción";
            // 
            // tb_CodPro
            // 
            this.tb_CodPro.Location = new System.Drawing.Point(22, 179);
            this.tb_CodPro.Name = "tb_CodPro";
            this.tb_CodPro.Size = new System.Drawing.Size(141, 20);
            this.tb_CodPro.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Código de Producto";
            // 
            // tb_DescPro
            // 
            this.tb_DescPro.Location = new System.Drawing.Point(177, 179);
            this.tb_DescPro.Name = "tb_DescPro";
            this.tb_DescPro.Size = new System.Drawing.Size(308, 58);
            this.tb_DescPro.TabIndex = 41;
            this.tb_DescPro.Text = "";
            // 
            // tb_CodCli
            // 
            this.tb_CodCli.Location = new System.Drawing.Point(22, 113);
            this.tb_CodCli.Name = "tb_CodCli";
            this.tb_CodCli.Size = new System.Drawing.Size(141, 20);
            this.tb_CodCli.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Código de Cliente";
            // 
            // tb_NomCli
            // 
            this.tb_NomCli.Location = new System.Drawing.Point(180, 113);
            this.tb_NomCli.Name = "tb_NomCli";
            this.tb_NomCli.Size = new System.Drawing.Size(141, 20);
            this.tb_NomCli.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nombre del Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Fecha";
            // 
            // dt_fecha
            // 
            this.dt_fecha.Location = new System.Drawing.Point(433, 110);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(200, 20);
            this.dt_fecha.TabIndex = 46;
            // 
            // dgv_DetallesProductos
            // 
            this.dgv_DetallesProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetallesProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_DetallesProductos.Location = new System.Drawing.Point(22, 252);
            this.dgv_DetallesProductos.Name = "dgv_DetallesProductos";
            this.dgv_DetallesProductos.Size = new System.Drawing.Size(611, 150);
            this.dgv_DetallesProductos.TabIndex = 48;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.Width = 153;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.Width = 153;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(639, 360);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 51;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // tbn_actualizar
            // 
            this.tbn_actualizar.Location = new System.Drawing.Point(639, 322);
            this.tbn_actualizar.Name = "tbn_actualizar";
            this.tbn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.tbn_actualizar.TabIndex = 50;
            this.tbn_actualizar.Text = "Actualizar";
            this.tbn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(639, 282);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 49;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(410, 56);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 52;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 453);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.tbn_actualizar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_DetallesProductos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.tb_NomCli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_CodCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_DescPro);
            this.Controls.Add(this.tb_Precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_CantPro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_CodPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.tb_buscador);
            this.Controls.Add(this.label1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetallesProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tb_buscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CantPro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_CodPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tb_DescPro;
        private System.Windows.Forms.TextBox tb_CodCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_NomCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.DataGridView dgv_DetallesProductos;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button tbn_actualizar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_limpiar;
    }
}