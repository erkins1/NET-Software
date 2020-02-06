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
            this.clearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtblSearchQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtblSearchQuotes
            // 
            this.dtblSearchQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtblSearchQuotes.Location = new System.Drawing.Point(0, 144);
            this.dtblSearchQuotes.Name = "dtblSearchQuotes";
            this.dtblSearchQuotes.Size = new System.Drawing.Size(884, 306);
            this.dtblSearchQuotes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSearchMaterial
            // 
            this.cmbSearchMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchMaterial.FormattingEnabled = true;
            this.cmbSearchMaterial.Location = new System.Drawing.Point(382, 55);
            this.cmbSearchMaterial.Name = "cmbSearchMaterial";
            this.cmbSearchMaterial.Size = new System.Drawing.Size(121, 28);
            this.cmbSearchMaterial.TabIndex = 2;
            this.cmbSearchMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbSearchMaterial_SelectedIndexChanged);
            // 
            // clearSearch
            // 
            this.clearSearch.Location = new System.Drawing.Point(509, 58);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(75, 23);
            this.clearSearch.TabIndex = 3;
            this.clearSearch.Text = "Clear";
            this.clearSearch.UseVisualStyleBackColor = true;
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.cmbSearchMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtblSearchQuotes);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtblSearchQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtblSearchQuotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchMaterial;
        private System.Windows.Forms.Button clearSearch;
    }
}