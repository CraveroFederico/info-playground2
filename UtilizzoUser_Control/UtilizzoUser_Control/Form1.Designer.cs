namespace UtilizzoUser_Control
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMiaTextBox = new User_Control.UserControlTextBox();
            this.chkNumeri = new System.Windows.Forms.CheckBox();
            this.numCifreDecimali = new System.Windows.Forms.NumericUpDown();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnPulisci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCifreDecimali)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMiaTextBox
            // 
            this.txtMiaTextBox.CifreDecimali = 0;
            this.txtMiaTextBox.Location = new System.Drawing.Point(103, 12);
            this.txtMiaTextBox.Name = "txtMiaTextBox";
            this.txtMiaTextBox.Numero = false;
            this.txtMiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.txtMiaTextBox.TabIndex = 0;
            this.txtMiaTextBox.Testo = "";
            // 
            // chkNumeri
            // 
            this.chkNumeri.AutoSize = true;
            this.chkNumeri.Location = new System.Drawing.Point(28, 72);
            this.chkNumeri.Name = "chkNumeri";
            this.chkNumeri.Size = new System.Drawing.Size(121, 17);
            this.chkNumeri.TabIndex = 1;
            this.chkNumeri.Text = "Accetta solo Numeri";
            this.chkNumeri.UseVisualStyleBackColor = true;
            this.chkNumeri.CheckedChanged += new System.EventHandler(this.chkNumeri_CheckedChanged);
            // 
            // numCifreDecimali
            // 
            this.numCifreDecimali.Location = new System.Drawing.Point(208, 69);
            this.numCifreDecimali.Name = "numCifreDecimali";
            this.numCifreDecimali.Size = new System.Drawing.Size(42, 20);
            this.numCifreDecimali.TabIndex = 2;
            this.numCifreDecimali.ValueChanged += new System.EventHandler(this.numCifreDecimali_ValueChanged);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(65, 120);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 3;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(156, 120);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(75, 23);
            this.btnPulisci.TabIndex = 4;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 158);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.numCifreDecimali);
            this.Controls.Add(this.chkNumeri);
            this.Controls.Add(this.txtMiaTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCifreDecimali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Control.UserControlTextBox txtMiaTextBox;
        private System.Windows.Forms.CheckBox chkNumeri;
        private System.Windows.Forms.NumericUpDown numCifreDecimali;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnPulisci;
    }
}

