
namespace pryBaseDeDatos
{
    partial class frmMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConexiòn = new System.Windows.Forms.Button();
            this.LBLdATOS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConexiòn
            // 
            this.btnConexiòn.Location = new System.Drawing.Point(126, 37);
            this.btnConexiòn.Name = "btnConexiòn";
            this.btnConexiòn.Size = new System.Drawing.Size(247, 72);
            this.btnConexiòn.TabIndex = 0;
            this.btnConexiòn.Text = "Conectar a BD";
            this.btnConexiòn.UseVisualStyleBackColor = true;
            this.btnConexiòn.Click += new System.EventHandler(this.btnConexiòn_Click);
            // 
            // LBLdATOS
            // 
            this.LBLdATOS.Location = new System.Drawing.Point(12, 112);
            this.LBLdATOS.Name = "LBLdATOS";
            this.LBLdATOS.Size = new System.Drawing.Size(580, 247);
            this.LBLdATOS.TabIndex = 1;
            this.LBLdATOS.Text = "label1";
            this.LBLdATOS.Click += new System.EventHandler(this.LBLdATOS_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 368);
            this.Controls.Add(this.LBLdATOS);
            this.Controls.Add(this.btnConexiòn);
            this.Name = "frmMain";
            this.Text = "Conexiòn a BD";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConexiòn;
        private System.Windows.Forms.Label LBLdATOS;
    }
}

