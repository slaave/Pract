using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon.Properties
{
    public partial class SponsorForm : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public SponsorForm()
        {
            InitializeComponent();
            date = new DateTime(2020, 11, 24, 6, 0, 0);
            timer1.Start();
        }
        private void SponsorForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) // назад
        {
            Form fr1 = new Form1();
            fr1.Show();
            Hide();
        }
       // double a;
        private void button3_Click(object sender, EventArgs e) // заплатить
        {
            if (NameBox.Text != String.Empty || RunnerBox.Text != String.Empty || CardBox.Text != String.Empty ||
               NomberCardBox.Text != String.Empty || ValidBox1.Text != String.Empty || ValidBox2.Text != String.Empty ||
               CVCBox.Text != String.Empty) 
            {
                if (donateField.Text != String.Empty)
                {
                    double a = Convert.ToDouble(donateField.Text);
                    if (a == 0)
                    {
                        MessageBox.Show("Минимальная сумма 10");
                    }
                    else
                    {
                        tyForm frty = new tyForm();
                        frty.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Вы не ввели сумму пожертвования");
                }
            }
            else
            {
                MessageBox.Show("Все поля обязательны для заполнения");
            }

        }
        private void buttonPlus_Click(object sender, EventArgs e) // +
        {
            if (donateField.Text != String.Empty)
            {
                double a;
                a = Convert.ToDouble(donateField.Text);
                donateField.Text = Convert.ToString(a + 10);
            }
            else
            donateField.Text = Convert.ToString(10);
        }

        private void buttonMinus_Click(object sender, EventArgs e) // -
        {
            if (donateField.Text != String.Empty)
            {
                double a = Convert.ToDouble(donateField.Text); 
                if (a == 0)
                {
                    MessageBox.Show("Минимальная сумма 10");
                }
                else
                {
                    if (a > 10 & a != 10)
                    {
                        a = Convert.ToDouble(donateField.Text);
                        donateField.Text = Convert.ToString(a - 10);
                    }
                }
            }
            else
                MessageBox.Show("Вы не ввели сумму пожертвования");
            }
        


       private void donateField_KeyPress(object sender, KeyPressEventArgs e) // ввод только цифр в поле с суммой пожертвования
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remaining = date - DateTime.Now;
            Ltimer.Text = "Осталось до марофона: " + remaining.ToString();
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NameBox.MaxLength = 16;
        }

        private void CardBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NomberCardBox.MaxLength = 1;
        }

        private void ValidBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidBox1.MaxLength = 1;
        }

        private void ValidBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidBox2.MaxLength = 4;
        }

        private void CVCBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CVCBox.MaxLength = 3;
        }

        private void NomberCardBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NomberCardBox.MaxLength = 1;
        }

        private void button1_Click(object sender, EventArgs e) // info
        {
            MessageBox.Show("Информация");
        }
    }
}
