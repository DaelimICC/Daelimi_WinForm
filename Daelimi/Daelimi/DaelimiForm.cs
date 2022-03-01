using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private String UserQustion = String.Empty;
        private String AIAnsower = "안녕하세요 대림이봇입니다.";
        public DaelimiForm()
        {
            InitializeComponent();
            Controll_Bar();
            MessageControll();
        }
    }
}
