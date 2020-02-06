namespace MegaDesk_Rogers
{
    partial class SearchQuotes
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
            this.dtblSearchQuotes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchMaterial = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtblSearchQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtblSearchQuotes
            // 
            this.dtblSearchQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtblSearchQuotes.Location = new System.Drawing.Point(0, 144);
            this.dtblSearchQuotes.Name = "dtblSearchQuotes";
            this.dtblSearchQuotes.Size = new System.Drawing.Size(800, 306);
            this.dtblSearchQuotes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSearchMaterial
            // 
            this.cmbSearchMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchMaterial.FormattingEnabled = true;
            this.cmbSearchMaterial.Location = new System.Drawing.Point(401, 63);
            this.cmbSearchMaterial.Name = "cmbSearchMaterial";
            this.cmbSearchMaterial.Size = new System.Drawing.Size(121, 28);
            this.cmbSearchMaterial.TabIndex = 2;
            this.cmbSearchMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbSearchMaterial_SelectedIndexChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSearchMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtblSearchQuotes);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dtblSearchQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtblSearchQuotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchMaterial;
    }
}