namespace Texteingabefelder
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
            this.TxtVorname = new System.Windows.Forms.TextBox();
            this.LblVorname = new System.Windows.Forms.Label();
            this.LblNachname = new System.Windows.Forms.Label();
            this.TxtNachname = new System.Windows.Forms.TextBox();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.BtmAusgeben = new System.Windows.Forms.Button();
            this.BtmLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtVorname
            // 
            this.TxtVorname.Location = new System.Drawing.Point(202, 59);
            this.TxtVorname.Name = "TxtVorname";
            this.TxtVorname.Size = new System.Drawing.Size(251, 26);
            this.TxtVorname.TabIndex = 0;
            // 
            // LblVorname
            // 
            this.LblVorname.AutoSize = true;
            this.LblVorname.Location = new System.Drawing.Point(57, 65);
            this.LblVorname.Name = "LblVorname";
            this.LblVorname.Size = new System.Drawing.Size(78, 20);
            this.LblVorname.TabIndex = 1;
            this.LblVorname.Text = "Vorname:";
            // 
            // LblNachname
            // 
            this.LblNachname.AutoSize = true;
            this.LblNachname.Location = new System.Drawing.Point(57, 120);
            this.LblNachname.Name = "LblNachname";
            this.LblNachname.Size = new System.Drawing.Size(90, 20);
            this.LblNachname.TabIndex = 1;
            this.LblNachname.Text = "Nachname:";
            this.LblNachname.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNachname
            // 
            this.TxtNachname.Location = new System.Drawing.Point(202, 114);
            this.TxtNachname.Multiline = true;
            this.TxtNachname.Name = "TxtNachname";
            this.TxtNachname.Size = new System.Drawing.Size(251, 26);
            this.TxtNachname.TabIndex = 0;
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(114, 320);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(21, 20);
            this.LblAusgabe.TabIndex = 2;
            this.LblAusgabe.Text = "...";
            // 
            // BtmAusgeben
            // 
            this.BtmAusgeben.Location = new System.Drawing.Point(105, 227);
            this.BtmAusgeben.Name = "BtmAusgeben";
            this.BtmAusgeben.Size = new System.Drawing.Size(147, 49);
            this.BtmAusgeben.TabIndex = 3;
            this.BtmAusgeben.Text = "Ausgeben";
            this.BtmAusgeben.UseVisualStyleBackColor = true;
            this.BtmAusgeben.Click += new System.EventHandler(this.BtmAusgeben_Click);
            // 
            // BtmLoeschen
            // 
            this.BtmLoeschen.Location = new System.Drawing.Point(346, 227);
            this.BtmLoeschen.Name = "BtmLoeschen";
            this.BtmLoeschen.Size = new System.Drawing.Size(147, 49);
            this.BtmLoeschen.TabIndex = 3;
            this.BtmLoeschen.Text = "Löschen";
            this.BtmLoeschen.UseVisualStyleBackColor = true;
            this.BtmLoeschen.Click += new System.EventHandler(this.BtmLoeschen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 363);
            this.Controls.Add(this.BtmLoeschen);
            this.Controls.Add(this.BtmAusgeben);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.LblNachname);
            this.Controls.Add(this.LblVorname);
            this.Controls.Add(this.TxtNachname);
            this.Controls.Add(this.TxtVorname);
            this.Name = "Form1";
            this.Text = "Beispiel Textfeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtVorname;
        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.Label LblNachname;
        private System.Windows.Forms.TextBox TxtNachname;
        private System.Windows.Forms.Label LblAusgabe;
        private System.Windows.Forms.Button BtmAusgeben;
        private System.Windows.Forms.Button BtmLoeschen;
    }
}

