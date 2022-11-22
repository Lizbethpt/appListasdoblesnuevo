
namespace appListasdoblesnuevo
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbDato = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbxDato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(500, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(500, 209);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lbDato
            // 
            this.lbDato.AutoSize = true;
            this.lbDato.Location = new System.Drawing.Point(175, 185);
            this.lbDato.Name = "lbDato";
            this.lbDato.Size = new System.Drawing.Size(30, 13);
            this.lbDato.TabIndex = 2;
            this.lbDato.Text = "Dato";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(323, 182);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(500, 238);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbxDato
            // 
            this.lbxDato.FormattingEnabled = true;
            this.lbxDato.Location = new System.Drawing.Point(323, 238);
            this.lbxDato.Name = "lbxDato";
            this.lbxDato.Size = new System.Drawing.Size(120, 95);
            this.lbxDato.TabIndex = 5;
            this.lbxDato.SelectedIndexChanged += new System.EventHandler(this.lbxDato_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxDato);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lbDato);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lbDato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lbxDato;
    }
}

