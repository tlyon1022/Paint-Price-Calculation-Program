namespace Program1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lengthLbl = new System.Windows.Forms.Label();
            this.doorLbl = new System.Windows.Forms.Label();
            this.windowLbl = new System.Windows.Forms.Label();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.doorTxt = new System.Windows.Forms.TextBox();
            this.windowTxt = new System.Windows.Forms.TextBox();
            this.outputExact = new System.Windows.Forms.Label();
            this.outputRec = new System.Windows.Forms.Label();
            this.exactLbl = new System.Windows.Forms.Label();
            this.recLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.heightLbl = new System.Windows.Forms.Label();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.coatsLbl = new System.Windows.Forms.Label();
            this.coatsTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lengthLbl
            // 
            this.lengthLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lengthLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthLbl.Location = new System.Drawing.Point(12, 9);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(168, 23);
            this.lengthLbl.TabIndex = 0;
            this.lengthLbl.Text = "Enter Total Length (ft) of Walls:";
            this.lengthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doorLbl
            // 
            this.doorLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doorLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doorLbl.Location = new System.Drawing.Point(12, 95);
            this.doorLbl.Name = "doorLbl";
            this.doorLbl.Size = new System.Drawing.Size(168, 23);
            this.doorLbl.TabIndex = 1;
            this.doorLbl.Text = "Enter Total Number of Doors:";
            this.doorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windowLbl
            // 
            this.windowLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.windowLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windowLbl.Location = new System.Drawing.Point(12, 142);
            this.windowLbl.Name = "windowLbl";
            this.windowLbl.Size = new System.Drawing.Size(168, 23);
            this.windowLbl.TabIndex = 2;
            this.windowLbl.Text = "Enter Total Number of Windows:";
            this.windowLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthTxt
            // 
            this.lengthTxt.Location = new System.Drawing.Point(219, 9);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(100, 20);
            this.lengthTxt.TabIndex = 0;
            this.lengthTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // doorTxt
            // 
            this.doorTxt.Location = new System.Drawing.Point(219, 95);
            this.doorTxt.Name = "doorTxt";
            this.doorTxt.Size = new System.Drawing.Size(100, 20);
            this.doorTxt.TabIndex = 2;
            this.doorTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // windowTxt
            // 
            this.windowTxt.Location = new System.Drawing.Point(219, 142);
            this.windowTxt.Name = "windowTxt";
            this.windowTxt.Size = new System.Drawing.Size(100, 20);
            this.windowTxt.TabIndex = 3;
            this.windowTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputExact
            // 
            this.outputExact.BackColor = System.Drawing.SystemColors.Info;
            this.outputExact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputExact.Location = new System.Drawing.Point(216, 295);
            this.outputExact.Name = "outputExact";
            this.outputExact.Size = new System.Drawing.Size(100, 23);
            this.outputExact.TabIndex = 6;
            // 
            // outputRec
            // 
            this.outputRec.BackColor = System.Drawing.SystemColors.Info;
            this.outputRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputRec.Location = new System.Drawing.Point(216, 336);
            this.outputRec.Name = "outputRec";
            this.outputRec.Size = new System.Drawing.Size(100, 23);
            this.outputRec.TabIndex = 7;
            // 
            // exactLbl
            // 
            this.exactLbl.AutoSize = true;
            this.exactLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exactLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exactLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.exactLbl.Location = new System.Drawing.Point(58, 295);
            this.exactLbl.Name = "exactLbl";
            this.exactLbl.Size = new System.Drawing.Size(101, 15);
            this.exactLbl.TabIndex = 8;
            this.exactLbl.Text = "Amount Necessary:";
            // 
            // recLbl
            // 
            this.recLbl.AutoSize = true;
            this.recLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.recLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.recLbl.Location = new System.Drawing.Point(58, 344);
            this.recLbl.Name = "recLbl";
            this.recLbl.Size = new System.Drawing.Size(132, 15);
            this.recLbl.TabIndex = 9;
            this.recLbl.Text = "Recommended Purchase:";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(216, 234);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clrBtn.Location = new System.Drawing.Point(331, 234);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 5;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // heightLbl
            // 
            this.heightLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.heightLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightLbl.Location = new System.Drawing.Point(12, 51);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(168, 23);
            this.heightLbl.TabIndex = 12;
            this.heightLbl.Text = "Enter Height (ft) of Walls:";
            this.heightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(219, 51);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(100, 20);
            this.heightTxt.TabIndex = 1;
            this.heightTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coatsLbl
            // 
            this.coatsLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.coatsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coatsLbl.Location = new System.Drawing.Point(12, 185);
            this.coatsLbl.Name = "coatsLbl";
            this.coatsLbl.Size = new System.Drawing.Size(168, 23);
            this.coatsLbl.TabIndex = 14;
            this.coatsLbl.Text = "Enter Number of Coats:";
            this.coatsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coatsTxt
            // 
            this.coatsTxt.Location = new System.Drawing.Point(219, 188);
            this.coatsTxt.Name = "coatsTxt";
            this.coatsTxt.Size = new System.Drawing.Size(100, 20);
            this.coatsTxt.TabIndex = 4;
            this.coatsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightYellow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clrBtn;
            this.ClientSize = new System.Drawing.Size(536, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coatsTxt);
            this.Controls.Add(this.coatsLbl);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.recLbl);
            this.Controls.Add(this.exactLbl);
            this.Controls.Add(this.outputRec);
            this.Controls.Add(this.outputExact);
            this.Controls.Add(this.windowTxt);
            this.Controls.Add(this.doorTxt);
            this.Controls.Add(this.lengthTxt);
            this.Controls.Add(this.windowLbl);
            this.Controls.Add(this.doorLbl);
            this.Controls.Add(this.lengthLbl);
            this.Name = "Form1";
            this.Text = "Paint Guide";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Label doorLbl;
        private System.Windows.Forms.Label windowLbl;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.TextBox doorTxt;
        private System.Windows.Forms.TextBox windowTxt;
        private System.Windows.Forms.Label outputExact;
        private System.Windows.Forms.Label outputRec;
        private System.Windows.Forms.Label exactLbl;
        private System.Windows.Forms.Label recLbl;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.Label coatsLbl;
        private System.Windows.Forms.TextBox coatsTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

