namespace CSharpTimer
{
    partial class CSharpTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblTimer = new Label();
            SuspendLayout();
            // 
            // LblTimer
            // 
            LblTimer.AutoSize = true;
            LblTimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTimer.Location = new Point(136, 45);
            LblTimer.Name = "LblTimer";
            LblTimer.Size = new Size(54, 21);
            LblTimer.TabIndex = 0;
            LblTimer.Text = "Timer";
            // 
            // CSharpTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 117);
            Controls.Add(LblTimer);
            Name = "CSharpTimer";
            Text = "CSharpTimer";
            Load += CSharpTimer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTimer;
    }
}
