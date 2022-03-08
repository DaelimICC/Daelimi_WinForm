using System;
using System.Windows.Forms;

namespace Daelimi
{
    public partial class DaelimiForm
    {
        private void Controll_Bar()
        {
            FormBar.MouseUp += FormBar_MouseUp;
            FormBar.MouseDown += FormBar_MouseDown;
            FormBar.MouseMove += FormBar_MouseMove;
            FormMinii.Click += Form_Minmon;
            FormClose.Click += Form_Close;
        }
        #region 상단바 상호작용
        bool isMove;
        int MouseX, MouseY;

        private void FormBar_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
        private void FormBar_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            MouseX = e.X;
            MouseY = e.Y;
        }
        private void FormBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MouseX, MousePosition.Y - MouseY);
            }
        }
        private void Form_Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form_Minmon(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
