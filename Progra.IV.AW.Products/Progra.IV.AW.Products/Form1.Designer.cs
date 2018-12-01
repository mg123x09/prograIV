namespace Progra.IV.AW.Products
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
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.lbProductos = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.cbColores = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(136, 90);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(278, 21);
            this.cbProductos.TabIndex = 0;
            // 
            // lbProductos
            // 
            this.lbProductos.AutoSize = true;
            this.lbProductos.Location = new System.Drawing.Point(30, 93);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(100, 13);
            this.lbProductos.TabIndex = 1;
            this.lbProductos.Text = "Lista de productos: ";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(30, 168);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(37, 13);
            this.lbColor.TabIndex = 2;
            this.lbColor.Text = "Color: ";
            // 
            // cbColores
            // 
            this.cbColores.FormattingEnabled = true;
            this.cbColores.Items.AddRange(new object[] {
            "Black",
            "White",
            "Brown",
            "Yellow",
            "Green"});
            this.cbColores.Location = new System.Drawing.Point(136, 160);
            this.cbColores.Name = "cbColores";
            this.cbColores.Size = new System.Drawing.Size(278, 21);
            this.cbColores.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(136, 187);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbColores);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.cbProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label lbProductos;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cbColores;
        private System.Windows.Forms.Button btnConsultar;
    }
}

