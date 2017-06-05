namespace FuBaManager
{
    partial class MainMenue
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.NeuesSpiel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NeuesSpiel
            // 
            this.NeuesSpiel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NeuesSpiel.Location = new System.Drawing.Point(460, 175);
            this.NeuesSpiel.Name = "NeuesSpiel";
            this.NeuesSpiel.Size = new System.Drawing.Size(80, 23);
            this.NeuesSpiel.TabIndex = 0;
            this.NeuesSpiel.Text = "Neues Spiel";
            this.NeuesSpiel.UseVisualStyleBackColor = true;
            this.NeuesSpiel.Click += new System.EventHandler(this.NeuesSpiel_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(460, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NeuesSpiel);
            this.Name = "MainMenue";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.MainMenue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NeuesSpiel;
        private System.Windows.Forms.Button button1;
    }
}
