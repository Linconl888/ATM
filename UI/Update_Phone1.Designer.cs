namespace UI
{
    partial class Update_Phone1
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
            textBox2 = new TextBox();
            label2 = new Label();
            Next_Step = new archButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 105);
            label1.Name = "label1";
            label1.Size = new Size(243, 28);
            label1.TabIndex = 0;
            label1.Text = "请插入需更新的银行卡：";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(291, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(291, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 34);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 183);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 3;
            label2.Text = "请输入密码：";
            // 
            // Next_Step
            // 
            Next_Step.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Next_Step.BtnText = null;
            Next_Step.IsRoundCorner = true;
            Next_Step.Location = new Point(615, 372);
            Next_Step.Name = "Next_Step";
            Next_Step.RoundRadius = 60;
            Next_Step.Size = new Size(175, 66);
            Next_Step.TabIndex = 4;
            Next_Step.TabStop = false;
            Next_Step.Text = "下一步";
            Next_Step.UseVisualStyleBackColor = true;
            Next_Step.Click += Next_Step_Click;
            // 
            // Update_Phone1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Next_Step);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Update_Phone1";
            Text = "Update_Phone1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private archButton Next_Step;
    }
}