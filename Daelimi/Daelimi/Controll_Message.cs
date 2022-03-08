using System;
using System.Drawing;

namespace Daelimi
{

    public partial class DaelimiForm
    {
        Api api = new Api();
        Filter filter = new Filter();
        private void SendOnClick(object sender, EventArgs e)
        {
            if (MessageBox.Text != FAQPlaceholder && MessageBox.Text != string.Empty)
            {
                    UserQustion = MessageBox.Text;
                    AIAnsower = api.Api_Post(UserQustion, filter.CheckPlace(UserQustion));
                    User_AddChat(UserQustion);
                    Ai_AddChat(AIAnsower);
                    MessageRest();
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
            Ai_AddChat("안녕하세요 대림이봇입니다.");
            Ai_AddChat("온전한 문장으로 끝내주셔야 \n이해할 수 있습니다.");
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
