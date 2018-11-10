namespace Ejemplo.Enumerables
{
    partial class Form1
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
            this.tbAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbSalida = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnRefrescarLista = new System.Windows.Forms.Button();
            this.cbAgregarAlFinal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbAgregar
            // 
            this.tbAgregar.Location = new System.Drawing.Point(177, 86);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Size = new System.Drawing.Size(504, 20);
            this.tbAgregar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto a agregar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(92, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 186);
            this.listBox1.TabIndex = 2;
            // 
            // cbSalida
            // 
            this.cbSalida.FormattingEnabled = true;
            this.cbSalida.Location = new System.Drawing.Point(370, 148);
            this.cbSalida.Name = "cbSalida";
            this.cbSalida.Size = new System.Drawing.Size(292, 21);
            this.cbSalida.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(687, 83);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(687, 112);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(97, 23);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.Text = "Refrescar CB";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnRefrescarLista
            // 
            this.btnRefrescarLista.Location = new System.Drawing.Point(687, 148);
            this.btnRefrescarLista.Name = "btnRefrescarLista";
            this.btnRefrescarLista.Size = new System.Drawing.Size(97, 23);
            this.btnRefrescarLista.TabIndex = 7;
            this.btnRefrescarLista.Text = "Refrescar Lista";
            this.btnRefrescarLista.UseVisualStyleBackColor = true;
            this.btnRefrescarLista.Click += new System.EventHandler(this.btnRefrescarLista_Click);
            // 
            // cbAgregarAlFinal
            // 
            this.cbAgregarAlFinal.AutoSize = true;
            this.cbAgregarAlFinal.Location = new System.Drawing.Point(391, 245);
            this.cbAgregarAlFinal.Name = "cbAgregarAlFinal";
            this.cbAgregarAlFinal.Size = new System.Drawing.Size(99, 17);
            this.cbAgregarAlFinal.TabIndex = 8;
            this.cbAgregarAlFinal.Text = "Agregar al Final";
            this.cbAgregarAlFinal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 351);
            this.Controls.Add(this.cbAgregarAlFinal);
            this.Controls.Add(this.btnRefrescarLista);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbSalida);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAgregar);
            this.Name = "Form1";
            this.Text = "Estructuras Enumerables";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbSalida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnRefrescarLista;
        private System.Windows.Forms.CheckBox cbAgregarAlFinal;
    }
}

