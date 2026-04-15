namespace KuhaKaon3
{
    partial class Form2
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
            this.registerPNL = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordTBX = new System.Windows.Forms.TextBox();
            this.usernameTBX = new System.Windows.Forms.TextBox();
            this.buttonsPNL = new System.Windows.Forms.Panel();
            this.registerBT = new System.Windows.Forms.Button();
            this.cartBT = new System.Windows.Forms.Button();
            this.homeBT = new System.Windows.Forms.Button();
            this.logoPC = new System.Windows.Forms.PictureBox();
            this.registerPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.buttonsPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPC)).BeginInit();
            this.SuspendLayout();
            // 
            // registerPNL
            // 
            this.registerPNL.Controls.Add(this.pictureBox2);
            this.registerPNL.Controls.Add(this.pictureBox1);
            this.registerPNL.Controls.Add(this.label1);
            this.registerPNL.Controls.Add(this.button1);
            this.registerPNL.Controls.Add(this.passwordTBX);
            this.registerPNL.Controls.Add(this.usernameTBX);
            this.registerPNL.Location = new System.Drawing.Point(434, 152);
            this.registerPNL.Name = "registerPNL";
            this.registerPNL.Size = new System.Drawing.Size(395, 368);
            this.registerPNL.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(43, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log - In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "loginBT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordTBX
            // 
            this.passwordTBX.Location = new System.Drawing.Point(43, 165);
            this.passwordTBX.Name = "passwordTBX";
            this.passwordTBX.Size = new System.Drawing.Size(305, 22);
            this.passwordTBX.TabIndex = 1;
            // 
            // usernameTBX
            // 
            this.usernameTBX.Location = new System.Drawing.Point(43, 124);
            this.usernameTBX.Name = "usernameTBX";
            this.usernameTBX.Size = new System.Drawing.Size(305, 22);
            this.usernameTBX.TabIndex = 0;
            // 
            // buttonsPNL
            // 
            this.buttonsPNL.Controls.Add(this.registerBT);
            this.buttonsPNL.Controls.Add(this.cartBT);
            this.buttonsPNL.Controls.Add(this.homeBT);
            this.buttonsPNL.Location = new System.Drawing.Point(950, 39);
            this.buttonsPNL.Name = "buttonsPNL";
            this.buttonsPNL.Size = new System.Drawing.Size(281, 61);
            this.buttonsPNL.TabIndex = 3;
            // 
            // registerBT
            // 
            this.registerBT.Location = new System.Drawing.Point(214, 0);
            this.registerBT.Name = "registerBT";
            this.registerBT.Size = new System.Drawing.Size(67, 59);
            this.registerBT.TabIndex = 2;
            this.registerBT.Text = "Register";
            this.registerBT.UseVisualStyleBackColor = true;
            // 
            // cartBT
            // 
            this.cartBT.Location = new System.Drawing.Point(107, 1);
            this.cartBT.Name = "cartBT";
            this.cartBT.Size = new System.Drawing.Size(67, 59);
            this.cartBT.TabIndex = 1;
            this.cartBT.Text = "Cart";
            this.cartBT.UseVisualStyleBackColor = true;
            // 
            // homeBT
            // 
            this.homeBT.Location = new System.Drawing.Point(0, 0);
            this.homeBT.Name = "homeBT";
            this.homeBT.Size = new System.Drawing.Size(67, 59);
            this.homeBT.TabIndex = 0;
            this.homeBT.Text = "Home";
            this.homeBT.UseVisualStyleBackColor = true;
            // 
            // logoPC
            // 
            this.logoPC.Location = new System.Drawing.Point(26, 26);
            this.logoPC.Name = "logoPC";
            this.logoPC.Size = new System.Drawing.Size(145, 74);
            this.logoPC.TabIndex = 7;
            this.logoPC.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.logoPC);
            this.Controls.Add(this.buttonsPNL);
            this.Controls.Add(this.registerPNL);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form2";
            this.Text = "Form2";
            this.registerPNL.ResumeLayout(false);
            this.registerPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.buttonsPNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerPNL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordTBX;
        private System.Windows.Forms.TextBox usernameTBX;
        private System.Windows.Forms.Panel buttonsPNL;
        private System.Windows.Forms.Button registerBT;
        private System.Windows.Forms.Button cartBT;
        private System.Windows.Forms.Button homeBT;
        private System.Windows.Forms.PictureBox logoPC;
    }
}