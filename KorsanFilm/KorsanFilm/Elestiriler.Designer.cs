namespace KorsanFilm
{
    partial class Elestiriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvElestiri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElestiri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElestiri
            // 
            this.dgvElestiri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElestiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElestiri.Location = new System.Drawing.Point(20, 127);
            this.dgvElestiri.Name = "dgvElestiri";
            this.dgvElestiri.Size = new System.Drawing.Size(498, 268);
            this.dgvElestiri.TabIndex = 0;
            // 
            // Elestiriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 407);
            this.Controls.Add(this.dgvElestiri);
            this.Name = "Elestiriler";
            this.Text = "Elestiriler";
            this.Load += new System.EventHandler(this.Elestiriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElestiri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElestiri;
    }
}