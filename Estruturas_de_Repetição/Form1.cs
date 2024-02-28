using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estruturas_de_Repetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {

            int num1, num2, Qpares;

            num1 = int.Parse(txt_inicial.Text);
            num2 = int.Parse(txt_final.Text);


            for(Qpares = num1; Qpares <= num2; Qpares++)
            {
                if (num2 <= num1 && num1 <= 0 && num2 <= 0) 
                MessageBox.Show("Numeros Incorretos");

                else if 
                    (Qpares % 2 ==0)
                    MessageBox.Show("numeros incorretos");
            }
            Qpares = Qpares * 2;
            lbl_imprimir.Text= Qpares.ToString();
        }
    }
}
