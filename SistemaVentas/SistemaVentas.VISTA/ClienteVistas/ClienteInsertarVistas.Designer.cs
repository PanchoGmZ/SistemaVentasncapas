namespace SistemaVentas.VISTA.ClienteVistas
{
    partial class ClienteInsertarVistas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIdPersona = new TextBox();
            label4 = new Label();
            txtTipoCliente = new TextBox();
            txtCodigoCliente = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnSelec = new Button();
            label5 = new Label();
            txtEstado = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(47, 55);
            label1.Name = "label1";
            label1.Size = new Size(104, 18);
            label1.TabIndex = 0;
            label1.Text = "IDPERSONA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(40, 91);
            label2.Name = "label2";
            label2.Size = new Size(117, 18);
            label2.TabIndex = 1;
            label2.Text = "TIPOCLIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(14, 127);
            label3.Name = "label3";
            label3.Size = new Size(145, 18);
            label3.TabIndex = 2;
            label3.Text = "CODIGOCLIENTE";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(167, 59);
            txtIdPersona.Margin = new Padding(3, 2, 3, 2);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(267, 23);
            txtIdPersona.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 196);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 4;
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(167, 95);
            txtTipoCliente.Margin = new Padding(3, 2, 3, 2);
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.Size = new Size(267, 23);
            txtTipoCliente.TabIndex = 5;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(167, 131);
            txtCodigoCliente.Margin = new Padding(3, 2, 3, 2);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(267, 23);
            txtCodigoCliente.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(179, 196);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 30);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(320, 196);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 30);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSelec
            // 
            btnSelec.BackColor = Color.Transparent;
            btnSelec.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelec.ForeColor = SystemColors.ActiveCaptionText;
            btnSelec.Location = new Point(437, 53);
            btnSelec.Margin = new Padding(3, 2, 3, 2);
            btnSelec.Name = "btnSelec";
            btnSelec.Size = new Size(137, 31);
            btnSelec.TabIndex = 9;
            btnSelec.Text = "Seleccionar";
            btnSelec.UseVisualStyleBackColor = false;
            btnSelec.Click += btnSelec_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(167, 9);
            label5.Name = "label5";
            label5.Size = new Size(264, 29);
            label5.TabIndex = 15;
            label5.Text = "AGREGAR CLIENTE";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(167, 165);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(267, 23);
            txtEstado.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(74, 161);
            label6.Name = "label6";
            label6.Size = new Size(73, 18);
            label6.TabIndex = 23;
            label6.Text = "ESTADO";
            // 
            // ClienteInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(586, 241);
            Controls.Add(txtEstado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSelec);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCodigoCliente);
            Controls.Add(txtTipoCliente);
            Controls.Add(label4);
            Controls.Add(txtIdPersona);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClienteInsertarVistas";
            Text = "ClienteInsertarVistas";
            Load += ClienteInsertarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdPersona;
        private Label label4;
        private TextBox txtTipoCliente;
        private TextBox txtCodigoCliente;
        private Button button1;
        private Button button2;
        private Button btnSelec;
        private Label label5;
        private TextBox txtEstado;
        private Label label6;
    }
}