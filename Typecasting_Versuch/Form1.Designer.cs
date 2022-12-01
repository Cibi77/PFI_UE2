namespace Typecasting_Versuch
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
            this.CmdCalculate = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdCalculate
            // 
            this.CmdCalculate.Location = new System.Drawing.Point(192, 145);
            this.CmdCalculate.Name = "CmdCalculate";
            this.CmdCalculate.Size = new System.Drawing.Size(117, 34);
            this.CmdCalculate.TabIndex = 0;
            this.CmdCalculate.Text = "Berechnen";
            this.CmdCalculate.UseVisualStyleBackColor = true;
            this.CmdCalculate.Click += new System.EventHandler(this.CmdCalculate_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(192, 223);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(281, 26);
            this.TxtResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.CmdCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdCalculate;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

