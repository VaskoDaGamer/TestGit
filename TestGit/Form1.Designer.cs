
namespace TestGit
{
    partial class frmGitTest
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
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(152, 546);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(154, 61);
            this.btnSqrt.TabIndex = 1;
            this.btnSqrt.Text = "Compute Square root";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(371, 546);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(154, 61);
            this.btnPower.TabIndex = 2;
            this.btnPower.Text = "Compute Power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(163, 694);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(105, 25);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "lblAnswer";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(168, 282);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(285, 31);
            this.txtInput.TabIndex = 4;
            // 
            // frmGitTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 890);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSqrt);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmGitTest";
            this.Text = "Git Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtInput;
    }
}

