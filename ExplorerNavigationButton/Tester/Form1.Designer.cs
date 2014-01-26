namespace Tester
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
            this.explorerNavigationButton2 = new ExplorerNavigationButton.ExplorerNavigationButton();
            this.explorerNavigationButton1 = new ExplorerNavigationButton.ExplorerNavigationButton();
            this.SuspendLayout();
            // 
            // explorerNavigationButton2
            // 
            this.explorerNavigationButton2.ArrowDirection = ExplorerNavigationButton.ArrowDirection.Right;
            this.explorerNavigationButton2.Location = new System.Drawing.Point(145, 72);
            this.explorerNavigationButton2.Name = "explorerNavigationButton2";
            this.explorerNavigationButton2.Size = new System.Drawing.Size(24, 24);
            this.explorerNavigationButton2.TabIndex = 1;
            this.explorerNavigationButton2.Text = "explorerNavigationButton2";
            // 
            // explorerNavigationButton1
            // 
            this.explorerNavigationButton1.Location = new System.Drawing.Point(118, 72);
            this.explorerNavigationButton1.Name = "explorerNavigationButton1";
            this.explorerNavigationButton1.Size = new System.Drawing.Size(24, 24);
            this.explorerNavigationButton1.TabIndex = 0;
            this.explorerNavigationButton1.Text = "explorerNavigationButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 535);
            this.Controls.Add(this.explorerNavigationButton2);
            this.Controls.Add(this.explorerNavigationButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ExplorerNavigationButton.ExplorerNavigationButton explorerNavigationButton1;
        private ExplorerNavigationButton.ExplorerNavigationButton explorerNavigationButton2;

    }
}

