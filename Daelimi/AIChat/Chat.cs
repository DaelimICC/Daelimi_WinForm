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
    public partial class Chat: UserControl
    {
        public Chat()
        {
            InitializeComponent();
        }

        [Category("UserProperty"), Description("Text")]
        public string Ai_Text
        {
            get
            {
                return this.Ai_ChatText.Text;
            }
            set
            {
                this.Ai_ChatText.Text = value;
            }
        }
    }
}
