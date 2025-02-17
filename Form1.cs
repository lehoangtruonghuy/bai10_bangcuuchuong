
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai10_bangcuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lsbBCC.Items.Clear();
            int so = Convert.ToInt32(txtNHAP.Text);

            for (int i = 1; i <= 10; i++)
            {
                lsbBCC.Items.Add(so + "x" + i + "=" + so * i);
            }
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            int so_nhan;
            int so = Convert.ToInt32(txtNHAP.Text);
            so = 2;
            do
            {
                so_nhan = 1;
                do
                {
                    lsbBCC.Items.Add(so + "x" + so_nhan + "=" + so * so_nhan);
                    so_nhan++;
                }
                while (so_nhan <= 10);
                lsbBCC.Items.AddRange();
                so_nhan++;
            } while (so <= 9);
        }
    }
}
