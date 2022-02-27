using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIChat
{
    public partial class Ai_Chat: UserControl
    {
        public Ai_Chat(string text)
        {
            InitializeComponent();
            Ai_ChatText.Text = text;
        }
        public void SetSize()
        {
            Null.Width = 260 - Ai_ChatText.Width + 8;
        }
    }
}
