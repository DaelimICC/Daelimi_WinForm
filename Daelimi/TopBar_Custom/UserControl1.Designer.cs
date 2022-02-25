namespace TopBar_Custom
{
    partial class TopBar
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
            this.FormBar = new System.Windows.Forms.Panel();
            this.FormClose = new System.Windows.Forms.Panel();
            this.FormMinii = new System.Windows.Forms.Panel();
            this.FormBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBar
            // 
            this.FormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(205)))));
            this.FormBar.Controls.Add(this.FormClose);
            this.FormBar.Controls.Add(this.FormMinii);
            this.FormBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormBar.Location = new System.Drawing.Point(0, 0);
            this.FormBar.Name = "FormBar";
            this.FormBar.Size = new System.Drawing.Size(302, 39);
            this.FormBar.TabIndex = 0;
            // 
            // FormClose
            // 
            this.FormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormClose.BackgroundImage = global::TopBar_Custom.Properties.Resources.Close;
            this.FormClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FormClose.Location = new System.Drawing.Point(268, 5);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(30, 30);
            this.FormClose.TabIndex = 3;
            // 
            // FormMinii
            // 
            this.FormMinii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormMinii.BackgroundImage = global::TopBar_Custom.Properties.Resources.underbar;
            this.FormMinii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FormMinii.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FormMinii.Location = new System.Drawing.Point(237, 18);
            this.FormMinii.Name = "FormMinii";
            this.FormMinii.Size = new System.Drawing.Size(24, 17);
            this.FormMinii.TabIndex = 2;
            // 
            // TopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FormBar);
            this.Name = "TopBar";
            this.Size = new System.Drawing.Size(302, 39);
            this.FormBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBar;
        private System.Windows.Forms.Panel FormMinii;
        private System.Windows.Forms.Panel FormClose;
    }
}
