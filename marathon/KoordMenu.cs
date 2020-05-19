using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon
{
    public partial class KoordMenu : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public KoordMenu()
        {
            InitializeComponent();
            date = new DateTime(2020, 11, 24, 6, 0, 0);
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e) // бегуны
        {

        }

        private void button2_Click(object sender, EventArgs e) // спонсоры
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remaining = date - DateTime.Now;
            Ltimer.Text = "Осталось до марофона: " + remaining.ToString();
        }

        private void button6_Click(object sender, EventArgs e)// logout
        {
            Form fr1 = new Form1();
            fr1.Show();
            Hide();
        }
    }
}
