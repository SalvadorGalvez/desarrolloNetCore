namespace XApr08Menus.views.Usuarios
{
    partial class usuariosDesactivar
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
            this.cmbUsr = new System.Windows.Forms.ComboBox();
            this.btnUsr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige el usuario:";
            // 
            // cmbUsr
            // 
            this.cmbUsr.FormattingEnabled = true;
            this.cmbUsr.Location = new System.Drawing.Point(117, 23);
            this.cmbUsr.Name = "cmbUsr";
            this.cmbUsr.Size = new System.Drawing.Size(305, 23);
            this.cmbUsr.TabIndex = 2;
            // 
            // btnUsr
            // 
            this.btnUsr.Location = new System.Drawing.Point(448, 22);
            this.btnUsr.Name = "btnUsr";
            this.btnUsr.Size = new System.Drawing.Size(116, 23);
            this.btnUsr.TabIndex = 3;
            this.btnUsr.Text = "Seleccionar";
            this.btnUsr.UseVisualStyleBackColor = true;
            this.btnUsr.Click += new System.EventHandler(this.btnUsr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnActivar);
            this.groupBox1.Location = new System.Drawing.Point(22, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            this.groupBox1.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(339, 71);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(175, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar usuario";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(51, 71);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(175, 23);
            this.btnActivar.TabIndex = 0;
            this.btnActivar.Text = "button1";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // usuariosDesactivar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUsr);
            this.Controls.Add(this.cmbUsr);
            this.Controls.Add(this.label1);
            this.Name = "usuariosDesactivar";
            this.Text = "usuariosDesactivar";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsr;
        private System.Windows.Forms.Button btnUsr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActivar;
    }
}