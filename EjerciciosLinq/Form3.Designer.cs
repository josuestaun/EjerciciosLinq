namespace EjerciciosLinq
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio1Al7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicios7Al9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_TelDigitos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio1Al7ToolStripMenuItem,
            this.ejercicios7Al9ToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ejercicio1Al7ToolStripMenuItem
            // 
            this.ejercicio1Al7ToolStripMenuItem.Name = "ejercicio1Al7ToolStripMenuItem";
            this.ejercicio1Al7ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ejercicio1Al7ToolStripMenuItem.Text = "Ejercicio 1 al 6";
            this.ejercicio1Al7ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio1Al7ToolStripMenuItem_Click);
            // 
            // ejercicios7Al9ToolStripMenuItem
            // 
            this.ejercicios7Al9ToolStripMenuItem.Name = "ejercicios7Al9ToolStripMenuItem";
            this.ejercicios7Al9ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ejercicios7Al9ToolStripMenuItem.Text = "Ejercicios 7 al 9";
            this.ejercicios7Al9ToolStripMenuItem.Click += new System.EventHandler(this.ejercicios7Al9ToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // btn_TelDigitos
            // 
            this.btn_TelDigitos.Location = new System.Drawing.Point(21, 36);
            this.btn_TelDigitos.Name = "btn_TelDigitos";
            this.btn_TelDigitos.Size = new System.Drawing.Size(114, 48);
            this.btn_TelDigitos.TabIndex = 1;
            this.btn_TelDigitos.Text = "Personas con telefono de mas de 9 digitos";
            this.btn_TelDigitos.UseVisualStyleBackColor = true;
            this.btn_TelDigitos.Click += new System.EventHandler(this.btn_TelDigitos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 100);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TelDigitos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio1Al7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicios7Al9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btn_TelDigitos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}