
namespace cuadro_dialogo_1
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
            this.btnCambiar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColorLetra = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnElegirCarpeta = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnElegirArchivo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(12, 12);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(155, 35);
            this.btnCambiar.TabIndex = 0;
            this.btnCambiar.Text = "Cambiar color";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnColorLetra
            // 
            this.btnColorLetra.Location = new System.Drawing.Point(12, 80);
            this.btnColorLetra.Name = "btnColorLetra";
            this.btnColorLetra.Size = new System.Drawing.Size(155, 35);
            this.btnColorLetra.TabIndex = 1;
            this.btnColorLetra.Text = "Cambiar color letra";
            this.btnColorLetra.UseVisualStyleBackColor = true;
            this.btnColorLetra.Click += new System.EventHandler(this.btnColorLetra_Click);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(173, 86);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(363, 23);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "cuidado con el perro";
            // 
            // btnElegirCarpeta
            // 
            this.btnElegirCarpeta.Location = new System.Drawing.Point(12, 148);
            this.btnElegirCarpeta.Name = "btnElegirCarpeta";
            this.btnElegirCarpeta.Size = new System.Drawing.Size(155, 35);
            this.btnElegirCarpeta.TabIndex = 3;
            this.btnElegirCarpeta.Text = "Elegir carpeta";
            this.btnElegirCarpeta.UseVisualStyleBackColor = true;
            this.btnElegirCarpeta.Click += new System.EventHandler(this.btnElegirCarpeta_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnElegirArchivo
            // 
            this.btnElegirArchivo.Location = new System.Drawing.Point(12, 216);
            this.btnElegirArchivo.Name = "btnElegirArchivo";
            this.btnElegirArchivo.Size = new System.Drawing.Size(155, 35);
            this.btnElegirArchivo.TabIndex = 4;
            this.btnElegirArchivo.Text = "Elegir un archivo";
            this.btnElegirArchivo.UseVisualStyleBackColor = true;
            this.btnElegirArchivo.Click += new System.EventHandler(this.btnElegirArchivo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 35);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnElegirArchivo);
            this.Controls.Add(this.btnElegirCarpeta);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnColorLetra);
            this.Controls.Add(this.btnCambiar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorLetra;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnElegirCarpeta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnElegirArchivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

