namespace _2017._05._12_Tris
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
            this.dgvCampo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCampo
            // 
            this.dgvCampo.AllowUserToAddRows = false;
            this.dgvCampo.AllowUserToDeleteRows = false;
            this.dgvCampo.AllowUserToResizeColumns = false;
            this.dgvCampo.AllowUserToResizeRows = false;
            this.dgvCampo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCampo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampo.Location = new System.Drawing.Point(66, 59);
            this.dgvCampo.Name = "dgvCampo";
            this.dgvCampo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCampo.Size = new System.Drawing.Size(400, 400);
            this.dgvCampo.TabIndex = 0;
            this.dgvCampo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampo_CellClick);
            this.dgvCampo.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCampo_CellPainting);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "RIAVVIA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCampo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCampo;
        private System.Windows.Forms.Button button1;
    }
}

