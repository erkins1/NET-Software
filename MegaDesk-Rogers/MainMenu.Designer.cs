namespace MegaDesk_Rogers
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnOpenAddQuote = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenViewQuotes = new System.Windows.Forms.Button();
            this.btnOpenSearchQuotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenAddQuote
            // 
            this.btnOpenAddQuote.Location = new System.Drawing.Point(30, 23);
            this.btnOpenAddQuote.Name = "btnOpenAddQuote";
            this.btnOpenAddQuote.Size = new System.Drawing.Size(185, 54);
            this.btnOpenAddQuote.TabIndex = 0;
            this.btnOpenAddQuote.Text = "Add New Quote";
            this.btnOpenAddQuote.UseVisualStyleBackColor = true;
            this.btnOpenAddQuote.Click += new System.EventHandler(this.btnOpenAddQuote_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "MegaDeskImg.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenViewQuotes
            // 
            this.btnOpenViewQuotes.Location = new System.Drawing.Point(30, 102);
            this.btnOpenViewQuotes.Name = "btnOpenViewQuotes";
            this.btnOpenViewQuotes.Size = new System.Drawing.Size(185, 54);
            this.btnOpenViewQuotes.TabIndex = 2;
            this.btnOpenViewQuotes.Text = "View Quotes";
            this.btnOpenViewQuotes.UseVisualStyleBackColor = true;
            // 
            // btnOpenSearchQuotes
            // 
            this.btnOpenSearchQuotes.Location = new System.Drawing.Point(30, 181);
            this.btnOpenSearchQuotes.Name = "btnOpenSearchQuotes";
            this.btnOpenSearchQuotes.Size = new System.Drawing.Size(185, 54);
            this.btnOpenSearchQuotes.TabIndex = 3;
            this.btnOpenSearchQuotes.Text = "Search Quotes";
            this.btnOpenSearchQuotes.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(30, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 54);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 333);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenSearchQuotes);
            this.Controls.Add(this.btnOpenViewQuotes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenAddQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenAddQuote;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenViewQuotes;
        private System.Windows.Forms.Button btnOpenSearchQuotes;
        private System.Windows.Forms.Button btnExit;
    }
}

