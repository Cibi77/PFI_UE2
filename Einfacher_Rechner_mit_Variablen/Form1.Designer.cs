namespace Aufgabe_A2_1_3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblZahl1 = new System.Windows.Forms.Label();
            this.LblZahl2 = new System.Windows.Forms.Label();
            this.TxtZahl1 = new System.Windows.Forms.TextBox();
            this.TxtZahl2 = new System.Windows.Forms.TextBox();
            this.LblResultat = new System.Windows.Forms.Label();
            this.TxtResultat = new System.Windows.Forms.TextBox();
            this.CmdPlus = new System.Windows.Forms.Button();
            this.CmdMinus = new System.Windows.Forms.Button();
            this.CmdMal = new System.Windows.Forms.Button();
            this.CmdDurch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblZahl1
            // 
            this.LblZahl1.AutoSize = true;
            this.LblZahl1.Location = new System.Drawing.Point(40, 35);
            this.LblZahl1.Name = "LblZahl1";
            this.LblZahl1.Size = new System.Drawing.Size(49, 20);
            this.LblZahl1.TabIndex = 0;
            this.LblZahl1.Text = "Zahl1";
            // 
            // LblZahl2
            // 
            this.LblZahl2.AutoSize = true;
            this.LblZahl2.Location = new System.Drawing.Point(40, 88);
            this.LblZahl2.Name = "LblZahl2";
            this.LblZahl2.Size = new System.Drawing.Size(49, 20);
            this.LblZahl2.TabIndex = 0;
            this.LblZahl2.Text = "Zahl2";
            // 
            // TxtZahl1
            // 
            this.TxtZahl1.Location = new System.Drawing.Point(134, 35);
            this.TxtZahl1.Name = "TxtZahl1";
            this.TxtZahl1.Size = new System.Drawing.Size(227, 26);
            this.TxtZahl1.TabIndex = 1;
            // 
            // TxtZahl2
            // 
            this.TxtZahl2.Location = new System.Drawing.Point(134, 82);
            this.TxtZahl2.Name = "TxtZahl2";
            this.TxtZahl2.Size = new System.Drawing.Size(227, 26);
            this.TxtZahl2.TabIndex = 1;
            // 
            // LblResultat
            // 
            this.LblResultat.AutoSize = true;
            this.LblResultat.Location = new System.Drawing.Point(44, 162);
            this.LblResultat.Name = "LblResultat";
            this.LblResultat.Size = new System.Drawing.Size(69, 20);
            this.LblResultat.TabIndex = 2;
            this.LblResultat.Text = "Resultat";
            // 
            // TxtResultat
            // 
            this.TxtResultat.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultat.Location = new System.Drawing.Point(134, 156);
            this.TxtResultat.Name = "TxtResultat";
            this.TxtResultat.Size = new System.Drawing.Size(227, 39);
            this.TxtResultat.TabIndex = 1;
            // 
            // CmdPlus
            // 
            this.CmdPlus.Location = new System.Drawing.Point(44, 233);
            this.CmdPlus.Name = "CmdPlus";
            this.CmdPlus.Size = new System.Drawing.Size(57, 55);
            this.CmdPlus.TabIndex = 3;
            this.CmdPlus.Text = "+";
            this.CmdPlus.UseVisualStyleBackColor = true;
            this.CmdPlus.Click += new System.EventHandler(this.CmdPlus_Click);
            // 
            // CmdMinus
            // 
            this.CmdMinus.Location = new System.Drawing.Point(134, 233);
            this.CmdMinus.Name = "CmdMinus";
            this.CmdMinus.Size = new System.Drawing.Size(57, 55);
            this.CmdMinus.TabIndex = 3;
            this.CmdMinus.Text = "-";
            this.CmdMinus.UseVisualStyleBackColor = true;
            this.CmdMinus.Click += new System.EventHandler(this.CmdMinus_Click);
            // 
            // CmdMal
            // 
            this.CmdMal.Location = new System.Drawing.Point(224, 233);
            this.CmdMal.Name = "CmdMal";
            this.CmdMal.Size = new System.Drawing.Size(57, 55);
            this.CmdMal.TabIndex = 3;
            this.CmdMal.Text = "*";
            this.CmdMal.UseVisualStyleBackColor = true;
            this.CmdMal.Click += new System.EventHandler(this.CmdMal_Click);
            // 
            // CmdDurch
            // 
            this.CmdDurch.Location = new System.Drawing.Point(316, 233);
            this.CmdDurch.Name = "CmdDurch";
            this.CmdDurch.Size = new System.Drawing.Size(57, 55);
            this.CmdDurch.TabIndex = 3;
            this.CmdDurch.Text = "/";
            this.CmdDurch.UseVisualStyleBackColor = true;
            this.CmdDurch.Click += new System.EventHandler(this.CmdDurch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 313);
            this.Controls.Add(this.CmdDurch);
            this.Controls.Add(this.CmdMal);
            this.Controls.Add(this.CmdMinus);
            this.Controls.Add(this.CmdPlus);
            this.Controls.Add(this.LblResultat);
            this.Controls.Add(this.TxtResultat);
            this.Controls.Add(this.TxtZahl2);
            this.Controls.Add(this.TxtZahl1);
            this.Controls.Add(this.LblZahl2);
            this.Controls.Add(this.LblZahl1);
            this.Name = "Form1";
            this.Text = "Einfacher Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblZahl1;
        private System.Windows.Forms.Label LblZahl2;
        private System.Windows.Forms.TextBox TxtZahl1;
        private System.Windows.Forms.TextBox TxtZahl2;
        private System.Windows.Forms.Label LblResultat;
        private System.Windows.Forms.TextBox TxtResultat;
        private System.Windows.Forms.Button CmdPlus;
        private System.Windows.Forms.Button CmdMinus;
        private System.Windows.Forms.Button CmdMal;
        private System.Windows.Forms.Button CmdDurch;
    }
}

