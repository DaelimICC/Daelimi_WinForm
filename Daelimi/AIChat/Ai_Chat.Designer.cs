namespace AIChat
{
    partial class Ai_Chat
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ai_Profile = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.Ai_ChatText = new System.Windows.Forms.Label();
            this.Top = new System.Windows.Forms.Panel();
            this.Bottom = new System.Windows.Forms.Panel();
            this.tail = new System.Windows.Forms.Panel();
            this.picture35x35 = new System.Windows.Forms.Panel();
            this.Ai_Profile.SuspendLayout();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ai_Profile
            // 
            this.Ai_Profile.Controls.Add(this.tail);
            this.Ai_Profile.Controls.Add(this.picture35x35);
            this.Ai_Profile.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ai_Profile.Location = new System.Drawing.Point(0, 0);
            this.Ai_Profile.Name = "Ai_Profile";
            this.Ai_Profile.Size = new System.Drawing.Size(65, 72);
            this.Ai_Profile.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(318, 0);
            this.panel5.MinimumSize = new System.Drawing.Size(18, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 72);
            this.panel5.TabIndex = 3;
            // 
            // Main
            // 
            this.Main.AutoSize = true;
            this.Main.BackColor = System.Drawing.Color.Transparent;
            this.Main.BackgroundImage = global::AIChat.Properties.Resources.main;
            this.Main.Controls.Add(this.Ai_ChatText);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(65, 14);
            this.Main.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Main.Size = new System.Drawing.Size(253, 44);
            this.Main.TabIndex = 2;
            // 
            // Ai_ChatText
            // 
            this.Ai_ChatText.AutoSize = true;
            this.Ai_ChatText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ai_ChatText.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Ai_ChatText.Location = new System.Drawing.Point(4, 3);
            this.Ai_ChatText.MaximumSize = new System.Drawing.Size(219, 0);
            this.Ai_ChatText.Name = "Ai_ChatText";
            this.Ai_ChatText.Size = new System.Drawing.Size(110, 38);
            this.Ai_ChatText.TabIndex = 0;
            this.Ai_ChatText.Text = "안녕하세요.\r\n대림이봇입니다.";
            // 
            // Top
            // 
            this.Top.AutoScroll = true;
            this.Top.BackColor = System.Drawing.Color.Transparent;
            this.Top.BackgroundImage = global::AIChat.Properties.Resources.top;
            this.Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(65, 0);
            this.Top.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(253, 14);
            this.Top.TabIndex = 1;
            // 
            // Bottom
            // 
            this.Bottom.AllowDrop = true;
            this.Bottom.BackgroundImage = global::AIChat.Properties.Resources.bottom;
            this.Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(65, 58);
            this.Bottom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(253, 14);
            this.Bottom.TabIndex = 2;
            // 
            // tail
            // 
            this.tail.BackgroundImage = global::AIChat.Properties.Resources.tail;
            this.tail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tail.Location = new System.Drawing.Point(40, 14);
            this.tail.Name = "tail";
            this.tail.Size = new System.Drawing.Size(25, 23);
            this.tail.TabIndex = 1;
            // 
            // picture35x35
            // 
            this.picture35x35.BackgroundImage = global::AIChat.Properties.Resources.pngwing_com;
            this.picture35x35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture35x35.Location = new System.Drawing.Point(7, 4);
            this.picture35x35.Name = "picture35x35";
            this.picture35x35.Size = new System.Drawing.Size(35, 35);
            this.picture35x35.TabIndex = 0;
            // 
            // Ai_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Bottom);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Ai_Profile);
            this.Name = "Ai_Chat";
            this.Size = new System.Drawing.Size(336, 72);
            this.Ai_Profile.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Ai_Profile;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Ai_ChatText;
        private System.Windows.Forms.Panel picture35x35;
        private System.Windows.Forms.Panel tail;
    }
}
