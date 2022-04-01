namespace XApr08Menus.views
{
    partial class CombosyListas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDeptos = new System.Windows.Forms.ComboBox();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.cmbProfesores = new System.Windows.Forms.ComboBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnDeptos = new System.Windows.Forms.Button();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.lstDepto = new System.Windows.Forms.ListBox();
            this.lstCarrera = new System.Windows.Forms.ListBox();
            this.lstProfes = new System.Windows.Forms.ListBox();
            this.btnDepto = new System.Windows.Forms.Button();
            this.btnCarreraL = new System.Windows.Forms.Button();
            this.btnProfesL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carreras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profesores";
            // 
            // cmbDeptos
            // 
            this.cmbDeptos.FormattingEnabled = true;
            this.cmbDeptos.Location = new System.Drawing.Point(26, 49);
            this.cmbDeptos.Name = "cmbDeptos";
            this.cmbDeptos.Size = new System.Drawing.Size(205, 23);
            this.cmbDeptos.TabIndex = 3;
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(280, 49);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(205, 23);
            this.cmbCarreras.TabIndex = 4;
            // 
            // cmbProfesores
            // 
            this.cmbProfesores.FormattingEnabled = true;
            this.cmbProfesores.Location = new System.Drawing.Point(531, 49);
            this.cmbProfesores.Name = "cmbProfesores";
            this.cmbProfesores.Size = new System.Drawing.Size(205, 23);
            this.cmbProfesores.TabIndex = 5;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(788, 31);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.Size = new System.Drawing.Size(301, 397);
            this.txtSalida.TabIndex = 6;
            // 
            // btnDeptos
            // 
            this.btnDeptos.Location = new System.Drawing.Point(26, 78);
            this.btnDeptos.Name = "btnDeptos";
            this.btnDeptos.Size = new System.Drawing.Size(205, 23);
            this.btnDeptos.TabIndex = 7;
            this.btnDeptos.Text = "Seleccionar";
            this.btnDeptos.UseVisualStyleBackColor = true;
            this.btnDeptos.Click += new System.EventHandler(this.btnDeptos_Click);
            // 
            // btnCarrera
            // 
            this.btnCarrera.Location = new System.Drawing.Point(280, 78);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(205, 23);
            this.btnCarrera.TabIndex = 8;
            this.btnCarrera.Text = "Seleccionar carr";
            this.btnCarrera.UseVisualStyleBackColor = true;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Location = new System.Drawing.Point(531, 78);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(205, 23);
            this.btnProfesores.TabIndex = 9;
            this.btnProfesores.Text = "Seleccionar";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // lstDepto
            // 
            this.lstDepto.FormattingEnabled = true;
            this.lstDepto.ItemHeight = 15;
            this.lstDepto.Location = new System.Drawing.Point(26, 154);
            this.lstDepto.Name = "lstDepto";
            this.lstDepto.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDepto.Size = new System.Drawing.Size(205, 274);
            this.lstDepto.TabIndex = 10;
            // 
            // lstCarrera
            // 
            this.lstCarrera.FormattingEnabled = true;
            this.lstCarrera.ItemHeight = 15;
            this.lstCarrera.Location = new System.Drawing.Point(280, 154);
            this.lstCarrera.Name = "lstCarrera";
            this.lstCarrera.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCarrera.Size = new System.Drawing.Size(205, 274);
            this.lstCarrera.TabIndex = 11;
            // 
            // lstProfes
            // 
            this.lstProfes.FormattingEnabled = true;
            this.lstProfes.ItemHeight = 15;
            this.lstProfes.Location = new System.Drawing.Point(531, 154);
            this.lstProfes.Name = "lstProfes";
            this.lstProfes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstProfes.Size = new System.Drawing.Size(205, 274);
            this.lstProfes.TabIndex = 12;
            // 
            // btnDepto
            // 
            this.btnDepto.Location = new System.Drawing.Point(26, 444);
            this.btnDepto.Name = "btnDepto";
            this.btnDepto.Size = new System.Drawing.Size(205, 23);
            this.btnDepto.TabIndex = 13;
            this.btnDepto.Text = "Seleccionar";
            this.btnDepto.UseVisualStyleBackColor = true;
            this.btnDepto.Click += new System.EventHandler(this.btnDepto_Click);
            // 
            // btnCarreraL
            // 
            this.btnCarreraL.Location = new System.Drawing.Point(280, 444);
            this.btnCarreraL.Name = "btnCarreraL";
            this.btnCarreraL.Size = new System.Drawing.Size(205, 23);
            this.btnCarreraL.TabIndex = 14;
            this.btnCarreraL.Text = "Seleccionar";
            this.btnCarreraL.UseVisualStyleBackColor = true;
            this.btnCarreraL.Click += new System.EventHandler(this.btnCarreraL_Click);
            // 
            // btnProfesL
            // 
            this.btnProfesL.Location = new System.Drawing.Point(531, 444);
            this.btnProfesL.Name = "btnProfesL";
            this.btnProfesL.Size = new System.Drawing.Size(205, 23);
            this.btnProfesL.TabIndex = 15;
            this.btnProfesL.Text = "Seleccionar";
            this.btnProfesL.UseVisualStyleBackColor = true;
            // 
            // CombosyListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 510);
            this.Controls.Add(this.btnProfesL);
            this.Controls.Add(this.btnCarreraL);
            this.Controls.Add(this.btnDepto);
            this.Controls.Add(this.lstProfes);
            this.Controls.Add(this.lstCarrera);
            this.Controls.Add(this.lstDepto);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.btnCarrera);
            this.Controls.Add(this.btnDeptos);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.cmbProfesores);
            this.Controls.Add(this.cmbCarreras);
            this.Controls.Add(this.cmbDeptos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CombosyListas";
            this.Text = "CombosyListas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDeptos;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.ComboBox cmbProfesores;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnDeptos;
        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.ListBox lstDepto;
        private System.Windows.Forms.ListBox lstCarrera;
        private System.Windows.Forms.ListBox lstProfes;
        private System.Windows.Forms.Button btnDepto;
        private System.Windows.Forms.Button btnCarreraL;
        private System.Windows.Forms.Button btnProfesL;
    }
}