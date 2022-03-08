using System;
using System.Windows.Forms;

namespace Daelimi
{
    public partial class DaelimiForm : Form
    {
        private String UserQustion = String.Empty;
        private String AIAnsower = String.Empty;
        public DaelimiForm()
        {
            InitializeComponent();
            Controll_Bar();
            MessageControll();
        }
    }
}
