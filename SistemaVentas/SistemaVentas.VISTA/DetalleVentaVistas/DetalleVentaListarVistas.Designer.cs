namespace SistemaVentas.VISTA.DetalleVentaVistas
{
    partial class DetalleVentaListarVistas
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
            btnSelec = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 426);
            dataGridView1.TabIndex = 0;
            // 
            // btnSelec
            // 
            btnSelec.BackColor = Color.FromArgb(0, 192, 192);
            btnSelec.DialogResult = DialogResult.OK;
            btnSelec.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelec.Location = new Point(744, 528);
            btnSelec.Name = "btnSelec";
            btnSelec.Size = new Size(140, 34);
            btnSelec.TabIndex = 8;
            btnSelec.Text = "SELECCIONAR";
            btnSelec.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(0, 192, 192);
            btnEliminar.DialogResult = DialogResult.OK;
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(506, 528);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 192, 192);
            btnEditar.DialogResult = DialogResult.OK;
            btnEditar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(286, 528);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 34);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 192, 192);
            btnAgregar.DialogResult = DialogResult.OK;
            btnAgregar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(54, 528);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 9);
            label1.Name = "label1";
            label1.Size = new Size(389, 37);
            label1.TabIndex = 15;
            label1.Text = "LISTA DETALLE DE VENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 487);
            label2.Name = "label2";
            label2.Size = new Size(398, 28);
            label2.TabIndex = 16;
            label2.Text = "ELIGE LA OCPCION QUE DESEE REALIZAR";
            // 
            // DetalleVentaListarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(965, 578);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSelec);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "DetalleVentaListarVistas";
            Text = "DetalleVentaListarVistas";
            Load += DetalleVentaListarVistas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSelec;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
    }
}