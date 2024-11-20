namespace Trabajo_2
{
    partial class Asignaturas
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
            this.BT_descargaAsig = new System.Windows.Forms.Button();
            this.BT_guardarA = new System.Windows.Forms.Button();
            this.Tb_creditos = new System.Windows.Forms.TextBox();
            this.Tb_nomasig = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_lista = new System.Windows.Forms.GroupBox();
            this.DG_asignatura = new System.Windows.Forms.DataGridView();
            this.CT_mod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_ingreso.SuspendLayout();
            this.GB_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_asignatura)).BeginInit();
            this.CT_mod.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_ingreso
            // 
            this.GB_ingreso.Controls.Add(this.BT_descargaAsig);
            this.GB_ingreso.Controls.Add(this.BT_guardarA);
            this.GB_ingreso.Controls.Add(this.Tb_creditos);
            this.GB_ingreso.Controls.Add(this.Tb_nomasig);
            this.GB_ingreso.Controls.Add(this.label2);
            this.GB_ingreso.Controls.Add(this.label1);
            this.GB_ingreso.Location = new System.Drawing.Point(12, 24);
            this.GB_ingreso.Name = "GB_ingreso";
            this.GB_ingreso.Size = new System.Drawing.Size(221, 328);
            this.GB_ingreso.TabIndex = 1;
            this.GB_ingreso.TabStop = false;
            this.GB_ingreso.Text = "Asignaturas";
            // 
            // BT_descargaAsig
            // 
            this.BT_descargaAsig.Location = new System.Drawing.Point(66, 256);
            this.BT_descargaAsig.Name = "BT_descargaAsig";
            this.BT_descargaAsig.Size = new System.Drawing.Size(96, 42);
            this.BT_descargaAsig.TabIndex = 7;
            this.BT_descargaAsig.Text = "Descargar";
            this.BT_descargaAsig.UseVisualStyleBackColor = true;
            this.BT_descargaAsig.Click += new System.EventHandler(this.BT_descargaAsig_Click);
            // 
            // BT_guardarA
            // 
            this.BT_guardarA.Location = new System.Drawing.Point(66, 185);
            this.BT_guardarA.Name = "BT_guardarA";
            this.BT_guardarA.Size = new System.Drawing.Size(96, 42);
            this.BT_guardarA.TabIndex = 6;
            this.BT_guardarA.Text = "Guardar";
            this.BT_guardarA.UseVisualStyleBackColor = true;
            this.BT_guardarA.Click += new System.EventHandler(this.BT_guardarA_Click);
            // 
            // Tb_creditos
            // 
            this.Tb_creditos.Location = new System.Drawing.Point(47, 146);
            this.Tb_creditos.Name = "Tb_creditos";
            this.Tb_creditos.Size = new System.Drawing.Size(145, 20);
            this.Tb_creditos.TabIndex = 2;
            // 
            // Tb_nomasig
            // 
            this.Tb_nomasig.Location = new System.Drawing.Point(47, 60);
            this.Tb_nomasig.Name = "Tb_nomasig";
            this.Tb_nomasig.Size = new System.Drawing.Size(145, 20);
            this.Tb_nomasig.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Creditos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre De La Asignatura";
            // 
            // GB_lista
            // 
            this.GB_lista.Controls.Add(this.DG_asignatura);
            this.GB_lista.Location = new System.Drawing.Point(262, 24);
            this.GB_lista.Name = "GB_lista";
            this.GB_lista.Size = new System.Drawing.Size(269, 298);
            this.GB_lista.TabIndex = 2;
            this.GB_lista.TabStop = false;
            this.GB_lista.Text = "Lista de Asignaturas";
            // 
            // DG_asignatura
            // 
            this.DG_asignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_asignatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_asignatura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DG_asignatura.Location = new System.Drawing.Point(3, 16);
            this.DG_asignatura.Name = "DG_asignatura";
            this.DG_asignatura.ReadOnly = true;
            this.DG_asignatura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_asignatura.Size = new System.Drawing.Size(263, 279);
            this.DG_asignatura.TabIndex = 0;
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
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click_1);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // Asignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 378);
            this.ContextMenuStrip = this.CT_mod;
            this.Controls.Add(this.GB_lista);
            this.Controls.Add(this.GB_ingreso);
            this.Name = "Asignaturas";
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.Asignaturas_Load);
            this.GB_ingreso.ResumeLayout(false);
            this.GB_ingreso.PerformLayout();
            this.GB_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_asignatura)).EndInit();
            this.CT_mod.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_ingreso;
        private System.Windows.Forms.Button BT_guardarA;
        private System.Windows.Forms.TextBox Tb_creditos;
        private System.Windows.Forms.TextBox Tb_nomasig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_lista;
        private System.Windows.Forms.DataGridView DG_asignatura;
        private System.Windows.Forms.ContextMenuStrip CT_mod;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button BT_descargaAsig;
    }
}