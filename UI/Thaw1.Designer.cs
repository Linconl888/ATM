namespace UI
{
    partial class Thaw1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Quit = new archButton();
            Next_Step = new archButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(414, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 34);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(414, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 34);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 81);
            label1.Name = "label1";
            label1.Size = new Size(264, 28);
            label1.TabIndex = 2;
            label1.Text = "请插入需要解冻的银行卡：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 196);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 3;
            label2.Text = "密码：";
            // 
            // Quit
            // 
            Quit.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Quit.BtnText = null;
            Quit.IsRoundCorner = true;
            Quit.Location = new Point(12, 342);
            Quit.Name = "Quit";
            Quit.RoundRadius = 60;
            Quit.Size = new Size(173, 65);
            Quit.TabIndex = 4;
            Quit.TabStop = false;
            Quit.Text = "退出";
            Quit.UseVisualStyleBackColor = true;
            // 
            // Next_Step
            // 
            Next_Step.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Next_Step.BtnText = null;
            Next_Step.IsRoundCorner = true;
            Next_Step.Location = new Point(628, 342);
            Next_Step.Name = "Next_Step";
            Next_Step.RoundRadius = 60;
            Next_Step.Size = new Size(160, 65);
            Next_Step.TabIndex = 5;
            Next_Step.TabStop = false;
            Next_Step.Text = "下一步";
            Next_Step.UseVisualStyleBackColor = true;
            // 
            // Thaw1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Next_Step);
            Controls.Add(Quit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Thaw1";
            Text = "Thaw1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private archButton Quit;
        private archButton Next_Step;
    }
}