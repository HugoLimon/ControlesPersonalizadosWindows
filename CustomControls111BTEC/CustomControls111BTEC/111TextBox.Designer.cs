namespace CustomControls111BTEC
{
    partial class _111TextBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textHolderLabel = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(2, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textHolderLabel
            // 
            this.textHolderLabel.BackColor = System.Drawing.Color.Transparent;
            this.textHolderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textHolderLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textHolderLabel.Location = new System.Drawing.Point(2, 0);
            this.textHolderLabel.Name = "textHolderLabel";
            this.textHolderLabel.Size = new System.Drawing.Size(119, 16);
            this.textHolderLabel.TabIndex = 1;
            this.textHolderLabel.Text = "label1";
            this.textHolderLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // _111TextBox
            // 
            this.Controls.Add(this.textHolderLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "_111TextBox";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Size = new System.Drawing.Size(121, 16);
            this.BackColorChanged += new System.EventHandler(this._111TextBox_BackColorChanged);
            this.ForeColorChanged += new System.EventHandler(this._111TextBox_ForeColorChanged);
            this.Enter += new System.EventHandler(this._111TextBox_Enter);
            this.Leave += new System.EventHandler(this._111TextBox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textHolderLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}
