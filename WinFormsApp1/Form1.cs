using System.Text.RegularExpressions;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        string Login = "Cavid@gmail.com";
        string password = "Huseyn";

        public Form1()
        {
            InitializeComponent();
        }


        bool isCheck = true;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (isCheck)
            //{
            //    BackgroundImage = Resources._1000076408;
            //    isCheck = false;
            //}
            //else
            //{
            //    BackgroundImage = Resources._149719;
            //    isCheck = true;
            //}

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int r = Random.Shared.Next(0, 256);
            //int g = Random.Shared.Next(0, 256);
            //int b = Random.Shared.Next(0, 256);
            //textBox1.ForeColor = Color.FromArgb(r, g, b);


            // ----------------------------------------------------
            //string pattern = @"(^\+994) \((055|050|070|077|010|099)\)\s(\d{3})\s(\d{2})\s(\d{2})$";
            //var myTextBox = sender as TextBox;

            ////MessageBox.Show(myTextBox.Text);

            //if(Regex.IsMatch(myTextBox.Text, pattern))
            //{
            //    myTextBox.ForeColor = Color.Green;
            //}
            //else
            //{
            //    myTextBox.ForeColor = Color.Red;
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            //MessageBox.Show(textBox1.SelectedText);
            //MessageBox.Show(textBox1.SelectionLength.ToString());
            //MessageBox.Show(textBox1.SelectionStart.ToString());

            textBox1.Select(3, 15);
            MessageBox.Show(textBox1.SelectedText);




            //if (button1.Text == "Show")
            //{
            //    textBox1.PasswordChar = '\0';  // nullterminator
            //    button1.Text = "Hide";
            //}
            //else if (button1.Text == "Hide")
            //{
            //    textBox1.PasswordChar = '*';
            //    button1.Text = "Show";
            //}


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(checkBox1.Checked.ToString());

            if (checkBox1.Checked)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }




        }
        dynamic a;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            a = textBox1;
            Controls.Remove(textBox1);


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Controls.Add(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(radioButton1.Checked)
            //{
            //    MessageBox.Show("salam");
            //}


            //foreach (var item in this.Controls)
            //{
            //    if (item is RadioButton rb)
            //    {
            //        if(rb.Checked && rb.Name=="radioButton4")
            //        {
            //            MessageBox.Show(rb.Name);
            //        }
            //        else  if (rb.Checked && rb.Name == "radioButton5")
            //        {
            //            MessageBox.Show(rb.Name);
            //        }
            //    }
            //}




            //foreach (var item in panel1.Controls)
            //{
            //    if (item is RadioButton rb)
            //    {
            //        if (rb.Checked && rb.Name == "radioButton7")
            //        {
            //            MessageBox.Show("7 secildi");
            //        }
            //        else if (rb.Checked && rb.Name == "radioButton8")
            //        {
            //            MessageBox.Show("8 secdiniz");
            //        }
            //    }
            //}


            MessageBox.Show(dateTimePicker1.Text);

            MessageBox.Show(dateTimePicker1.Value.ToString("dd"));
            MessageBox.Show(dateTimePicker1.Value.Month.ToString());



        }
    }
}