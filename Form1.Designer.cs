namespace Basic_Threading
{
    partial class FrmBasicThread
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
            this.lblYAY = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYAY
            // 
            this.lblYAY.AutoSize = true;
            this.lblYAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYAY.Location = new System.Drawing.Point(27, 31);
            this.lblYAY.Name = "lblYAY";
            this.lblYAY.Size = new System.Drawing.Size(354, 37);
            this.lblYAY.TabIndex = 0;
            this.lblYAY.Text = " -Before starting thread-";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(150, 117);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(104, 39);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "rUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // FrmBasicThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 213);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblYAY);
            this.Name = "FrmBasicThread";
            this.Text = "BasicThread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYAY;
        private System.Windows.Forms.Button btnRun;
    }
}

