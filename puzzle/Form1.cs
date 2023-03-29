namespace puzzle
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        private int count = 0;
        public void main()
        {
            Random random = new Random();
            List<int> l = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 9 };
            List<int> rl = new List<int>();
            int lcount = l.Count - 1;
            for (var i = 0; i < lcount; i++)
            {
                int r = random.Next(0, l.Count);
                rl.Add(l[r]);
                l.RemoveAt(r);
            }
            b1.ImageIndex = rl[0];
            b2.ImageIndex = rl[1];
            b3.ImageIndex = rl[2];
            b4.ImageIndex = rl[3];
            b5.ImageIndex = rl[4];
            b6.ImageIndex = rl[5];
            b7.ImageIndex = rl[6];
            b8.ImageIndex = rl[7];
            b9.ImageIndex = l[0];
            updata();
        }
        public Form1()
        {
            InitializeComponent();
            main();
            myTimer.Interval = 1000;
            myTimer.Tick += new EventHandler(myTimer_Tick);
            myTimer.Start();
        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            count++;
            label13.Text = count.ToString();
        }
        public void updata()
        {
            label1.Text = b1.ImageIndex.ToString();
            label2.Text = b2.ImageIndex.ToString();
            label3.Text = b3.ImageIndex.ToString();
            label4.Text = b4.ImageIndex.ToString();
            label5.Text = b5.ImageIndex.ToString();
            label6.Text = b6.ImageIndex.ToString();
            label7.Text = b7.ImageIndex.ToString();
            label8.Text = b8.ImageIndex.ToString();
            label9.Text = b9.ImageIndex.ToString();
            if (b1.ImageIndex == 0 && b2.ImageIndex == 1 && b3.ImageIndex == 2 && b4.ImageIndex == 3 && b5.ImageIndex == 4 && b6.ImageIndex == 5 && b7.ImageIndex == 6 && b8.ImageIndex == 7 && b9.ImageIndex == 9)
            {
                label10.Text = "win";
                myTimer.Stop();
            }
            else
            {
                label10.Text = "";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (b5.ImageIndex == 9)//放旁邊
            {
                b5.ImageIndex = b8.ImageIndex;//旁邊=自己
                b8.ImageIndex = 9;//自己=9
            }
            if (b7.ImageIndex == 9)//放旁邊
            {
                b7.ImageIndex = b8.ImageIndex;//旁邊=自己
                b8.ImageIndex = 9;//自己=9
            }
            if (b9.ImageIndex == 9)//放旁邊
            {
                b9.ImageIndex = b8.ImageIndex;//旁邊=自己
                b8.ImageIndex = 9;//自己=9
            }
            updata();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (b4.ImageIndex == 9)//放旁邊
            {
                b4.ImageIndex = b7.ImageIndex;//旁邊=自己
                b7.ImageIndex = 9;//自己=9
            }
            if (b8.ImageIndex == 9)//放旁邊
            {
                b8.ImageIndex = b7.ImageIndex;//旁邊=自己
                b7.ImageIndex = 9;//自己=9
            }
            updata();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b2.ImageIndex == 9)
            {
                b2.ImageIndex = b1.ImageIndex;
                b1.ImageIndex = 9;
            }
            if (b4.ImageIndex == 9)
            {
                b4.ImageIndex = b1.ImageIndex;
                b1.ImageIndex = 9;
            }
            updata();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b1.ImageIndex == 9)//放旁邊
            {
                b1.ImageIndex = b2.ImageIndex;//旁邊=自己
                b2.ImageIndex = 9;//自己=9
            }
            if (b3.ImageIndex == 9)
            {
                b3.ImageIndex = b2.ImageIndex;
                b2.ImageIndex = 9;
            }
            if (b5.ImageIndex == 9)
            {
                b5.ImageIndex = b2.ImageIndex;
                b2.ImageIndex = 9;
            }
            updata();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b2.ImageIndex == 9)//放旁邊
            {
                b2.ImageIndex = b3.ImageIndex;//旁邊=自己
                b3.ImageIndex = 9;//自己=9
            }
            if (b6.ImageIndex == 9)//放旁邊
            {
                b6.ImageIndex = b3.ImageIndex;//旁邊=自己
                b3.ImageIndex = 9;//自己=9
            }
            updata();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (b1.ImageIndex == 9)//放旁邊
            {
                b1.ImageIndex = b4.ImageIndex;//旁邊=自己
                b4.ImageIndex = 9;//自己=9
            }
            if (b5.ImageIndex == 9)//放旁邊
            {
                b5.ImageIndex = b4.ImageIndex;//旁邊=自己
                b4.ImageIndex = 9;//自己=9
            }
            if (b7.ImageIndex == 9)//放旁邊
            {
                b7.ImageIndex = b4.ImageIndex;//旁邊=自己
                b4.ImageIndex = 9;//自己=9
            }
            updata();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (b2.ImageIndex == 9)//放旁邊
            {
                b2.ImageIndex = b5.ImageIndex;//旁邊=自己
                b5.ImageIndex = 9;//自己=9
            }
            if (b4.ImageIndex == 9)//放旁邊
            {
                b4.ImageIndex = b5.ImageIndex;//旁邊=自己
                b5.ImageIndex = 9;//自己=9
            }
            if (b6.ImageIndex == 9)//放旁邊
            {
                b6.ImageIndex = b5.ImageIndex;//旁邊=自己
                b5.ImageIndex = 9;//自己=9
            }
            if (b8.ImageIndex == 9)//放旁邊
            {
                b8.ImageIndex = b5.ImageIndex;//旁邊=自己
                b5.ImageIndex = 9;//自己=9
            }
            updata();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (b3.ImageIndex == 9)//放旁邊
            {
                b3.ImageIndex = b6.ImageIndex;//旁邊=自己
                b6.ImageIndex = 9;//自己=9
            }
            if (b5.ImageIndex == 9)//放旁邊
            {
                b5.ImageIndex = b6.ImageIndex;//旁邊=自己
                b6.ImageIndex = 9;//自己=9
            }
            if (b9.ImageIndex == 9)//放旁邊
            {
                b9.ImageIndex = b6.ImageIndex;//旁邊=自己
                b6.ImageIndex = 9;//自己=9
            }
            updata();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (b6.ImageIndex == 9)//放旁邊
            {
                b6.ImageIndex = b9.ImageIndex;//旁邊=自己
                b9.ImageIndex = 9;//自己=9
            }
            if (b8.ImageIndex == 9)//放旁邊
            {
                b8.ImageIndex = b9.ImageIndex;//旁邊=自己
                b9.ImageIndex = 9;//自己=9
            }
            updata();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            b1.ImageIndex = 0;
            b2.ImageIndex = 1;
            b3.ImageIndex = 2;
            b4.ImageIndex = 3;
            b5.ImageIndex = 4;
            b6.ImageIndex = 5;
            b7.ImageIndex = 6;
            b8.ImageIndex = 7;
            b9.ImageIndex = 9;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            main();
            myTimer.Interval = 0;
        }


    }
}