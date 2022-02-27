using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daelimi
{

    public partial class DaelimiForm : Form
    {
        #region 메세지박스 상호작용
        private void MessageControll()
        {
            PlaceHolder();
            Send.Click += SendOnClick;
            Send.MouseHover += (sender, args) => Send.BackgroundImage = Properties.Resources.send_Pop;
            Send.MouseLeave += (sender, args) => Send.BackgroundImage = Properties.Resources.send;
        }
        private void SendOnClick(object sender, EventArgs e)
        {
            if (MessageBox.Text != FAQPlaceholder)
            {
                if (MessageBox.Text != string.Empty)
                {
                    UserQustion = MessageBox.Text;
                    User_AddChat(UserQustion);
                    Ai_AddChat(UserQustion); 
                    MessageBox.Text = String.Empty;
                    MessageBox.Enabled = false;
                    MessageBox.Enabled = true;
                }
            }
        }
        #endregion

        #region Placeholder
        const string FAQPlaceholder = "문의할 메세지를 입력하시오.";
        public void PlaceHolder()
        {
            MessageBox.Leave += MessageBoxOnLeave;
            MessageBox.Enter += MessageBoxOnEnter;
        }

        private void MessageBoxOnEnter(object sender, EventArgs e)
        {
            if (MessageBox.Text == FAQPlaceholder)
            {
                MessageBox.Text = "";
                MessageBox.ForeColor = Color.Black;
            }
        }

        private void MessageBoxOnLeave(object sender, EventArgs e)
        {
            if (MessageBox.Text == "")
            {
                MessageBox.Text = FAQPlaceholder;
                MessageBox.ForeColor = Color.Silver;
            }
        }

        #endregion
        
    }
}
