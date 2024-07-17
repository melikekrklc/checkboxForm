using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formnet3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)//kutucuğun işaretli olduğu anlamına geliyor.
            {
                MessageBox.Show("Sözleşme onyalandı.");
            }
            
            else
            {
                MessageBox.Show("Lütfen sözleşmeyi okuyup onay kutusunu işaretleyiniz.");
            }
        }
    }
}
