using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wMatriculas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Datos_de_Estudiantes FrmHijo1 = new Datos_de_Estudiantes();
            FrmHijo1.MdiParent = this; 
            FrmHijo1.Show();

            Datos_Academicos FrmHijo2 = new Datos_Academicos();
            FrmHijo2.MdiParent = this;
            FrmHijo2.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHijo1 = this.ActiveMdiChild;
            if (frmHijo1 != null)
            { frmHijo1.Close(); }
        }
    }
}
