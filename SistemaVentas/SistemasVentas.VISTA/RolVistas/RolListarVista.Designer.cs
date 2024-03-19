namespace SistemasVentas.VISTA.RolVistas
{
    partial class RolListarVista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.editar_btn = new System.Windows.Forms.Button();
            this.Agregar_btn = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(535, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Location = new System.Drawing.Point(289, 348);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(114, 29);
            this.eliminar_btn.TabIndex = 8;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = true;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
            // 
            // editar_btn
            // 
            this.editar_btn.Location = new System.Drawing.Point(156, 348);
            this.editar_btn.Name = "editar_btn";
            this.editar_btn.Size = new System.Drawing.Size(114, 29);
            this.editar_btn.TabIndex = 7;
            this.editar_btn.Text = "Editar";
            this.editar_btn.UseVisualStyleBackColor = true;
            this.editar_btn.Click += new System.EventHandler(this.editar_btn_Click);
            // 
            // Agregar_btn
            // 
            this.Agregar_btn.Location = new System.Drawing.Point(23, 348);
            this.Agregar_btn.Name = "Agregar_btn";
            this.Agregar_btn.Size = new System.Drawing.Size(114, 29);
            this.Agregar_btn.TabIndex = 6;
            this.Agregar_btn.Text = "Agregar";
            this.Agregar_btn.UseVisualStyleBackColor = true;
            this.Agregar_btn.Click += new System.EventHandler(this.Agregar_btn_Click);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(425, 348);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(110, 29);
            this.btn_Seleccionar.TabIndex = 5;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // RolListarVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 397);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.editar_btn);
            this.Controls.Add(this.Agregar_btn);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RolListarVista";
            this.Text = "RolListarVista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button eliminar_btn;
        private Button editar_btn;
        private Button Agregar_btn;
        private Button btn_Seleccionar;
    }
}