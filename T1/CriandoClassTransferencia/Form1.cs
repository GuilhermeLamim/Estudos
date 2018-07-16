using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriandoClassTransferencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta Guilherme = new Conta(); 
            Conta Mauricio = new Conta();

            Guilherme.saldo = 2000.0;
            Mauricio.saldo = 3000.0;

            Guilherme.Transferencia(500.0, Mauricio);

            MessageBox.Show("O saldo do Guilheme é de: " + Guilherme.saldo);
            MessageBox.Show("O saldo do Mauricio é de: " + Mauricio.saldo);
            
        }
    }
}
