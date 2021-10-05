namespace wMatriculas
{
    partial class Datos_Academicos
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
            this.grbMateria = new System.Windows.Forms.GroupBox();
            this.rdoCalculo = new System.Windows.Forms.RadioButton();
            this.rdoBase = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdoInteligencia = new System.Windows.Forms.RadioButton();
            this.rdoSeguridad = new System.Windows.Forms.RadioButton();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.grbMateria.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMateria
            // 
            this.grbMateria.Controls.Add(this.rdoSeguridad);
            this.grbMateria.Controls.Add(this.rdoInteligencia);
            this.grbMateria.Controls.Add(this.rdoBase);
            this.grbMateria.Controls.Add(this.rdoCalculo);
            this.grbMateria.Location = new System.Drawing.Point(37, 77);
            this.grbMateria.Name = "grbMateria";
            this.grbMateria.Size = new System.Drawing.Size(281, 86);
            this.grbMateria.TabIndex = 0;
            this.grbMateria.TabStop = false;
            this.grbMateria.Text = "Materia";
            // 
            // rdoCalculo
            // 
            this.rdoCalculo.AutoSize = true;
            this.rdoCalculo.Location = new System.Drawing.Point(17, 29);
            this.rdoCalculo.Name = "rdoCalculo";
            this.rdoCalculo.Size = new System.Drawing.Size(60, 17);
            this.rdoCalculo.TabIndex = 0;
            this.rdoCalculo.TabStop = true;
            this.rdoCalculo.Text = "Calculo";
            this.rdoCalculo.UseVisualStyleBackColor = true;
            // 
            // rdoBase
            // 
            this.rdoBase.AutoSize = true;
            this.rdoBase.Location = new System.Drawing.Point(17, 53);
            this.rdoBase.Name = "rdoBase";
            this.rdoBase.Size = new System.Drawing.Size(95, 17);
            this.rdoBase.TabIndex = 1;
            this.rdoBase.TabStop = true;
            this.rdoBase.Text = "Base de Datos";
            this.rdoBase.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 20);
            this.textBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Visible = false;
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarToolStripMenuItem.MergeIndex = 1;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // rdoInteligencia
            // 
            this.rdoInteligencia.AutoSize = true;
            this.rdoInteligencia.Location = new System.Drawing.Point(146, 29);
            this.rdoInteligencia.Name = "rdoInteligencia";
            this.rdoInteligencia.Size = new System.Drawing.Size(118, 17);
            this.rdoInteligencia.TabIndex = 3;
            this.rdoInteligencia.TabStop = true;
            this.rdoInteligencia.Text = "Inteligencia Artificial";
            this.rdoInteligencia.UseVisualStyleBackColor = true;
            // 
            // rdoSeguridad
            // 
            this.rdoSeguridad.AutoSize = true;
            this.rdoSeguridad.Location = new System.Drawing.Point(146, 53);
            this.rdoSeguridad.Name = "rdoSeguridad";
            this.rdoSeguridad.Size = new System.Drawing.Size(128, 17);
            this.rdoSeguridad.TabIndex = 4;
            this.rdoSeguridad.TabStop = true;
            this.rdoSeguridad.Text = "Seguridad Informatica";
            this.rdoSeguridad.UseVisualStyleBackColor = true;
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(37, 215);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 3;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(396, 215);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(100, 20);
            this.txtSemestre.TabIndex = 4;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(314, 221);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(51, 13);
            this.lblSemestre.TabIndex = 5;
            this.lblSemestre.Text = "Semestre";
            this.lblSemestre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Datos_Academicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 329);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.chbActivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grbMateria);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Datos_Academicos";
            this.Text = "Datos_Academicos";
            this.Load += new System.EventHandler(this.Datos_Academicos_Load);
            this.grbMateria.ResumeLayout(false);
            this.grbMateria.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMateria;
        private System.Windows.Forms.RadioButton rdoBase;
        private System.Windows.Forms.RadioButton rdoCalculo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton rdoSeguridad;
        private System.Windows.Forms.RadioButton rdoInteligencia;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}