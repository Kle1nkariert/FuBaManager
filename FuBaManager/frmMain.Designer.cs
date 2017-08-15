namespace FuBaManager
{
    partial class Main
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
            this.mainMenue1 = new FuBaManager.MainMenue();
            this.zentrale2 = new FuBaManager.Zentrale();
            this.mannschaft11 = new FuBaManager.Mannschaft1();
            this.SuspendLayout();
            // 
            // mainMenue1
            // 
            this.mainMenue1.AutoScroll = true;
            this.mainMenue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenue1.Location = new System.Drawing.Point(0, 0);
            this.mainMenue1.Name = "mainMenue1";
            this.mainMenue1.Size = new System.Drawing.Size(984, 561);
            this.mainMenue1.TabIndex = 0;
            this.mainMenue1.Load += new System.EventHandler(this.mainMenue1_Load_1);
            // 
            // zentrale2
            // 
            this.zentrale2.AutoSize = true;
            this.zentrale2.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.zentrale2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zentrale2.Location = new System.Drawing.Point(0, 0);
            this.zentrale2.Name = "zentrale2";
            this.zentrale2.Size = new System.Drawing.Size(984, 561);
            this.zentrale2.TabIndex = 2;
            // 
            // mannschaft11
            //
            this.mannschaft11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mannschaft11.Location = new System.Drawing.Point(0, 0);
            this.mannschaft11.Name = "mannschaft11";
            this.mannschaft11.Size = new System.Drawing.Size(984, 561);
            this.mannschaft11.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.mannschaft11);
            this.Controls.Add(this.mainMenue1);
            this.Controls.Add(this.zentrale2);
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainMenue mainMenue1;
        private Zentrale zentrale2;
        private Mannschaft1 mannschaft11;
    }
}

