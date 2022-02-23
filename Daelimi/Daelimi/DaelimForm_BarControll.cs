using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daelimi
{
    public partial class DaelimiForm : Form
    {
        #region 상단바 커스텀
        private void Controll_Bar()
        {
            FormBar.MouseUp += FormBar_MouseUp;
            FormBar.MouseDown += FormBar_MouseDown;
            FormBar.MouseMove += FormBar_MouseMove;
            FormMinii.Click += Form_Minmon;
            FormClose.Click += Form_Close;
        }

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
