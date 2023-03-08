using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BackPropagation_Calculation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(1, 5, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Convert.ToInt32(textBox4.Text); i++)
            {
                nn.setInputs(0, 72430);
                nn.setDesiredOutput(0, 25.66);
                nn.learn();

                nn.setInputs(0, 73190);
                nn.setDesiredOutput(0, 25.79);
                nn.learn();

                nn.setInputs(0, 71670);
                nn.setDesiredOutput(0, 25.85);
                nn.learn();

                nn.setInputs(0, 72940);
                nn.setDesiredOutput(0, 25.73);
                nn.learn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));

            nn.run();
            textBox3.Text = "" + nn.getOuputData(0) * 25.822;

        }
    }
}
