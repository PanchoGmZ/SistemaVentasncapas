namespace SistemaVentas.VISTA.ClienteVistas
{
    partial class ClienteEditarVistas
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            btnGuardar = new Button();
            btnCancel = new Button();
            btnSelec = new Button();
            label4 = new Label();
            txtEstado = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 65);
            label1.Name = "label1";
            label1.Size = new Size(76, 13);
            label1.TabIndex = 0;
            label1.Text = "IDPERSONA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 64);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 99);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 100);
            label2.Name = "label2";
            label2.Size = new Size(88, 13);
            label2.TabIndex = 2;
            label2.Text = "TIPO CLIENTE";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 138);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 139);
            label3.Name = "label3";
            label3.Size = new Size(110, 13);
            label3.TabIndex = 4;
            label3.Text = "CODIGO CLIENTE";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(142, 196);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 26);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(280, 196);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 26);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSelec
            // 
            btnSelec.BackColor = Color.Transparent;
            btnSelec.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelec.Location = new Point(419, 61);
            btnSelec.Margin = new Padding(3, 2, 3, 2);
            btnSelec.Name = "btnSelec";
            btnSelec.Size = new Size(123, 25);
            btnSelec.TabIndex = 8;
            btnSelec.Text = "SELECCIONAR";
            btnSelec.UseVisualStyleBackColor = false;
            btnSelec.Click += btnSelec_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(142, 9);
            label4.Name = "label4";
            label4.Size = new Size(237, 29);
            label4.TabIndex = 15;
            label4.Text = "EDITAR CLIENTE";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(149, 172);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(250, 23);
            txtEstado.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(78, 172);
            label5.Name = "label5";
            label5.Size = new Size(54, 13);
            label5.TabIndex = 23;
            label5.Text = "ESTADO";
            // 
            // ClienteEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(556, 232);
            Controls.Add(txtEstado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSelec);
            Controls.Add(btnCancel);
            Controls.Add(btnGuardar);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClienteEditarVistas";
            Text = "ClienteEditarVistas";
            Load += ClienteEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button btnGuardar;
        private Button btnCancel;
        private Button btnSelec;
        private Label label4;
        private TextBox txtEstado;
        private Label label5;
    }
}