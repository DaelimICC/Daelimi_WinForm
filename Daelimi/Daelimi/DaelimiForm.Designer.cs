using System.Drawing;

namespace Daelimi
{
    partial class DaelimiForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormBar = new System.Windows.Forms.Panel();
            this.FormMinii = new System.Windows.Forms.Panel();
            this.FormClose = new System.Windows.Forms.Panel();
            this.Pl_Message = new System.Windows.Forms.Panel();
            this.Send = new System.Windows.Forms.Panel();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.Container = new System.Windows.Forms.Panel();
            this.ai_Chat1 = new AIChat.Ai_Chat();
            this.ai_Chat2 = new AIChat.Ai_Chat();
            this.ai_Chat3 = new AIChat.Ai_Chat();
            this.ai_Chat4 = new AIChat.Ai_Chat();
            this.ai_Chat5 = new AIChat.Ai_Chat();
            this.ai_Chat6 = new AIChat.Ai_Chat();
            this.ai_Chat7 = new AIChat.Ai_Chat();
            this.ai_Chat8 = new AIChat.Ai_Chat();
            this.ai_Chat9 = new AIChat.Ai_Chat();
            this.ai_Chat10 = new AIChat.Ai_Chat();
            this.ai_Chat11 = new AIChat.Ai_Chat();
            this.ai_Chat12 = new AIChat.Ai_Chat();
            this.ai_Chat13 = new AIChat.Ai_Chat();
            this.ai_Chat14 = new AIChat.Ai_Chat();
            this.ai_Chat15 = new AIChat.Ai_Chat();
            this.FormBar.SuspendLayout();
            this.Pl_Message.SuspendLayout();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBar
            // 
            this.FormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(205)))));
            this.FormBar.Controls.Add(this.FormMinii);
            this.FormBar.Controls.Add(this.FormClose);
            this.FormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBar.Location = new System.Drawing.Point(0, 0);
            this.FormBar.Name = "FormBar";
            this.FormBar.Size = new System.Drawing.Size(323, 39);
            this.FormBar.TabIndex = 0;
            // 
            // FormMinii
            // 
            this.FormMinii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormMinii.BackgroundImage = global::Daelimi.Properties.Resources.underbar;
            this.FormMinii.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FormMinii.Location = new System.Drawing.Point(258, 18);
            this.FormMinii.Name = "FormMinii";
            this.FormMinii.Size = new System.Drawing.Size(24, 17);
            this.FormMinii.TabIndex = 1;
            // 
            // FormClose
            // 
            this.FormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormClose.BackgroundImage = global::Daelimi.Properties.Resources.Close;
            this.FormClose.Location = new System.Drawing.Point(289, 5);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(30, 30);
            this.FormClose.TabIndex = 0;
            // 
            // Pl_Message
            // 
            this.Pl_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.Pl_Message.Controls.Add(this.Send);
            this.Pl_Message.Controls.Add(this.MessageBox);
            this.Pl_Message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pl_Message.Location = new System.Drawing.Point(0, 546);
            this.Pl_Message.Name = "Pl_Message";
            this.Pl_Message.Padding = new System.Windows.Forms.Padding(10);
            this.Pl_Message.Size = new System.Drawing.Size(323, 88);
            this.Pl_Message.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.BackgroundImage = global::Daelimi.Properties.Resources.send;
            this.Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.Send.Location = new System.Drawing.Point(279, 10);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(34, 68);
            this.Send.TabIndex = 1;
            // 
            // MessageBox
            // 
            this.MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MessageBox.ForeColor = System.Drawing.Color.Silver;
            this.MessageBox.Location = new System.Drawing.Point(10, 10);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(263, 68);
            this.MessageBox.TabIndex = 0;
            this.MessageBox.TabStop = false;
            this.MessageBox.Text = "문의할 메세지를 입력하시오.";
            // 
            // Container
            // 
            this.Container.AutoScroll = true;
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Container.Controls.Add(this.ai_Chat15);
            this.Container.Controls.Add(this.ai_Chat14);
            this.Container.Controls.Add(this.ai_Chat13);
            this.Container.Controls.Add(this.ai_Chat12);
            this.Container.Controls.Add(this.ai_Chat11);
            this.Container.Controls.Add(this.ai_Chat10);
            this.Container.Controls.Add(this.ai_Chat9);
            this.Container.Controls.Add(this.ai_Chat8);
            this.Container.Controls.Add(this.ai_Chat7);
            this.Container.Controls.Add(this.ai_Chat6);
            this.Container.Controls.Add(this.ai_Chat5);
            this.Container.Controls.Add(this.ai_Chat4);
            this.Container.Controls.Add(this.ai_Chat3);
            this.Container.Controls.Add(this.ai_Chat2);
            this.Container.Controls.Add(this.ai_Chat1);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 39);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(323, 507);
            this.Container.TabIndex = 2;
            // 
            // ai_Chat1
            // 
            this.ai_Chat1.AutoSize = true;
            this.ai_Chat1.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat1.Location = new System.Drawing.Point(0, 0);
            this.ai_Chat1.Name = "ai_Chat1";
            this.ai_Chat1.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat1.TabIndex = 0;
            this.ai_Chat1.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat2
            // 
            this.ai_Chat2.AutoSize = true;
            this.ai_Chat2.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat2.Location = new System.Drawing.Point(0, 53);
            this.ai_Chat2.Name = "ai_Chat2";
            this.ai_Chat2.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat2.TabIndex = 1;
            this.ai_Chat2.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat3
            // 
            this.ai_Chat3.AutoSize = true;
            this.ai_Chat3.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat3.Location = new System.Drawing.Point(0, 106);
            this.ai_Chat3.Name = "ai_Chat3";
            this.ai_Chat3.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat3.TabIndex = 2;
            this.ai_Chat3.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat4
            // 
            this.ai_Chat4.AutoSize = true;
            this.ai_Chat4.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat4.Location = new System.Drawing.Point(0, 159);
            this.ai_Chat4.Name = "ai_Chat4";
            this.ai_Chat4.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat4.TabIndex = 3;
            this.ai_Chat4.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat5
            // 
            this.ai_Chat5.AutoSize = true;
            this.ai_Chat5.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat5.Location = new System.Drawing.Point(0, 212);
            this.ai_Chat5.Name = "ai_Chat5";
            this.ai_Chat5.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat5.TabIndex = 4;
            this.ai_Chat5.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat6
            // 
            this.ai_Chat6.AutoSize = true;
            this.ai_Chat6.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat6.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat6.Location = new System.Drawing.Point(0, 265);
            this.ai_Chat6.Name = "ai_Chat6";
            this.ai_Chat6.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat6.TabIndex = 5;
            this.ai_Chat6.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat7
            // 
            this.ai_Chat7.AutoSize = true;
            this.ai_Chat7.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat7.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat7.Location = new System.Drawing.Point(0, 318);
            this.ai_Chat7.Name = "ai_Chat7";
            this.ai_Chat7.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat7.TabIndex = 6;
            this.ai_Chat7.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat8
            // 
            this.ai_Chat8.AutoSize = true;
            this.ai_Chat8.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat8.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat8.Location = new System.Drawing.Point(0, 371);
            this.ai_Chat8.Name = "ai_Chat8";
            this.ai_Chat8.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat8.TabIndex = 7;
            this.ai_Chat8.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat9
            // 
            this.ai_Chat9.AutoSize = true;
            this.ai_Chat9.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat9.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat9.Location = new System.Drawing.Point(0, 424);
            this.ai_Chat9.Name = "ai_Chat9";
            this.ai_Chat9.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat9.TabIndex = 8;
            this.ai_Chat9.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat10
            // 
            this.ai_Chat10.AutoSize = true;
            this.ai_Chat10.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat10.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat10.Location = new System.Drawing.Point(0, 477);
            this.ai_Chat10.Name = "ai_Chat10";
            this.ai_Chat10.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat10.TabIndex = 9;
            this.ai_Chat10.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat11
            // 
            this.ai_Chat11.AutoSize = true;
            this.ai_Chat11.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat11.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat11.Location = new System.Drawing.Point(0, 530);
            this.ai_Chat11.Name = "ai_Chat11";
            this.ai_Chat11.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat11.TabIndex = 10;
            this.ai_Chat11.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat12
            // 
            this.ai_Chat12.AutoSize = true;
            this.ai_Chat12.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat12.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat12.Location = new System.Drawing.Point(0, 583);
            this.ai_Chat12.Name = "ai_Chat12";
            this.ai_Chat12.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat12.TabIndex = 11;
            this.ai_Chat12.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat13
            // 
            this.ai_Chat13.AutoSize = true;
            this.ai_Chat13.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat13.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat13.Location = new System.Drawing.Point(0, 636);
            this.ai_Chat13.Name = "ai_Chat13";
            this.ai_Chat13.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat13.TabIndex = 12;
            this.ai_Chat13.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat14
            // 
            this.ai_Chat14.AutoSize = true;
            this.ai_Chat14.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat14.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat14.Location = new System.Drawing.Point(0, 689);
            this.ai_Chat14.Name = "ai_Chat14";
            this.ai_Chat14.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat14.TabIndex = 13;
            this.ai_Chat14.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // ai_Chat15
            // 
            this.ai_Chat15.AutoSize = true;
            this.ai_Chat15.BackColor = System.Drawing.Color.Transparent;
            this.ai_Chat15.Dock = System.Windows.Forms.DockStyle.Top;
            this.ai_Chat15.Location = new System.Drawing.Point(0, 742);
            this.ai_Chat15.Name = "ai_Chat15";
            this.ai_Chat15.Size = new System.Drawing.Size(306, 53);
            this.ai_Chat15.TabIndex = 14;
            this.ai_Chat15.UserName = "안녕하세요. 대림이봇입니다.";
            // 
            // DaelimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 634);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Pl_Message);
            this.Controls.Add(this.FormBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DaelimiForm";
            this.Text = "Daelimi";
            this.FormBar.ResumeLayout(false);
            this.Pl_Message.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBar;
        private System.Windows.Forms.Panel FormClose;
        private System.Windows.Forms.Panel FormMinii;
        private System.Windows.Forms.Panel Pl_Message;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel Send;
        private System.Windows.Forms.RichTextBox MessageBox;
        private AIChat.Ai_Chat ai_Chat1;
        private AIChat.Ai_Chat ai_Chat9;
        private AIChat.Ai_Chat ai_Chat8;
        private AIChat.Ai_Chat ai_Chat7;
        private AIChat.Ai_Chat ai_Chat6;
        private AIChat.Ai_Chat ai_Chat5;
        private AIChat.Ai_Chat ai_Chat4;
        private AIChat.Ai_Chat ai_Chat3;
        private AIChat.Ai_Chat ai_Chat2;
        private AIChat.Ai_Chat ai_Chat15;
        private AIChat.Ai_Chat ai_Chat14;
        private AIChat.Ai_Chat ai_Chat13;
        private AIChat.Ai_Chat ai_Chat12;
        private AIChat.Ai_Chat ai_Chat11;
        private AIChat.Ai_Chat ai_Chat10;
    }
}

