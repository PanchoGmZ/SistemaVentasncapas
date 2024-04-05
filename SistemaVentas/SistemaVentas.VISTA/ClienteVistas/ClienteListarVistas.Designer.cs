namespace SistemaVentas.VISTA.ClienteVistas
{
    partial class ClienteListarVistas
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
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSelec = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 54);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(612, 320);
            dataGridView1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.DialogResult = DialogResult.OK;
            btnAgregar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(42, 406);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 26);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.DialogResult = DialogResult.OK;
            btnEditar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(190, 406);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 26);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.DialogResult = DialogResult.OK;
            btnEliminar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(321, 406);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 26);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSelec
            // 
            btnSelec.BackColor = Color.Transparent;
            btnSelec.DialogResult = DialogResult.OK;
            btnSelec.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelec.Location = new Point(466, 406);
            btnSelec.Margin = new Padding(3, 2, 3, 2);
            btnSelec.Name = "btnSelec";
            btnSelec.Size = new Size(123, 26);
            btnSelec.TabIndex = 4;
            btnSelec.Text = "SELECCIONAR";
            btnSelec.UseVisualStyleBackColor = false;
            btnSelec.Click += btnSelec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 14);
            label1.Name = "label1";
            label1.Size = new Size(239, 29);
            label1.TabIndex = 14;
            label1.Text = "LISTA  CLIENTES";
            // 
            // ClienteListarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(633, 441);
            Controls.Add(label1);
            Controls.Add(btnSelec);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClienteListarVistas";
            Text = "ClienteListarVistas";
            Load += ClienteListarVistas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSelec;
        private Label label1;
    }
}