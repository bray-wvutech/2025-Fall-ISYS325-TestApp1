namespace _2025_Fall_ISYS325_TestApp1
{
    partial class Form1
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
            btnPushMe = new Button();
            SuspendLayout();
            // 
            // btnPushMe
            // 
            btnPushMe.Location = new Point(188, 80);
            btnPushMe.Name = "btnPushMe";
            btnPushMe.Size = new Size(239, 110);
            btnPushMe.TabIndex = 0;
            btnPushMe.Text = "&Push && Me";
            btnPushMe.UseVisualStyleBackColor = true;
            btnPushMe.Click += btnPushMe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPushMe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPushMe;
    }
}
