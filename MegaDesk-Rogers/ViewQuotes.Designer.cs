﻿namespace MegaDesk_Rogers
{
    partial class ViewQuotes
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
            this.dtblViewQuotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtblViewQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtblViewQuotes
            // 
            this.dtblViewQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtblViewQuotes.Location = new System.Drawing.Point(0, 0);
            this.dtblViewQuotes.Name = "dtblViewQuotes";
            this.dtblViewQuotes.Size = new System.Drawing.Size(800, 450);
            this.dtblViewQuotes.TabIndex = 0;
            // 
            // ViewQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtblViewQuotes);
            this.Name = "ViewQuotes";
            this.Text = "ViewQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewQuotes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtblViewQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtblViewQuotes;
    }
}