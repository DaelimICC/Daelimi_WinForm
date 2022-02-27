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
        public static int margin = 5;
        private void Ai_AddChat(string text)
        {
            var aiChat = new AIChat.Ai_Chat(UserQustion); 
            Container.Controls.Add(aiChat);
            aiChat.SetSize();
            aiChat.BringToFront();
            aiChat.Dock = DockStyle.Top;
        }

        private void User_AddChat(string text)
        {
            var userChat = new UserChat.User_Chat(UserQustion);
            Container.Controls.Add(userChat);
            userChat.SetSize();
            userChat.BringToFront();
            userChat.Dock = DockStyle.Top;
        }
    }
}
