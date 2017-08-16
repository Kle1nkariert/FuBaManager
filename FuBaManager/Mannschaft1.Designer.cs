namespace FuBaManager
{
    partial class Mannschaft1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Att = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Zentrale_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nachname,
            this.Vorname,
            this.Att,
            this.Deff});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(557, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Resize += new System.EventHandler(this.dataGridView1_Resize);
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            this.Nachname.ReadOnly = true;
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.Name = "Vorname";
            this.Vorname.ReadOnly = true;
            // 
            // Att
            // 
            this.Att.HeaderText = "Att";
            this.Att.Name = "Att";
            this.Att.ReadOnly = true;
            // 
            // Deff
            // 
            this.Deff.HeaderText = "Deff";
            this.Deff.Name = "Deff";
            this.Deff.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Zentrale_Button
            // 
            this.Zentrale_Button.Location = new System.Drawing.Point(4, 0);
            this.Zentrale_Button.Name = "Zentrale_Button";
            this.Zentrale_Button.Size = new System.Drawing.Size(75, 23);
            this.Zentrale_Button.TabIndex = 1;
            this.Zentrale_Button.Text = "Zentrale";
            this.Zentrale_Button.UseVisualStyleBackColor = true;
            this.Zentrale_Button.Click += new System.EventHandler(this.Zentrale_Click);
            // 
            // Mannschaft1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Zentrale_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mannschaft1";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.Mannschaft1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Att;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deff;
        private System.Windows.Forms.Button Zentrale_Button;
    }
}
