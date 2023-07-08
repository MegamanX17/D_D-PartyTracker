namespace D_PartyTracker
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerList = new System.Windows.Forms.RichTextBox();
            this.PlayerContent = new System.Windows.Forms.TextBox();
            this.PlayerInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current players:";
            // 
            // PlayerList
            // 
            this.PlayerList.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PlayerList.Location = new System.Drawing.Point(33, 137);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.Size = new System.Drawing.Size(325, 543);
            this.PlayerList.TabIndex = 2;
            this.PlayerList.TabStop = false;
            this.PlayerList.Text = "";
            // 
            // PlayerContent
            // 
            this.PlayerContent.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PlayerContent.Location = new System.Drawing.Point(407, 206);
            this.PlayerContent.Name = "PlayerContent";
            this.PlayerContent.Size = new System.Drawing.Size(312, 53);
            this.PlayerContent.TabIndex = 3;
            this.PlayerContent.TabStop = false;
            // 
            // PlayerInfo
            // 
            this.PlayerInfo.AutoSize = true;
            this.PlayerInfo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PlayerInfo.Location = new System.Drawing.Point(399, 137);
            this.PlayerInfo.Name = "PlayerInfo";
            this.PlayerInfo.Size = new System.Drawing.Size(117, 46);
            this.PlayerInfo.TabIndex = 4;
            this.PlayerInfo.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 712);
            this.Controls.Add(this.PlayerInfo);
            this.Controls.Add(this.PlayerContent);
            this.Controls.Add(this.PlayerList);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox PlayerList;
        private System.Windows.Forms.TextBox PlayerContent;
        private System.Windows.Forms.Label PlayerInfo;
    }
}