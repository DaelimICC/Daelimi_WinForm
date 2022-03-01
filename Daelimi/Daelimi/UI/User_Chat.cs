using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserChat
{
    public partial class User_Chat: UserControl
    {
        public User_Chat(string text)
        {
            InitializeComponent();
            User_ChatText.Text = text;
        }
        public void SetSize()
        {
            Null.Width = 260 - User_ChatText.Width + 12;
        }
    }
}
