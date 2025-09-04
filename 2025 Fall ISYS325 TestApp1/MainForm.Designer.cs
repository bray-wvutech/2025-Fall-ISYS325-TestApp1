namespace _2025_Fall_ISYS325_TestApp1
{
    partial class MainForm
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
            lblHelloWorld = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnPushMe
            // 
            btnPushMe.Location = new Point(280, 255);
            btnPushMe.Name = "btnPushMe";
            btnPushMe.Size = new Size(239, 110);
            btnPushMe.TabIndex = 0;
            btnPushMe.Text = "&Push && Me";
            btnPushMe.UseVisualStyleBackColor = true;
            btnPushMe.Click += btnPushMe_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHelloWorld.Location = new Point(174, 70);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(116, 37);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "label1";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(560, 112);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnPushMe);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPushMe;
        private Label lblHelloWorld;
        private Button btnClose;
    }
}
