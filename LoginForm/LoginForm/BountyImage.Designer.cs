namespace LoginForm
{
    partial class BountyImage
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
            this.bountyimage1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bountyimage1)).BeginInit();
            this.SuspendLayout();
            // 
            // bountyimage1
            // 
            this.bountyimage1.Location = new System.Drawing.Point(132, 39);
            this.bountyimage1.Name = "bountyimage1";
            this.bountyimage1.Size = new System.Drawing.Size(382, 346);
            this.bountyimage1.TabIndex = 0;
            this.bountyimage1.TabStop = false;
            this.bountyimage1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // BountyImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bountyimage1);
            this.Name = "BountyImage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bountyimage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bountyimage1;
    }
}