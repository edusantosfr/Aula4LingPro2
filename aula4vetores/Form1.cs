using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4vetores
{
    public partial class Form1 : Form
    {
        Random randNum = new Random();
        int i;
        int[] valor1 = new int [15];
        int[] valor2 = new int[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < 15; i++)
                {
                    valor1[i] = randNum.Next(-10, 10);
                    listBoxValor1.Items.Add(valor1[i]);
                    valor2[i] = randNum.Next(-10, 10);
                    listBoxValor2.Items.Add(valor2[i]);
                    listBoxItems.Items.Add(valor1[i] + valor2[i]);  
                }
            }
            catch (Exception erro)
            {
                erro.Message.ToString();
            }
        }
    }
}
