namespace UI
{
    partial class Update_Phone2
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
            Return_Button2 = new archButton();
            Sure_Button2 = new archButton();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            New_Phone = new TextBox();
            SuspendLayout();
            // 
            // Return_Button2
            // 
            Return_Button2.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Return_Button2.BtnText = null;
            Return_Button2.IsRoundCorner = true;
            Return_Button2.Location = new Point(157, 294);
            Return_Button2.Name = "Return_Button2";
            Return_Button2.RoundRadius = 60;
            Return_Button2.Size = new Size(148, 58);
            Return_Button2.TabIndex = 0;
            Return_Button2.TabStop = false;
            Return_Button2.Text = "返回";
            Return_Button2.UseVisualStyleBackColor = true;
            Return_Button2.Click += Return_Button2_Click;
            // 
            // Sure_Button2
            // 
            Sure_Button2.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Sure_Button2.BtnText = null;
            Sure_Button2.IsRoundCorner = true;
            Sure_Button2.Location = new Point(480, 294);
            Sure_Button2.Name = "Sure_Button2";
            Sure_Button2.RoundRadius = 60;
            Sure_Button2.Size = new Size(137, 58);
            Sure_Button2.TabIndex = 1;
            Sure_Button2.TabStop = false;
            Sure_Button2.Text = "确定";
            Sure_Button2.UseVisualStyleBackColor = true;
            Sure_Button2.Click += Sure_Button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 60);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 2;
            label1.Text = "原手机号码是：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 111);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 3;
            label2.Text = "更改成：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 34);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // New_Phone
            // 
            New_Phone.Location = new Point(322, 111);
            New_Phone.Name = "New_Phone";
            New_Phone.Size = new Size(295, 34);
            New_Phone.TabIndex = 5;
            // 
            // Update_Phone2
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(New_Phone);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Sure_Button2);
            Controls.Add(Return_Button2);
            Name = "Update_Phone2";
            Text = "Update_Phone2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private archButton Return_Button2;
        private archButton Sure_Button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox New_Phone;
    }
}