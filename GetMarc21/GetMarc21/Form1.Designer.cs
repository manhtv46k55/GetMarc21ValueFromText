namespace GetMarc21
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
            this.btnRun = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.rtbResult2 = new System.Windows.Forms.RichTextBox();
            this.rtbInput2 = new System.Windows.Forms.RichTextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(713, 131);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(141, 70);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Get";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(65, 40);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(601, 278);
            this.rtbInput.TabIndex = 1;
            this.rtbInput.Text = "";
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(909, 40);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(601, 278);
            this.rtbResult.TabIndex = 2;
            this.rtbResult.Text = "";
            // 
            // rtbResult2
            // 
            this.rtbResult2.Location = new System.Drawing.Point(909, 408);
            this.rtbResult2.Name = "rtbResult2";
            this.rtbResult2.Size = new System.Drawing.Size(601, 278);
            this.rtbResult2.TabIndex = 5;
            this.rtbResult2.Text = "";
            // 
            // rtbInput2
            // 
            this.rtbInput2.Location = new System.Drawing.Point(65, 408);
            this.rtbInput2.Name = "rtbInput2";
            this.rtbInput2.Size = new System.Drawing.Size(601, 278);
            this.rtbInput2.TabIndex = 4;
            this.rtbInput2.Text = "";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(713, 499);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(141, 70);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort Value";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 779);
            this.Controls.Add(this.rtbResult2);
            this.Controls.Add(this.rtbInput2);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.RichTextBox rtbResult2;
        private System.Windows.Forms.RichTextBox rtbInput2;
        private System.Windows.Forms.Button btnSort;
    }
}

