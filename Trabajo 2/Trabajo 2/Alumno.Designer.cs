namespace Trabajo_2
{
    partial class Alumno
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
            this.components = new System.ComponentModel.Container();
            this.GB_ingreso = new System.Windows.Forms.GroupBox();
            this.BT_descarga = new System.Windows.Forms.Button();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.Tb_email = new System.Windows.Forms.TextBox();
            this.Tb_matricula = new System.Windows.Forms.TextBox();
            this.Tb_apema = new System.Windows.Forms.TextBox();
            this.Tb_apepa = new System.Windows.Forms.TextBox();
            this.Tb_nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_lista = new System.Windows.Forms.GroupBox();
            this.DG_alumno = new System.Windows.Forms.DataGridView();
            this.CT_mod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_ingreso.SuspendLayout();
            this.GB_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_alumno)).BeginInit();
            this.CT_mod.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_ingreso
            // 
            this.GB_ingreso.Controls.Add(this.BT_descarga);
            this.GB_ingreso.Controls.Add(this.BT_guardar);
            this.GB_ingreso.Controls.Add(this.Tb_email);
            this.GB_ingreso.Controls.Add(this.Tb_matricula);
            this.GB_ingreso.Controls.Add(this.Tb_apema);
            this.GB_ingreso.Controls.Add(this.Tb_apepa);
            this.GB_ingreso.Controls.Add(this.Tb_nom);
            this.GB_ingreso.Controls.Add(this.label5);
            this.GB_ingreso.Controls.Add(this.label4);
            this.GB_ingreso.Controls.Add(this.label3);
            this.GB_ingreso.Controls.Add(this.label2);
            this.GB_ingreso.Controls.Add(this.label1);
            this.GB_ingreso.Location = new System.Drawing.Point(12, 12);
            this.GB_ingreso.Name = "GB_ingreso";
            this.GB_ingreso.Size = new System.Drawing.Size(304, 241);
            this.GB_ingreso.TabIndex = 0;
            this.GB_ingreso.TabStop = false;
            this.GB_ingreso.Text = "Ingresar Alumno";
            // 
            // BT_descarga
            // 
            this.BT_descarga.Location = new System.Drawing.Point(203, 195);
            this.BT_descarga.Name = "BT_descarga";
            this.BT_descarga.Size = new System.Drawing.Size(75, 23);
            this.BT_descarga.TabIndex = 7;
            this.BT_descarga.Text = "Descargar";
            this.BT_descarga.UseVisualStyleBackColor = true;
            this.BT_descarga.Click += new System.EventHandler(this.BT_descarga_Click);
            // 
            // BT_guardar
            // 
            this.BT_guardar.Location = new System.Drawing.Point(25, 195);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(75, 23);
            this.BT_guardar.TabIndex = 6;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = true;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // Tb_email
            // 
            this.Tb_email.Location = new System.Drawing.Point(133, 113);
            this.Tb_email.Name = "Tb_email";
            this.Tb_email.Size = new System.Drawing.Size(145, 20);
            this.Tb_email.TabIndex = 4;
            // 
            // Tb_matricula
            // 
            this.Tb_matricula.Location = new System.Drawing.Point(133, 140);
            this.Tb_matricula.Name = "Tb_matricula";
            this.Tb_matricula.Size = new System.Drawing.Size(145, 20);
            this.Tb_matricula.TabIndex = 5;
            // 
            // Tb_apema
            // 
            this.Tb_apema.Location = new System.Drawing.Point(133, 87);
            this.Tb_apema.Name = "Tb_apema";
            this.Tb_apema.Size = new System.Drawing.Size(145, 20);
            this.Tb_apema.TabIndex = 3;
            // 
            // Tb_apepa
            // 
            this.Tb_apepa.Location = new System.Drawing.Point(133, 61);
            this.Tb_apepa.Name = "Tb_apepa";
            this.Tb_apepa.Size = new System.Drawing.Size(145, 20);
            this.Tb_apepa.TabIndex = 2;
            // 
            // Tb_nom
            // 
            this.Tb_nom.Location = new System.Drawing.Point(133, 35);
            this.Tb_nom.Name = "Tb_nom";
            this.Tb_nom.Size = new System.Drawing.Size(145, 20);
            this.Tb_nom.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero Matriula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // GB_lista
            // 
            this.GB_lista.Controls.Add(this.DG_alumno);
            this.GB_lista.Location = new System.Drawing.Point(360, 19);
            this.GB_lista.Name = "GB_lista";
            this.GB_lista.Size = new System.Drawing.Size(396, 234);
            this.GB_lista.TabIndex = 1;
            this.GB_lista.TabStop = false;
            this.GB_lista.Text = "Lista de Alumnos";
            // 
            // DG_alumno
            // 
            this.DG_alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_alumno.ContextMenuStrip = this.CT_mod;
            this.DG_alumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_alumno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DG_alumno.Location = new System.Drawing.Point(3, 16);
            this.DG_alumno.Name = "DG_alumno";
            this.DG_alumno.ReadOnly = true;
            this.DG_alumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_alumno.Size = new System.Drawing.Size(390, 215);
            this.DG_alumno.TabIndex = 0;
            // 
            // CT_mod
            // 
            this.CT_mod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.CT_mod.Name = "CT_mod";
            this.CT_mod.Size = new System.Drawing.Size(126, 48);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 288);
            this.Controls.Add(this.GB_lista);
            this.Controls.Add(this.GB_ingreso);
            this.Name = "Alumno";
            this.Text = "ALUMNOS";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.GB_ingreso.ResumeLayout(false);
            this.GB_ingreso.PerformLayout();
            this.GB_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_alumno)).EndInit();
            this.CT_mod.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_ingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.TextBox Tb_email;
        private System.Windows.Forms.TextBox Tb_matricula;
        private System.Windows.Forms.TextBox Tb_apema;
        private System.Windows.Forms.TextBox Tb_apepa;
        private System.Windows.Forms.TextBox Tb_nom;
        private System.Windows.Forms.GroupBox GB_lista;
        private System.Windows.Forms.DataGridView DG_alumno;
        private System.Windows.Forms.ContextMenuStrip CT_mod;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button BT_descarga;
    }
}