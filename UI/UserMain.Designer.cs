namespace UI
{
    partial class UserMain
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
            archButton1 = new archButton();
            archButton2 = new archButton();
            archButton3 = new archButton();
            archButton4 = new archButton();
            archButton5 = new archButton();
            archButton6 = new archButton();
            SuspendLayout();
            // 
            // archButton1
            // 
            archButton1.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton1.BtnText = null;
            archButton1.IsRoundCorner = true;
            archButton1.Location = new Point(12, 59);
            archButton1.Name = "archButton1";
            archButton1.RoundRadius = 60;
            archButton1.Size = new Size(93, 29);
            archButton1.TabIndex = 0;
            archButton1.TabStop = false;
            archButton1.Text = "账户管理";
            archButton1.UseVisualStyleBackColor = true;
            // 
            // archButton2
            // 
            archButton2.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton2.BtnText = null;
            archButton2.IsRoundCorner = true;
            archButton2.Location = new Point(12, 196);
            archButton2.Name = "archButton2";
            archButton2.RoundRadius = 60;
            archButton2.Size = new Size(93, 29);
            archButton2.TabIndex = 1;
            archButton2.TabStop = false;
            archButton2.Text = "存款";
            archButton2.UseVisualStyleBackColor = true;
            // 
            // archButton3
            // 
            archButton3.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton3.BtnText = null;
            archButton3.IsRoundCorner = true;
            archButton3.Location = new Point(12, 346);
            archButton3.Name = "archButton3";
            archButton3.RoundRadius = 60;
            archButton3.Size = new Size(93, 29);
            archButton3.TabIndex = 2;
            archButton3.TabStop = false;
            archButton3.Text = "取款";
            archButton3.UseVisualStyleBackColor = true;
            archButton3.Click += archButton3_Click;
            // 
            // archButton4
            // 
            archButton4.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton4.BtnText = null;
            archButton4.IsRoundCorner = true;
            archButton4.Location = new Point(695, 59);
            archButton4.Name = "archButton4";
            archButton4.RoundRadius = 60;
            archButton4.Size = new Size(93, 29);
            archButton4.TabIndex = 3;
            archButton4.TabStop = false;
            archButton4.Text = "转账";
            archButton4.UseVisualStyleBackColor = true;
            // 
            // archButton5
            // 
            archButton5.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton5.BtnText = null;
            archButton5.IsRoundCorner = true;
            archButton5.Location = new Point(695, 196);
            archButton5.Name = "archButton5";
            archButton5.RoundRadius = 60;
            archButton5.Size = new Size(93, 29);
            archButton5.TabIndex = 4;
            archButton5.TabStop = false;
            archButton5.Text = "明细";
            archButton5.UseVisualStyleBackColor = true;
            // 
            // archButton6
            // 
            archButton6.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton6.BtnText = null;
            archButton6.IsRoundCorner = true;
            archButton6.Location = new Point(695, 346);
            archButton6.Name = "archButton6";
            archButton6.RoundRadius = 60;
            archButton6.Size = new Size(93, 29);
            archButton6.TabIndex = 5;
            archButton6.TabStop = false;
            archButton6.Text = "修改密码";
            archButton6.UseVisualStyleBackColor = true;
            // 
            // UserMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(archButton6);
            Controls.Add(archButton5);
            Controls.Add(archButton4);
            Controls.Add(archButton3);
            Controls.Add(archButton2);
            Controls.Add(archButton1);
            Name = "UserMain";
            Text = "Form2";
            Load += UserMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private archButton archButton1;
        private archButton archButton2;
        private archButton archButton3;
        private archButton archButton4;
        private archButton archButton5;
        private archButton archButton6;
    }
}