namespace EjerciciosLinq
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_BuscarPersona = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.btn_localidad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_identificador = new System.Windows.Forms.TextBox();
            this.btn_identificador = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IdentificadorMax = new System.Windows.Forms.TextBox();
            this.btn_identificadorMax = new System.Windows.Forms.Button();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.btn_Edad = new System.Windows.Forms.Button();
            this.dataGrid3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicios7Al10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio10Y11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comienzo de nombre";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(210, 11);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // btn_BuscarPersona
            // 
            this.btn_BuscarPersona.Location = new System.Drawing.Point(60, 51);
            this.btn_BuscarPersona.Name = "btn_BuscarPersona";
            this.btn_BuscarPersona.Size = new System.Drawing.Size(143, 43);
            this.btn_BuscarPersona.TabIndex = 2;
            this.btn_BuscarPersona.Text = "Personas que nombre comience por...";
            this.btn_BuscarPersona.UseVisualStyleBackColor = true;
            this.btn_BuscarPersona.Click += new System.EventHandler(this.btn_BuscarPersona_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(339, 11);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(401, 83);
            this.dataGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Localidad";
            // 
            // txt_localidad
            // 
            this.txt_localidad.Location = new System.Drawing.Point(146, 151);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(100, 20);
            this.txt_localidad.TabIndex = 5;
            // 
            // btn_localidad
            // 
            this.btn_localidad.Location = new System.Drawing.Point(60, 184);
            this.btn_localidad.Name = "btn_localidad";
            this.btn_localidad.Size = new System.Drawing.Size(143, 25);
            this.btn_localidad.TabIndex = 6;
            this.btn_localidad.Text = "Hay personas de localidad";
            this.btn_localidad.UseVisualStyleBackColor = true;
            this.btn_localidad.Click += new System.EventHandler(this.btn_localidad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Identificador";
            // 
            // txt_identificador
            // 
            this.txt_identificador.Location = new System.Drawing.Point(474, 157);
            this.txt_identificador.Name = "txt_identificador";
            this.txt_identificador.Size = new System.Drawing.Size(100, 20);
            this.txt_identificador.TabIndex = 8;
            // 
            // btn_identificador
            // 
            this.btn_identificador.Location = new System.Drawing.Point(359, 185);
            this.btn_identificador.Name = "btn_identificador";
            this.btn_identificador.Size = new System.Drawing.Size(145, 23);
            this.btn_identificador.TabIndex = 9;
            this.btn_identificador.Text = "Persona por identificador";
            this.btn_identificador.UseVisualStyleBackColor = true;
            this.btn_identificador.Click += new System.EventHandler(this.btn_identificador_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Identificador máximo";
            // 
            // txt_IdentificadorMax
            // 
            this.txt_IdentificadorMax.Location = new System.Drawing.Point(169, 251);
            this.txt_IdentificadorMax.Name = "txt_IdentificadorMax";
            this.txt_IdentificadorMax.Size = new System.Drawing.Size(100, 20);
            this.txt_IdentificadorMax.TabIndex = 11;
            // 
            // btn_identificadorMax
            // 
            this.btn_identificadorMax.Location = new System.Drawing.Point(60, 291);
            this.btn_identificadorMax.Name = "btn_identificadorMax";
            this.btn_identificadorMax.Size = new System.Drawing.Size(155, 23);
            this.btn_identificadorMax.TabIndex = 12;
            this.btn_identificadorMax.Text = "Personas hasta identificador";
            this.btn_identificadorMax.UseVisualStyleBackColor = true;
            this.btn_identificadorMax.Click += new System.EventHandler(this.btn_identificadorMax_Click);
            // 
            // dataGrid2
            // 
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Location = new System.Drawing.Point(339, 251);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(401, 97);
            this.dataGrid2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Edad:";
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(115, 384);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(48, 20);
            this.txt_Edad.TabIndex = 15;
            // 
            // btn_Edad
            // 
            this.btn_Edad.Location = new System.Drawing.Point(60, 429);
            this.btn_Edad.Name = "btn_Edad";
            this.btn_Edad.Size = new System.Drawing.Size(149, 23);
            this.btn_Edad.TabIndex = 16;
            this.btn_Edad.Text = "Personas Mayores de";
            this.btn_Edad.UseVisualStyleBackColor = true;
            this.btn_Edad.Click += new System.EventHandler(this.btn_Edad_Click);
            // 
            // dataGrid3
            // 
            this.dataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid3.Location = new System.Drawing.Point(339, 375);
            this.dataGrid3.Name = "dataGrid3";
            this.dataGrid3.Size = new System.Drawing.Size(401, 104);
            this.dataGrid3.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicios7Al10ToolStripMenuItem,
            this.ejercicio10Y11ToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ejercicios7Al10ToolStripMenuItem
            // 
            this.ejercicios7Al10ToolStripMenuItem.Name = "ejercicios7Al10ToolStripMenuItem";
            this.ejercicios7Al10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicios7Al10ToolStripMenuItem.Text = "Ejercicios 7 al 9";
            this.ejercicios7Al10ToolStripMenuItem.Click += new System.EventHandler(this.ejercicios7Al10ToolStripMenuItem_Click);
            // 
            // ejercicio10Y11ToolStripMenuItem
            // 
            this.ejercicio10Y11ToolStripMenuItem.Name = "ejercicio10Y11ToolStripMenuItem";
            this.ejercicio10Y11ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio10Y11ToolStripMenuItem.Text = "Ejercicio 10 y 11";
            this.ejercicio10Y11ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio10Y11ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 543);
            this.Controls.Add(this.dataGrid3);
            this.Controls.Add(this.btn_Edad);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.btn_identificadorMax);
            this.Controls.Add(this.txt_IdentificadorMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_identificador);
            this.Controls.Add(this.txt_identificador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_localidad);
            this.Controls.Add(this.txt_localidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_BuscarPersona);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_BuscarPersona;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.Button btn_localidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_identificador;
        private System.Windows.Forms.Button btn_identificador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IdentificadorMax;
        private System.Windows.Forms.Button btn_identificadorMax;
        private System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Button btn_Edad;
        private System.Windows.Forms.DataGridView dataGrid3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicios7Al10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio10Y11ToolStripMenuItem;
    }
}

