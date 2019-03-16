namespace TPFenetreMereFille
{
    partial class FFille
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
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnMere = new System.Windows.Forms.Button();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(197, 31);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 0;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // btnMere
            // 
            this.btnMere.Location = new System.Drawing.Point(92, 76);
            this.btnMere.Name = "btnMere";
            this.btnMere.Size = new System.Drawing.Size(75, 23);
            this.btnMere.TabIndex = 1;
            this.btnMere.Text = "Ma mère";
            this.btnMere.UseVisualStyleBackColor = true;
            this.btnMere.Click += new System.EventHandler(this.btnMere_Click);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(4, 39);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(77, 13);
            this.lbNom.TabIndex = 2;
            this.lbNom.Text = "Nouveau nom:";
            this.lbNom.Click += new System.EventHandler(this.lbNom_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(92, 32);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 3;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.btnMere);
            this.Controls.Add(this.btnChanger);
            this.Name = "FFille";
            this.Text = "FFille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnMere;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNom;
    }
}