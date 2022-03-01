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
        private String test = "장소를 찾고 싶다면 \"장소찾기\"\n문의를 하고 싶다면 \"문의하기\"";
        private int filter = 0;
        public DaelimiForm()
        {
            InitializeComponent();
            Controll_Bar();
            MessageControll();
        }
    }
}
