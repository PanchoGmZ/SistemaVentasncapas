namespace SistemaVentas.VISTA.VentaVistas
{
    partial class VentaEditarVistas
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
            txtEstado = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSelecVendedor = new Button();
            btnSelecliente = new Button();
            button2 = new Button();
            button1 = new Button();
            txtTotal = new TextBox();
            txtIdVendedor = new TextBox();
            txtIdCliente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(121, 188);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(259, 23);
            txtEstado.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 121);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(259, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // btnSelecVendedor
            // 
            btnSelecVendedor.BackColor = Color.Transparent;
            btnSelecVendedor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecVendedor.Location = new Point(402, 85);
            btnSelecVendedor.Margin = new Padding(3, 2, 3, 2);
            btnSelecVendedor.Name = "btnSelecVendedor";
            btnSelecVendedor.Size = new Size(124, 25);
            btnSelecVendedor.TabIndex = 25;
            btnSelecVendedor.Text = "SELECCIONAR";
            btnSelecVendedor.UseVisualStyleBackColor = false;
            btnSelecVendedor.Click += btnSelecVendedor_Click;
            // 
            // btnSelecliente
            // 
            btnSelecliente.BackColor = Color.Transparent;
            btnSelecliente.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecliente.Location = new Point(402, 50);
            btnSelecliente.Margin = new Padding(3, 2, 3, 2);
            btnSelecliente.Name = "btnSelecliente";
            btnSelecliente.Size = new Size(122, 25);
            btnSelecliente.TabIndex = 24;
            btnSelecliente.Text = "SELECCIONAR";
            btnSelecliente.UseVisualStyleBackColor = false;
            btnSelecliente.Click += btnSelecliente_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(260, 225);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(105, 26);
            button2.TabIndex = 23;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(121, 225);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(100, 26);
            button1.TabIndex = 22;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(121, 156);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(259, 23);
            txtTotal.TabIndex = 21;
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Location = new Point(121, 88);
            txtIdVendedor.Margin = new Padding(3, 2, 3, 2);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.Size = new Size(259, 23);
            txtIdVendedor.TabIndex = 20;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(121, 55);
            txtIdCliente.Margin = new Padding(3, 2, 3, 2);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(259, 23);
            txtIdCliente.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 188);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 33;
            label5.Text = "ESTADO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 156);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 32;
            label4.Text = "TOTAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(60, 122);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 31;
            label3.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 30;
            label2.Text = "IDVENDEDOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 55);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 29;
            label1.Text = "IDCLIENTE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(149, 14);
            label6.Name = "label6";
            label6.Size = new Size(178, 30);
            label6.TabIndex = 34;
            label6.Text = "EDITAR VENTA";
            // 
            // VentaEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(542, 266);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEstado);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSelecVendedor);
            Controls.Add(btnSelecliente);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(txtIdVendedor);
            Controls.Add(txtIdCliente);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentaEditarVistas";
            Text = "VentaEditarVistas";
            Load += VentaEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEstado;
        private DateTimePicker dateTimePicker1;
        private Button btnSelecVendedor;
        private Button btnSelecliente;
        private Button button2;
        private Button button1;
        private TextBox txtTotal;
        private TextBox txtIdVendedor;
        private TextBox txtIdCliente;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}