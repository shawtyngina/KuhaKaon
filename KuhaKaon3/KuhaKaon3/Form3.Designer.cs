namespace KuhaKaon3
{
    partial class Form3
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
            this.buttonsPNL = new System.Windows.Forms.Panel();
            this.registerBT = new System.Windows.Forms.Button();
            this.cartBT = new System.Windows.Forms.Button();
            this.homeBT = new System.Windows.Forms.Button();
            this.logoPC = new System.Windows.Forms.PictureBox();
            this.searchPNL = new System.Windows.Forms.Panel();
            this.welcomeTX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPC)).BeginInit();
            this.searchPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPNL
            // 
            this.buttonsPNL.Controls.Add(this.registerBT);
            this.buttonsPNL.Controls.Add(this.cartBT);
            this.buttonsPNL.Controls.Add(this.homeBT);
            this.buttonsPNL.Location = new System.Drawing.Point(950, 39);
            this.buttonsPNL.Name = "buttonsPNL";
            this.buttonsPNL.Size = new System.Drawing.Size(281, 61);
            this.buttonsPNL.TabIndex = 4;
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
            // searchPNL
            // 
            this.searchPNL.Controls.Add(this.label1);
            this.searchPNL.Controls.Add(this.welcomeTX);
            this.searchPNL.Location = new System.Drawing.Point(26, 127);
            this.searchPNL.Name = "searchPNL";
            this.searchPNL.Size = new System.Drawing.Size(291, 405);
            this.searchPNL.TabIndex = 8;
            // 
            // welcomeTX
            // 
            this.welcomeTX.AutoSize = true;
            this.welcomeTX.Location = new System.Drawing.Point(17, 103);
            this.welcomeTX.Name = "welcomeTX";
            this.welcomeTX.Size = new System.Drawing.Size(101, 16);
            this.welcomeTX.TabIndex = 9;
            this.welcomeTX.Text = "Welcome back,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Where should we deliver your food today?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.searchPNL);
            this.Controls.Add(this.logoPC);
            this.Controls.Add(this.buttonsPNL);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form3";
            this.Text = "Form3";
            this.buttonsPNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPC)).EndInit();
            this.searchPNL.ResumeLayout(false);
            this.searchPNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPNL;
        private System.Windows.Forms.Button registerBT;
        private System.Windows.Forms.Button cartBT;
        private System.Windows.Forms.Button homeBT;
        private System.Windows.Forms.PictureBox logoPC;
        private System.Windows.Forms.Panel searchPNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeTX;
    }
}