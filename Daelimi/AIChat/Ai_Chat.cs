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
        public Ai_Chat()
        {
            InitializeComponent();
        }

        [Category("UserProperty"), Description("Text")]
        public string UserName
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
