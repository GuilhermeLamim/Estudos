using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 16;

            if (idade < 16)
            {
                MessageBox.Show("Você não tem idade para votar.");
            }
            else
            {
                MessageBox.Show("Você já pode votar.");
            }
        }
    }
}
