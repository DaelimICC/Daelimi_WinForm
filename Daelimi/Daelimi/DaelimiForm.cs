using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daelimi
{
    public partial class DaelimiForm : Form
    {
        private String UserQustion = String.Empty;
        public DaelimiForm()
        {
            m_aeroEnabled = true;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();

            Controll_Bar();
            MessageControll();
        }

    }
}
