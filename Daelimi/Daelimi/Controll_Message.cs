using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daelimi
{

    public partial class DaelimiForm : Form
    {

        private void SendOnClick(object sender, EventArgs e)
        {
            if (MessageBox.Text != FAQPlaceholder)
            {
                if (MessageBox.Text != string.Empty)
                {
                    UserQustion = MessageBox.Text;
                    User_AddChat(UserQustion);
                    testfilter(UserQustion);

                    Api api = new Api();
                    AIAnsower = api.Api_Post(UserQustion, filter);
                    Ai_AddChat(AIAnsower);
                    MessageRest();
                }
            }
        }
        public void testfilter(string text)
        {
            int result = 0;
            if (text == "장소찾기")
            {
                Ai_AddChat("filter = 1");
                filter = 1;
            }
            else if (text == "문의하기")
            {
                Ai_AddChat("filter = 0");
                filter = 0;
            }
        }

        #region 메세지박스 상호작용
        private void MessageControll()
        {
            PlaceHolder();
            Send.Click += SendOnClick;
            this.Load += OnLoad;
            Send.MouseHover += (sender, args) => Send.BackgroundImage = Properties.Resources.send_Pop;
            Send.MouseLeave += (sender, args) => Send.BackgroundImage = Properties.Resources.send;
        }
        private void OnLoad(object sender, EventArgs e)
        {
            Ai_AddChat(test);
        }

        private void MessageRest()
        {
            MessageBox.Text = String.Empty;
            MessageBox.Enabled = false;
            MessageBox.Enabled = true;
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
