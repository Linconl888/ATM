namespace UI
{
    partial class Update_IdCard
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
            Return_Button = new archButton();
            Next_Step = new archButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Return_Button
            // 
            Return_Button.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Return_Button.BtnText = null;
            Return_Button.IsRoundCorner = true;
            Return_Button.Location = new Point(12, 328);
            Return_Button.Name = "Return_Button";
            Return_Button.RoundRadius = 60;
            Return_Button.Size = new Size(178, 68);
            Return_Button.TabIndex = 0;
            Return_Button.TabStop = false;
            Return_Button.Text = "返回";
            Return_Button.UseVisualStyleBackColor = true;
            // 
            // Next_Step
            // 
            Next_Step.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Next_Step.BtnText = null;
            Next_Step.IsRoundCorner = true;
            Next_Step.Location = new Point(610, 328);
            Next_Step.Name = "Next_Step";
            Next_Step.RoundRadius = 60;
            Next_Step.Size = new Size(178, 68);
            Next_Step.TabIndex = 1;
            Next_Step.TabStop = false;
            Next_Step.Text = "下一步";
            Next_Step.UseVisualStyleBackColor = true;
            Next_Step.Click += Next_Step_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 38);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 2;
            label1.Text = "放入身份证扫描区";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 119);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 3;
            label2.Text = "身份证：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 200);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 4;
            label3.Text = "姓名：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 34);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(270, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 34);
            textBox2.TabIndex = 6;
            // 
            // Update_IdCard
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Next_Step);
            Controls.Add(Return_Button);
            Name = "Update_IdCard";
            Text = "Update_IdCard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private archButton Return_Button;
        private archButton Next_Step;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}