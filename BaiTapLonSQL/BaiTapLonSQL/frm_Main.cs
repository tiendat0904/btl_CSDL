using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonSQL
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Movies frm = new frm_Movies();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_audiotorium frm = new frm_audiotorium();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_screening_details frm = new frm_screening_details();
            frm.ShowDialog();
        }
    }
}
