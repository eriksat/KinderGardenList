using System;
using System.Windows.Forms;
using KinderGartenList.AddValue;

namespace KinderGartenList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddValueN _addValue = new AddValueN();
            _addValue.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
