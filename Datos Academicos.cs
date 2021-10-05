using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wMatriculas
{
    public partial class Datos_Academicos : Form
    {
        public Datos_Academicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Datos_Academicos_Load(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog2.ShowDialog().Equals(DialogResult.OK))
                {
                    Stream strGuardar = saveFileDialog2.OpenFile(); StreamWriter wrtGuardar = new StreamWriter (strGuardar);
                    foreach (string linea in textBox1.Lines) { wrtGuardar.WriteLine(linea); }
                    wrtGuardar.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
