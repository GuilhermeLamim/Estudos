using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca();
            ContaInvestimentos ci = new ContaInvestimentos();
            cp.Deposita(10.0);
            ci.Deposita(100.0);
            TotalizadorDeTributos t = new TotalizadorDeTributos();
            t.Acumula(cp);
            t.Acumula(ci);

            MessageBox.Show("Saldo " + t.Total);
        }
    }
}
