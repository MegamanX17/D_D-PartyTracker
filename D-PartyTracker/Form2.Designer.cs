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
            this.EnterBttn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DoneBttn = new System.Windows.Forms.Button();
            this.CloseBttn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.PlayerList.ReadOnly = true;
            this.PlayerList.Size = new System.Drawing.Size(325, 543);
            this.PlayerList.TabIndex = 2;
            this.PlayerList.TabStop = false;
            this.PlayerList.Text = "";
            // 
            // PlayerContent
            // 
            this.PlayerContent.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PlayerContent.Location = new System.Drawing.Point(407, 273);
            this.PlayerContent.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
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
            this.PlayerInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.PlayerInfo.Name = "PlayerInfo";
            this.PlayerInfo.Size = new System.Drawing.Size(117, 46);
            this.PlayerInfo.TabIndex = 4;
            this.PlayerInfo.Text = "label2";
            // 
            // EnterBttn
            // 
            this.EnterBttn.Location = new System.Drawing.Point(769, 273);
            this.EnterBttn.Name = "EnterBttn";
            this.EnterBttn.Size = new System.Drawing.Size(125, 62);
            this.EnterBttn.TabIndex = 5;
            this.EnterBttn.Text = "Enter";
            this.EnterBttn.UseVisualStyleBackColor = true;
            this.EnterBttn.Click += new System.EventHandler(this.EnterBttn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DoneBttn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CloseBttn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(407, 403);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 161);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // DoneBttn
            // 
            this.DoneBttn.Location = new System.Drawing.Point(3, 3);
            this.DoneBttn.Name = "DoneBttn";
            this.DoneBttn.Size = new System.Drawing.Size(237, 155);
            this.DoneBttn.TabIndex = 0;
            this.DoneBttn.Text = "Done";
            this.DoneBttn.UseVisualStyleBackColor = true;
            // 
            // CloseBttn
            // 
            this.CloseBttn.Location = new System.Drawing.Point(246, 3);
            this.CloseBttn.Name = "CloseBttn";
            this.CloseBttn.Size = new System.Drawing.Size(238, 155);
            this.CloseBttn.TabIndex = 1;
            this.CloseBttn.TabStop = false;
            this.CloseBttn.Text = "Close";
            this.CloseBttn.UseVisualStyleBackColor = true;
            this.CloseBttn.Click += new System.EventHandler(this.CloseBttn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.EnterBttn);
            this.Controls.Add(this.PlayerInfo);
            this.Controls.Add(this.PlayerContent);
            this.Controls.Add(this.PlayerList);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox PlayerList;
        private System.Windows.Forms.TextBox PlayerContent;
        private System.Windows.Forms.Label PlayerInfo;
        private System.Windows.Forms.Button EnterBttn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DoneBttn;
        private System.Windows.Forms.Button CloseBttn;
    }
}