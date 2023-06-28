namespace UI
{
    partial class Withdraw_Money
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
            label1 = new Label();
            textBox1 = new TextBox();
            archButton1 = new archButton();
            archButton2 = new archButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 63);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "需要取款金额：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 27);
            textBox1.TabIndex = 1;
            // 
            // archButton1
            // 
            archButton1.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton1.BtnText = null;
            archButton1.IsRoundCorner = true;
            archButton1.Location = new Point(362, 110);
            archButton1.Name = "archButton1";
            archButton1.RoundRadius = 60;
            archButton1.Size = new Size(93, 29);
            archButton1.TabIndex = 2;
            archButton1.TabStop = false;
            archButton1.Text = "确认取款";
            archButton1.UseVisualStyleBackColor = true;
            archButton1.Click += archButton1_Click;
            // 
            // archButton2
            // 
            archButton2.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton2.BtnText = null;
            archButton2.IsRoundCorner = true;
            archButton2.Location = new Point(389, 220);
            archButton2.Name = "archButton2";
            archButton2.RoundRadius = 60;
            archButton2.Size = new Size(93, 36);
            archButton2.TabIndex = 3;
            archButton2.TabStop = false;
            archButton2.Text = "返回";
            archButton2.UseVisualStyleBackColor = true;
            archButton2.Click += archButton2_Click;
            // 
            // Withdraw_Money
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 257);
            Controls.Add(archButton2);
            Controls.Add(archButton1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Withdraw_Money";
            Text = "Withdraw_Money";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private archButton archButton1;
        private archButton archButton2;
    }
}