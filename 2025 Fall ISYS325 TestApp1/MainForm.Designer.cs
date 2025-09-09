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
            picChangedCar = new PictureBox();
            txtTest = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picChangedCar).BeginInit();
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
            lblHelloWorld.BorderStyle = BorderStyle.FixedSingle;
            lblHelloWorld.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHelloWorld.Location = new Point(36, 21);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(370, 69);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "this is a";
            lblHelloWorld.TextAlign = ContentAlignment.MiddleCenter;
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
            // picChangedCar
            // 
            picChangedCar.ImageLocation = "C:\\Users\\bray_\\Downloads\\Bluecar.png";
            picChangedCar.Location = new Point(32, 130);
            picChangedCar.Name = "picChangedCar";
            picChangedCar.Size = new Size(330, 119);
            picChangedCar.TabIndex = 3;
            picChangedCar.TabStop = false;
            picChangedCar.Click += picBlueCar_Click;
            // 
            // txtTest
            // 
            txtTest.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTest.Location = new Point(726, 83);
            txtTest.Multiline = true;
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(316, 76);
            txtTest.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 21);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 4;
            label1.Text = "&Age";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 450);
            Controls.Add(label1);
            Controls.Add(txtTest);
            Controls.Add(picChangedCar);
            Controls.Add(btnClose);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnPushMe);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)picChangedCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPushMe;
        private Label lblHelloWorld;
        private Button btnClose;
        private PictureBox picChangedCar;
        private TextBox txtTest;
        private Label label1;
    }
}
