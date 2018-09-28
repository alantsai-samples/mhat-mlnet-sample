namespace MHAT.MLNET.Classifier.IssueLabeler.WinForm
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
            this.lblModelPath = new System.Windows.Forms.Label();
            this.txtModelPath = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtboxDescription = new System.Windows.Forms.RichTextBox();
            this.btnPredic = new System.Windows.Forms.Button();
            this.lblPredict = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModelPath
            // 
            this.lblModelPath.AutoSize = true;
            this.lblModelPath.Location = new System.Drawing.Point(36, 24);
            this.lblModelPath.Name = "lblModelPath";
            this.lblModelPath.Size = new System.Drawing.Size(89, 18);
            this.lblModelPath.TabIndex = 0;
            this.lblModelPath.Text = "Model路徑";
            // 
            // txtModelPath
            // 
            this.txtModelPath.Location = new System.Drawing.Point(141, 21);
            this.txtModelPath.Name = "txtModelPath";
            this.txtModelPath.Size = new System.Drawing.Size(501, 28);
            this.txtModelPath.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(36, 99);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "標題";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(141, 89);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(501, 28);
            this.txtTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(36, 162);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(44, 18);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "描述";
            // 
            // rtxtboxDescription
            // 
            this.rtxtboxDescription.Location = new System.Drawing.Point(141, 159);
            this.rtxtboxDescription.Name = "rtxtboxDescription";
            this.rtxtboxDescription.Size = new System.Drawing.Size(501, 213);
            this.rtxtboxDescription.TabIndex = 2;
            this.rtxtboxDescription.Text = "";
            // 
            // btnPredic
            // 
            this.btnPredic.Location = new System.Drawing.Point(529, 389);
            this.btnPredic.Name = "btnPredic";
            this.btnPredic.Size = new System.Drawing.Size(113, 49);
            this.btnPredic.TabIndex = 3;
            this.btnPredic.Text = "預測";
            this.btnPredic.UseVisualStyleBackColor = true;
            this.btnPredic.Click += new System.EventHandler(this.btnPredic_Click);
            // 
            // lblPredict
            // 
            this.lblPredict.AutoSize = true;
            this.lblPredict.Location = new System.Drawing.Point(36, 389);
            this.lblPredict.Name = "lblPredict";
            this.lblPredict.Size = new System.Drawing.Size(152, 18);
            this.lblPredict.TabIndex = 0;
            this.lblPredict.Text = "<Issue預測Label>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPredic);
            this.Controls.Add(this.rtxtboxDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtModelPath);
            this.Controls.Add(this.lblPredict);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblModelPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelPath;
        private System.Windows.Forms.TextBox txtModelPath;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtxtboxDescription;
        private System.Windows.Forms.Button btnPredic;
        private System.Windows.Forms.Label lblPredict;
    }
}

