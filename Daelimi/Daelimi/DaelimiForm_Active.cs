using System.Windows.Forms;

namespace Daelimi
{
    public partial class DaelimiForm : Form
    {
        private void Ai_AddChat(string text)
        {
            var aiChat = new AIChat.Ai_Chat(text);
            Container.Controls.Add(aiChat);
            aiChat.SetSize();
            aiChat.BringToFront();
            aiChat.Dock = DockStyle.Top;
        }
        private void User_AddChat(string text)
        {
            var userChat = new UserChat.User_Chat(text);
            Container.Controls.Add(userChat);
            userChat.SetSize();
            userChat.BringToFront();
            userChat.Dock = DockStyle.Top;
        }
    }
}
