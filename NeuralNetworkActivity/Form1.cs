using Backprop;
namespace NeuralNetworkActivity
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        int epochCount;
        int[,] desiredOutcome;
    public Form1()
        {
            InitializeComponent();

            desiredOutcome = new int[16, 5]
            {
                {0,0,0,0,0 },
                {0,0,0,1,0 },
                {0,0,1,0,0 },
                {0,0,1,1,0 },
                {0,1,0,0,0 },
                {0,1,1,1,0 },
                {0,1,1,0,0 },
                {0,1,0,1,0 },
                {1,0,1,0,0 },
                {1,0,1,1,0 },
                {1,0,0,0,0 },
                {1,0,1,1,0 },
                {1,1,1,0,0 },
                {1,1,0,1,0 },
                {1,1,1,0,0 },
                {1,1,1,1,1 }
            };
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 4, 1);
            epochCount = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (Checker() != true)
            {
                Train();
                epochCount++;
            }
            label5.Text = epochCount.ToString();

        }

        //Trains 1 epoch
        private void Train()
        {
            for (int i = 0; i < 16; i++)
            {
                nn.setInputs(0, desiredOutcome[i,0]);
                nn.setInputs(1, desiredOutcome[i,1]);
                nn.setInputs(2, desiredOutcome[i,2]);
                nn.setInputs(3, desiredOutcome[i,3]);
                nn.setDesiredOutput(0, desiredOutcome[i, 4]);
                nn.learn();
            }
        }

        private bool Checker()
        {
            for (int i = 0; i < 16; i++)
            {
                nn.setInputs(0, desiredOutcome[i,0]);
                nn.setInputs(1, desiredOutcome[i,1]);
                nn.setInputs(2, desiredOutcome[i,2]);
                nn.setInputs(3, desiredOutcome[i,3]);
                nn.run();
                if (Math.Round(nn.getOuputData(0)) != desiredOutcome[i, 4])
                    return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox4.Text));
            nn.setInputs(3, Convert.ToDouble(textBox5.Text));

            nn.run();
            textBox3.Text = "" + nn.getOuputData(0);
            textBox6.Text = "" + Convert.ToInt32(nn.getOuputData(0));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
