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
            tB_cardID.Location = new Point(191, 96);
            tB_cardID.Margin = new Padding(2, 2, 2, 2);
            tB_cardID.Name = "tB_cardID";
            tB_cardID.Size = new Size(264, 27);
            tB_cardID.TabIndex = 0;
            // 
            // tb_cardPwd
            // 
            tb_cardPwd.Location = new Point(191, 146);
            tb_cardPwd.Margin = new Padding(2, 2, 2, 2);
            tb_cardPwd.Name = "tb_cardPwd";
            tb_cardPwd.Size = new Size(264, 27);
            tb_cardPwd.TabIndex = 1;
            // 
            // CardID
            // 
            CardID.AutoSize = true;
            CardID.Location = new Point(120, 96);
            CardID.Margin = new Padding(2, 0, 2, 0);
            CardID.Name = "CardID";
            CardID.Size = new Size(54, 20);
            CardID.TabIndex = 2;
            CardID.Text = "卡号：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 146);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "密码：";
            // 
            // button1
            // 
            button1.Location = new Point(191, 251);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(92, 28);
            button1.TabIndex = 4;
            button1.Text = "进入";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(353, 251);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(92, 28);
            button2.TabIndex = 5;
            button2.Text = "弹出";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CardLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 375);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(CardID);
            Controls.Add(tb_cardPwd);
            Controls.Add(tB_cardID);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CardLogin";
            Text = "CardLogin";
            Load += CardLogin_Load;
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