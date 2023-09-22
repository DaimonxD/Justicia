using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Justicia
{
    public partial class Form1 : Form
    {
        PROFUGOS oProfugos;
        DataTable tProfugos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oProfugos = new PROFUGOS();
            tProfugos = oProfugos.GetData();
        }
    }
}
