namespace qvogl2Project3FormsDatabase
{
    partial class frmSize
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
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(23, 12);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 23);
            this.btnSmall.TabIndex = 0;
            this.btnSmall.Text = "Small";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(23, 42);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(23, 71);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(75, 23);
            this.btnLarge.TabIndex = 2;
            this.btnLarge.Text = "Large";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 106);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnSmall);
            this.Name = "frmSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSize";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnLarge;
    }
}