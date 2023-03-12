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
                nn.setInputs(0, 41080);
                nn.setDesiredOutput(0, 26.08);
                nn.learn();

                nn.setInputs(0, 40650);
                nn.setDesiredOutput(0, 26.07);
                nn.learn();

                nn.setInputs(0, 44020);
                nn.setDesiredOutput(0, 25.91);
                nn.learn();

                nn.setInputs(0, 47800);
                nn.setDesiredOutput(0, 26.02);
                nn.learn();

                nn.setInputs(0, 51510);
                nn.setDesiredOutput(0, 26.14);
                nn.learn();

                nn.setInputs(0, 61750);
                nn.setDesiredOutput(0, 26.01);
                nn.learn();

                nn.setInputs(0, 67220);
                nn.setDesiredOutput(0, 25.88);
                nn.learn();

                nn.setInputs(0, 74790);
                nn.setDesiredOutput(0, 25.97);
                nn.learn();

                nn.setInputs(0, 74220);
                nn.setDesiredOutput(0, 26.65);
                nn.learn();

                nn.setInputs(0, 71580);
                nn.setDesiredOutput(0, 26);
                nn.learn();

                nn.setInputs(0, 72100);
                nn.setDesiredOutput(0, 26.13);
                nn.learn();

                nn.setInputs(0, 70480);
                nn.setDesiredOutput(0, 26.19);
                nn.learn();

                nn.setInputs(0, 71570);
                nn.setDesiredOutput(0, 26.07);
                nn.learn();

                nn.setInputs(0, 73630);
                nn.setDesiredOutput(0, 25.95);
                nn.learn();

                nn.setInputs(0, 75140);
                nn.setDesiredOutput(0, 26.04);
                nn.learn();

                nn.setInputs(0, 76670);
                nn.setDesiredOutput(0, 26.14);
                nn.learn();

                nn.setInputs(0, 69470);
                nn.setDesiredOutput(0, 26.2);
                nn.learn();

                nn.setInputs(0, 73220);
                nn.setDesiredOutput(0, 26.19);
                nn.learn();

                nn.setInputs(0, 75150);
                nn.setDesiredOutput(0, 25.87);
                nn.learn();

                nn.setInputs(0, 76300);
                nn.setDesiredOutput(0, 25.9);
                nn.learn();

                nn.setInputs(0, 81930);
                nn.setDesiredOutput(0, 26.17);
                nn.learn();

                nn.setInputs(0, 82629);
                nn.setDesiredOutput(0, 25.93);
                nn.learn();

                nn.setInputs(0, 86180);
                nn.setDesiredOutput(0, 26.27);
                nn.learn();

                nn.setInputs(0, 95500);
                nn.setDesiredOutput(0, 26.28);
                nn.learn();

                nn.setInputs(0, 101820);
                nn.setDesiredOutput(0, 26.15);
                nn.learn();

                nn.setInputs(0, 111010);
                nn.setDesiredOutput(0, 26.36);
                nn.learn();

                nn.setInputs(0, 121960);
                nn.setDesiredOutput(0, 26.7);
                nn.learn();

                nn.setInputs(0, 133500);
                nn.setDesiredOutput(0, 26.26);
                nn.learn();

                nn.setInputs(0, 138570);
                nn.setDesiredOutput(0, 26.45);
                nn.learn();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));

            nn.run();
            textBox3.Text = "" + nn.getOuputData(0) * 26.13724138;

        }
    }
}
