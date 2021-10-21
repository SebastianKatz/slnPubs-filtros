
namespace WindowsPubs
{
    partial class Form1
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
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.btnFiltrarCiudad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFiltrar2 = new System.Windows.Forms.TextBox();
            this.btnFiltrar2 = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAutores
            // 
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAutores.Location = new System.Drawing.Point(0, 72);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.Size = new System.Drawing.Size(800, 378);
            this.gridAutores.TabIndex = 0;
            // 
            // btnFiltrarCiudad
            // 
            this.btnFiltrarCiudad.Location = new System.Drawing.Point(136, 12);
            this.btnFiltrarCiudad.Name = "btnFiltrarCiudad";
            this.btnFiltrarCiudad.Size = new System.Drawing.Size(132, 44);
            this.btnFiltrarCiudad.TabIndex = 1;
            this.btnFiltrarCiudad.Text = "Filtrar por ciudad";
            this.btnFiltrarCiudad.UseVisualStyleBackColor = true;
            this.btnFiltrarCiudad.Click += new System.EventHandler(this.btnFiltrarCiudad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(12, 25);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 3;
            // 
            // txtFiltrar2
            // 
            this.txtFiltrar2.Location = new System.Drawing.Point(349, 28);
            this.txtFiltrar2.Name = "txtFiltrar2";
            this.txtFiltrar2.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrar2.TabIndex = 4;
            // 
            // btnFiltrar2
            // 
            this.btnFiltrar2.Location = new System.Drawing.Point(506, 12);
            this.btnFiltrar2.Name = "btnFiltrar2";
            this.btnFiltrar2.Size = new System.Drawing.Size(112, 43);
            this.btnFiltrar2.TabIndex = 5;
            this.btnFiltrar2.Text = "Filtrar por ciudad y estado";
            this.btnFiltrar2.UseVisualStyleBackColor = true;
            this.btnFiltrar2.Click += new System.EventHandler(this.btnFiltrar2_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(662, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 44);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnFiltrar2);
            this.Controls.Add(this.txtFiltrar2);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrarCiudad);
            this.Controls.Add(this.gridAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.Button btnFiltrarCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFiltrar2;
        private System.Windows.Forms.Button btnFiltrar2;
        private System.Windows.Forms.Button btnMostrar;
    }
}

