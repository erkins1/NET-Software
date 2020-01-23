namespace MegaDesk_Rogers
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.numDrawers = new System.Windows.Forms.NumericUpDown();
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbShipping = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depth:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Drawers:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surface Material:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWidth.Location = new System.Drawing.Point(193, 58);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 26);
            this.numWidth.TabIndex = 4;
            // 
            // numDepth
            // 
            this.numDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDepth.Location = new System.Drawing.Point(193, 108);
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(120, 26);
            this.numDepth.TabIndex = 5;
            // 
            // numDrawers
            // 
            this.numDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawers.Location = new System.Drawing.Point(193, 158);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(120, 26);
            this.numDrawers.TabIndex = 6;
            // 
            // cmbMaterialType
            // 
            this.cmbMaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterialType.FormattingEnabled = true;
            this.cmbMaterialType.Location = new System.Drawing.Point(193, 207);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(121, 28);
            this.cmbMaterialType.TabIndex = 7;
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.Location = new System.Drawing.Point(193, 304);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(120, 36);
            this.btnGetQuote.TabIndex = 8;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shipping Speed:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbShipping
            // 
            this.cmbShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShipping.FormattingEnabled = true;
            this.cmbShipping.Location = new System.Drawing.Point(193, 257);
            this.cmbShipping.Name = "cmbShipping";
            this.cmbShipping.Size = new System.Drawing.Size(121, 28);
            this.cmbShipping.TabIndex = 10;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 376);
            this.Controls.Add(this.cmbShipping);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.cmbMaterialType);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numDrawers;
        private System.Windows.Forms.ComboBox cmbMaterialType;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbShipping;
    }
}