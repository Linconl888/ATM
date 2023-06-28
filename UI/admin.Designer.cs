namespace UI
{
    partial class admin
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
            Update_Phone = new archButton();
            Update_Id = new archButton();
            Thaw = new archButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // Update_Phone
            // 
            Update_Phone.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Update_Phone.BtnText = null;
            Update_Phone.IsRoundCorner = true;
            Update_Phone.Location = new Point(637, 150);
            Update_Phone.Name = "Update_Phone";
            Update_Phone.RoundRadius = 60;
            Update_Phone.Size = new Size(151, 78);
            Update_Phone.TabIndex = 0;
            Update_Phone.TabStop = false;
            Update_Phone.Text = "更新手机号";
            Update_Phone.UseVisualStyleBackColor = true;
            Update_Phone.Click += Update_Phone_Click;
            // 
            // Update_Id
            // 
            Update_Id.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Update_Id.BtnText = null;
            Update_Id.IsRoundCorner = true;
            Update_Id.Location = new Point(637, 306);
            Update_Id.Name = "Update_Id";
            Update_Id.RoundRadius = 60;
            Update_Id.Size = new Size(151, 82);
            Update_Id.TabIndex = 1;
            Update_Id.TabStop = false;
            Update_Id.Text = "更新身份证";
            Update_Id.UseVisualStyleBackColor = true;
            // 
            // Thaw
            // 
            Thaw.BtnFont = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Thaw.BtnText = null;
            Thaw.IsRoundCorner = true;
            Thaw.Location = new Point(12, 306);
            Thaw.Name = "Thaw";
            Thaw.RoundRadius = 60;
            Thaw.Size = new Size(146, 82);
            Thaw.TabIndex = 2;
            Thaw.TabStop = false;
            Thaw.Text = "解冻";
            Thaw.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 63);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 3;
            label1.Text = "管理员";
            label1.Click += label1_Click_1;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Thaw);
            Controls.Add(Update_Id);
            Controls.Add(Update_Phone);
            Name = "admin";
            Text = "admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private archButton Update_Phone;
        private archButton Update_Id;
        private archButton Thaw;
        private Label label1;
    }
}