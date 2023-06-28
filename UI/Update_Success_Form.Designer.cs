namespace UI
{
    partial class Update_Success_Form
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
            Quit = new archButton();
            Return_Button = new archButton();
            Print_Info = new archButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 61);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 0;
            label1.Text = "更新成功";
            // 
            // Quit
            // 
            Quit.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Quit.BtnText = null;
            Quit.IsRoundCorner = true;
            Quit.Location = new Point(397, 209);
            Quit.Name = "Quit";
            Quit.RoundRadius = 60;
            Quit.Size = new Size(164, 64);
            Quit.TabIndex = 2;
            Quit.TabStop = false;
            Quit.Text = "退出";
            Quit.UseVisualStyleBackColor = true;
            // 
            // Return_Button
            // 
            Return_Button.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Return_Button.BtnText = null;
            Return_Button.IsRoundCorner = true;
            Return_Button.Location = new Point(12, 209);
            Return_Button.Name = "Return_Button";
            Return_Button.RoundRadius = 60;
            Return_Button.Size = new Size(160, 64);
            Return_Button.TabIndex = 3;
            Return_Button.TabStop = false;
            Return_Button.Text = "返回";
            Return_Button.UseVisualStyleBackColor = true;
            // 
            // Print_Info
            // 
            Print_Info.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Print_Info.BtnText = null;
            Print_Info.IsRoundCorner = true;
            Print_Info.Location = new Point(397, 109);
            Print_Info.Name = "Print_Info";
            Print_Info.RoundRadius = 60;
            Print_Info.Size = new Size(164, 63);
            Print_Info.TabIndex = 4;
            Print_Info.TabStop = false;
            Print_Info.Text = "打印";
            Print_Info.UseVisualStyleBackColor = true;
            // 
            // Update_Success_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 315);
            Controls.Add(Print_Info);
            Controls.Add(Return_Button);
            Controls.Add(Quit);
            Controls.Add(label1);
            Name = "Update_Success_Form";
            Text = "Update_Success_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private archButton Quit;
        private archButton Return_Button;
        private archButton Print_Info;
    }
}