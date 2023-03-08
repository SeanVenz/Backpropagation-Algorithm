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
            nn = new NeuralNet(1, 10, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //initiate inputs, desired outputs and let the algorithm learn
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

                nn.setInputs(0, 71670);
                nn.setDesiredOutput(0, 25.85);
                nn.learn();

                nn.setInputs(0, 72940);
                nn.setDesiredOutput(0, 25.73);
                nn.learn();

                nn.setInputs(0, 74770);
                nn.setDesiredOutput(0, 25.61);
                nn.learn();

                nn.setInputs(0, 76320);
                nn.setDesiredOutput(0, 25.7);
                nn.learn();

                nn.setInputs(0, 78100);
                nn.setDesiredOutput(0, 25.8);
                nn.learn();

                nn.setInputs(0, 70810);
                nn.setDesiredOutput(0, 25.86);
                nn.learn();

                nn.setInputs(0, 74560);
                nn.setDesiredOutput(0, 25.85);
                nn.learn();

                nn.setInputs(0, 76730);
                nn.setDesiredOutput(0, 25.52);
                nn.learn();

                nn.setInputs(0, 77520);
                nn.setDesiredOutput(0, 25.56);
                nn.learn();

                nn.setInputs(0, 83570);
                nn.setDesiredOutput(0, 25.83);
                nn.learn();

                nn.setInputs(0, 84470);
                nn.setDesiredOutput(0, 25.63);
                nn.learn();

                nn.setInputs(0, 88060);
                nn.setDesiredOutput(0, 25.93);
                nn.learn();

                nn.setInputs(0, 97800);
                nn.setDesiredOutput(0, 25.94);
                nn.learn();

                nn.setInputs(0, 104410);
                nn.setDesiredOutput(0, 25.78);
                nn.learn();

                nn.setInputs(0, 113670);
                nn.setDesiredOutput(0, 26.02);
                nn.learn();

                nn.setInputs(0, 124920);
                nn.setDesiredOutput(0, 26.36);
                nn.learn();

                nn.setInputs(0, 136590);
                nn.setDesiredOutput(0, 25.91);
                nn.learn();

                nn.setInputs(0, 142240);
                nn.setDesiredOutput(0, 26.11);
                nn.learn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));

            nn.run();
            textBox3.Text = "" + nn.getOuputData(0);

        }
    }
}
