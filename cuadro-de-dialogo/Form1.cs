using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuadro_dialogo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            //elemento para cambiar de color formulario
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void btnColorLetra_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lbl1.Font = fontDialog1.Font;
        }

        private void btnElegirCarpeta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            //mostramos la ruta de la carpeta elegida
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
            string ruta = folderBrowserDialog1.SelectedPath;
        }

        private void btnElegirArchivo_Click(object sender, EventArgs e)
        {
            //elegir un archivo
            openFileDialog1.ShowDialog();
            
            openFileDialog1.Filter="Archivos.txt|*.xsl|Archivos Acrobat|*.pdf";
            MessageBox.Show(openFileDialog1.FileName);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName);
        }
    }
}
