using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Test_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(2);
            if (progressBar2.Value == 100 )
            {
                timer1.Stop();
                MessageBox.Show("Done");
                this.Hide();
            }
        }

       
    }
}
