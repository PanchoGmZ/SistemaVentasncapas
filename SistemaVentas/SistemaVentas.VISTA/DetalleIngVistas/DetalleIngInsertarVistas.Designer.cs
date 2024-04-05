namespace SistemaVentas.VISTA.DetalleIngVistas
{
    partial class DetalleIngInsertarVistas
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
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnProd = new Button();
            button2 = new Button();
            button1 = new Button();
            txtPrecioCosto = new TextBox();
            txtCantidad = new TextBox();
            txtIngreso = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtProducto = new TextBox();
            label6 = new Label();
            txtSubTotal = new TextBox();
            txtPrecioVenta = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnIng = new Button();
            txtEstado = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(151, 18);
            label5.Name = "label5";
            label5.Size = new Size(416, 37);
            label5.TabIndex = 24;
            label5.Text = "AGREGAR DETALLE INGRESO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(214, 152);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // btnProd
            // 
            btnProd.BackColor = Color.FromArgb(0, 192, 192);
            btnProd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnProd.Location = new Point(537, 105);
            btnProd.Name = "btnProd";
            btnProd.Size = new Size(144, 38);
            btnProd.TabIndex = 22;
            btnProd.Text = "SELECCIONAR";
            btnProd.UseVisualStyleBackColor = false;
            btnProd.Click += btnProd_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button2.Location = new Point(384, 403);
            button2.Name = "button2";
            button2.Size = new Size(120, 35);
            button2.TabIndex = 21;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button1.Location = new Point(229, 403);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 20;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(214, 240);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(299, 27);
            txtPrecioCosto.TabIndex = 19;
            txtPrecioCosto.UseSystemPasswordChar = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(214, 196);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(299, 27);
            txtCantidad.TabIndex = 18;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(214, 64);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(299, 27);
            txtIngreso.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(185, 20);
            label4.TabIndex = 16;
            label4.Text = "FECHA DE VENCIMIENTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 247);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 15;
            label3.Text = "PRECIO COSTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 202);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 14;
            label2.Text = "CANTIDAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 67);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 13;
            label1.Text = "IDINGRESO";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(214, 108);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(299, 27);
            txtProducto.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(92, 112);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 25;
            label6.Text = "IDPRODUCTO";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(214, 328);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(299, 27);
            txtSubTotal.TabIndex = 30;
            txtSubTotal.UseSystemPasswordChar = true;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(214, 284);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(299, 27);
            txtPrecioVenta.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLight;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(114, 337);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 28;
            label7.Text = "SUBTOTAL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLight;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(83, 292);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 27;
            label8.Text = "PRECIO VENTA";
            // 
            // btnIng
            // 
            btnIng.BackColor = Color.FromArgb(0, 192, 192);
            btnIng.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnIng.Location = new Point(537, 58);
            btnIng.Name = "btnIng";
            btnIng.Size = new Size(144, 41);
            btnIng.TabIndex = 31;
            btnIng.Text = "SELECCIONAR";
            btnIng.UseVisualStyleBackColor = false;
            btnIng.Click += btnIng_Click;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(214, 370);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(299, 27);
            txtEstado.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(121, 371);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 32;
            label9.Text = "ESTADO";
            // 
            // DetalleIngInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(728, 450);
            Controls.Add(txtEstado);
            Controls.Add(label9);
            Controls.Add(btnIng);
            Controls.Add(txtSubTotal);
            Controls.Add(txtPrecioVenta);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtProducto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnProd);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecioCosto);
            Controls.Add(txtCantidad);
            Controls.Add(txtIngreso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetalleIngInsertarVistas";
            Text = "DetalleIngInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button btnProd;
        private Button button2;
        private Button button1;
        private TextBox txtPrecioCosto;
        private TextBox txtCantidad;
        private TextBox txtIngreso;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtProducto;
        private Label label6;
        private TextBox txtSubTotal;
        private TextBox txtPrecioVenta;
        private Label label7;
        private Label label8;
        private Button btnIng;
        private TextBox txtEstado;
        private Label label9;
    }
}