using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Conta c1 = new ContaPoupanca();
             c1.Deposita(100.0);
             
             MessageBox.Show("conta poupança c1 = " + c1.Saldo);

             Conta c2 = new Conta();
             c2.Deposita(100.0);
            
             MessageBox.Show("conta c2 = " + c2.Saldo); 


        }
    }
}
