namespace pryBarrazaSP1Clinica
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarEspecialidad = new System.Windows.Forms.Button();
            this.btnRegistrarEspecialidad = new System.Windows.Forms.Button();
            this.txtNroIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelarMedico = new System.Windows.Forms.Button();
            this.btnRegistrarMedico = new System.Windows.Forms.Button();
            this.txtEspecialidadMedico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(177, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Especialidad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelarEspecialidad);
            this.groupBox1.Controls.Add(this.btnRegistrarEspecialidad);
            this.groupBox1.Controls.Add(this.txtNroIdentificacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreEspecialidad);
            this.groupBox1.Location = new System.Drawing.Point(93, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Especialidad";
            // 
            // btnCancelarEspecialidad
            // 
            this.btnCancelarEspecialidad.Location = new System.Drawing.Point(239, 222);
            this.btnCancelarEspecialidad.Name = "btnCancelarEspecialidad";
            this.btnCancelarEspecialidad.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEspecialidad.TabIndex = 4;
            this.btnCancelarEspecialidad.Text = "Cancelar";
            this.btnCancelarEspecialidad.UseVisualStyleBackColor = true;
            this.btnCancelarEspecialidad.Click += new System.EventHandler(this.btnCancelarEspecialidad_Click);
            // 
            // btnRegistrarEspecialidad
            // 
            this.btnRegistrarEspecialidad.Location = new System.Drawing.Point(358, 222);
            this.btnRegistrarEspecialidad.Name = "btnRegistrarEspecialidad";
            this.btnRegistrarEspecialidad.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarEspecialidad.TabIndex = 3;
            this.btnRegistrarEspecialidad.Text = "Registrar Especialidad";
            this.btnRegistrarEspecialidad.UseVisualStyleBackColor = true;
            this.btnRegistrarEspecialidad.Click += new System.EventHandler(this.btnRegistrarEspecialidad_Click);
            // 
            // txtNroIdentificacion
            // 
            this.txtNroIdentificacion.Location = new System.Drawing.Point(186, 133);
            this.txtNroIdentificacion.Name = "txtNroIdentificacion";
            this.txtNroIdentificacion.Size = new System.Drawing.Size(248, 20);
            this.txtNroIdentificacion.TabIndex = 2;
            this.txtNroIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroIdentificacion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de Identificacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreEspecialidad
            // 
            this.txtNombreEspecialidad.Location = new System.Drawing.Point(186, 87);
            this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            this.txtNombreEspecialidad.Size = new System.Drawing.Size(248, 20);
            this.txtNombreEspecialidad.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(709, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registrar Medico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelarMedico);
            this.groupBox2.Controls.Add(this.btnRegistrarMedico);
            this.groupBox2.Controls.Add(this.txtEspecialidadMedico);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMatricula);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNombreMedico);
            this.groupBox2.Location = new System.Drawing.Point(85, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Medico";
            // 
            // btnCancelarMedico
            // 
            this.btnCancelarMedico.Location = new System.Drawing.Point(289, 185);
            this.btnCancelarMedico.Name = "btnCancelarMedico";
            this.btnCancelarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMedico.TabIndex = 5;
            this.btnCancelarMedico.Text = "Cancelar";
            this.btnCancelarMedico.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.Location = new System.Drawing.Point(399, 185);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarMedico.TabIndex = 4;
            this.btnRegistrarMedico.Text = "Registrar Medico";
            this.btnRegistrarMedico.UseVisualStyleBackColor = true;
            this.btnRegistrarMedico.Click += new System.EventHandler(this.btnRegistrarMedico_Click_1);
            // 
            // txtEspecialidadMedico
            // 
            this.txtEspecialidadMedico.Location = new System.Drawing.Point(226, 145);
            this.txtEspecialidadMedico.Name = "txtEspecialidadMedico";
            this.txtEspecialidadMedico.Size = new System.Drawing.Size(248, 20);
            this.txtEspecialidadMedico.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de Especialidad:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(226, 103);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(248, 20);
            this.txtMatricula.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matricula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(226, 62);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(248, 20);
            this.txtNombreMedico.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvInfo);
            this.groupBox3.Controls.Add(this.cmbEspecialidad);
            this.groupBox3.Location = new System.Drawing.Point(37, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 325);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar Medicos ";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvInfo.Location = new System.Drawing.Point(63, 129);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInfo.Size = new System.Drawing.Size(518, 169);
            this.dgvInfo.TabIndex = 1;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(63, 51);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(518, 21);
            this.cmbEspecialidad.TabIndex = 0;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 594);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEspecialidad;
        private System.Windows.Forms.TextBox txtNroIdentificacion;
        private System.Windows.Forms.Button btnCancelarEspecialidad;
        private System.Windows.Forms.Button btnRegistrarEspecialidad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarMedico;
        private System.Windows.Forms.Button btnRegistrarMedico;
        private System.Windows.Forms.TextBox txtEspecialidadMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreMedico;
    }
}