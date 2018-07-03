namespace ThreadExampleForm
{
    partial class MainForm
    {
        
 

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
        
            this.btnStart.Location = new System.Drawing.Point(90, 139);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start count";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
         
            this.textBox.Location = new System.Drawing.Point(22, 74);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 20);
            this.textBox.TabIndex = 2;
          
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox);
           
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Thread Example";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox;
    }
}

