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
            this.Pl_Message = new System.Windows.Forms.Panel();
            this.Send = new System.Windows.Forms.Panel();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.Container = new System.Windows.Forms.Panel();
            this.FormMinii = new System.Windows.Forms.Panel();
            this.FormClose = new System.Windows.Forms.Panel();
            this.FormBar.SuspendLayout();
            this.Pl_Message.SuspendLayout();
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
            this.FormBar.Size = new System.Drawing.Size(302, 39);
            this.FormBar.TabIndex = 0;
            // 
            // Pl_Message
            // 
            this.Pl_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.Pl_Message.Controls.Add(this.Send);
            this.Pl_Message.Controls.Add(this.MessageBox);
            this.Pl_Message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pl_Message.Location = new System.Drawing.Point(0, 381);
            this.Pl_Message.Name = "Pl_Message";
            this.Pl_Message.Padding = new System.Windows.Forms.Padding(10);
            this.Pl_Message.Size = new System.Drawing.Size(302, 88);
            this.Pl_Message.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.BackgroundImage = global::Daelimi.Properties.Resources.send;
            this.Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.Send.Location = new System.Drawing.Point(258, 10);
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
            this.MessageBox.Size = new System.Drawing.Size(242, 68);
            this.MessageBox.TabIndex = 0;
            this.MessageBox.TabStop = false;
            this.MessageBox.Text = "문의할 메세지를 입력하시오.";
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 39);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(302, 342);
            this.Container.TabIndex = 2;
            // 
            // FormMinii
            // 
            this.FormMinii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormMinii.BackgroundImage = global::Daelimi.Properties.Resources.underbar;
            this.FormMinii.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FormMinii.Location = new System.Drawing.Point(237, 18);
            this.FormMinii.Name = "FormMinii";
            this.FormMinii.Size = new System.Drawing.Size(24, 17);
            this.FormMinii.TabIndex = 1;
            // 
            // FormClose
            // 
            this.FormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormClose.BackgroundImage = global::Daelimi.Properties.Resources.Close;
            this.FormClose.Location = new System.Drawing.Point(268, 5);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(30, 30);
            this.FormClose.TabIndex = 0;
            // 
            // DaelimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 469);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Pl_Message);
            this.Controls.Add(this.FormBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DaelimiForm";
            this.Text = "Daelimi";
            this.FormBar.ResumeLayout(false);
            this.Pl_Message.ResumeLayout(false);
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
    }
}

