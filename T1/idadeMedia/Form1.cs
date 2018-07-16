using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idadeMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aline = 40;
            int silvana = 45;
            int juliana = 11;

            double idadeMedia = (aline + silvana + juliana) / 3;

            MessageBox.Show("A idade média é: " + idadeMedia);
        }
    }
}
