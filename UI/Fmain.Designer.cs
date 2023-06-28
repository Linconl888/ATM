namespace UI
{
    partial class Fmain
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
            button1 = new Button();
            archButton1 = new archButton();
            archButton2 = new archButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(661, 164);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "查看密码";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // archButton1
            // 
            archButton1.BackColor = Color.Gray;
            archButton1.BackgroundImageLayout = ImageLayout.Center;
            archButton1.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton1.BtnText = null;
            archButton1.FlatStyle = FlatStyle.Popup;
            archButton1.IsRoundCorner = true;
            archButton1.Location = new Point(423, 160);
            archButton1.Name = "archButton1";
            archButton1.RoundRadius = 60;
            archButton1.Size = new Size(170, 85);
            archButton1.TabIndex = 1;
            archButton1.TabStop = false;
            archButton1.Text = "archButton1";
            archButton1.UseVisualStyleBackColor = false;
            archButton1.Click += archButton1_Click;
            // 
            // archButton2
            // 
            archButton2.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            archButton2.BtnText = null;
            archButton2.IsRoundCorner = true;
            archButton2.Location = new Point(166, 85);
            archButton2.Name = "archButton2";
            archButton2.RoundRadius = 60;
            archButton2.Size = new Size(112, 34);
            archButton2.TabIndex = 2;
            archButton2.TabStop = false;
            archButton2.Text = "archButton2";
            archButton2.UseVisualStyleBackColor = true;
            // 
            // Fmain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(archButton2);
            Controls.Add(archButton1);
            Controls.Add(button1);
            Name = "Fmain";
            Text = "Fmain";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private archButton archButton1;
        private archButton archButton2;
    }
}