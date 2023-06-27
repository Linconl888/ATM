namespace UI
{
    partial class CardLogin
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
            tB_cardID = new TextBox();
            tb_cardPwd = new TextBox();
            CardID = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tB_cardID
            // 
            tB_cardID.Location = new Point(234, 115);
            tB_cardID.Name = "tB_cardID";
            tB_cardID.Size = new Size(322, 30);
            tB_cardID.TabIndex = 0;
            // 
            // tb_cardPwd
            // 
            tb_cardPwd.Location = new Point(234, 175);
            tb_cardPwd.Name = "tb_cardPwd";
            tb_cardPwd.Size = new Size(322, 30);
            tb_cardPwd.TabIndex = 1;
            // 
            // CardID
            // 
            CardID.AutoSize = true;
            CardID.Location = new Point(147, 115);
            CardID.Name = "CardID";
            CardID.Size = new Size(64, 24);
            CardID.TabIndex = 2;
            CardID.Text = "卡号：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 175);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 3;
            label1.Text = "密码：";
            // 
            // button1
            // 
            button1.Location = new Point(234, 301);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "进入";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(431, 301);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "弹出";
            button2.UseVisualStyleBackColor = true;
            // 
            // CardLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(CardID);
            Controls.Add(tb_cardPwd);
            Controls.Add(tB_cardID);
            Name = "CardLogin";
            Text = "CardLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tB_cardID;
        private TextBox tb_cardPwd;
        private Label CardID;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}