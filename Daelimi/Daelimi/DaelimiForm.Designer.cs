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
            this.FormClose = new System.Windows.Forms.Panel();
            this.FormMini = new System.Windows.Forms.Panel();
            this.FormBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBar
            // 
            this.FormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(205)))));
            this.FormBar.Controls.Add(this.FormClose);
            this.FormBar.Controls.Add(this.FormMini);
            this.FormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBar.Location = new System.Drawing.Point(0, 0);
            this.FormBar.Name = "FormBar";
            this.FormBar.Size = new System.Drawing.Size(269, 39);
            this.FormBar.TabIndex = 0;
            // 
            // FormClose
            // 
            this.FormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormClose.BackgroundImage = global::Daelimi.Properties.Resources.underbar;
            this.FormClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FormClose.Location = new System.Drawing.Point(204, 18);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(24, 17);
            this.FormClose.TabIndex = 1;
            // 
            // FormMini
            // 
            this.FormMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormMini.BackgroundImage = global::Daelimi.Properties.Resources.Close;
            this.FormMini.Location = new System.Drawing.Point(235, 5);
            this.FormMini.Name = "FormMini";
            this.FormMini.Size = new System.Drawing.Size(30, 30);
            this.FormMini.TabIndex = 0;
            // 
            // DaelimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.FormBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DaelimiForm";
            this.Text = "Daelimi";
            this.FormBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBar;
        private System.Windows.Forms.Panel FormMini;
        private System.Windows.Forms.Panel FormClose;
    }
}

