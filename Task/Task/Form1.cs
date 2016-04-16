using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {

        TelephoneDirectory telephoneDirector = new TelephoneDirectory();

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Types));
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string address = adressTextBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);
                int mobile = Convert.ToInt32(mobileTextBox.Text);

                nameTextBox.Clear();
                adressTextBox.Clear();
                ageTextBox.Clear();
                mobileTextBox.Clear();
                telephoneDirector.accounts.Add(new Person(name, address, age, mobile, (Types)Enum.Parse(typeof(Types), comboBox1.Text)));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in telephoneDirector)
            {
                
                sb.AppendLine(item.ToString());
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
