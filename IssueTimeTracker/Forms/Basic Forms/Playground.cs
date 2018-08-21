using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Basic_Forms
{
    public partial class Playground : Form
    {
        public Playground()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox3.Text = Encryption.AESThenHMAC.SimpleEncryptWithPassword(textBox2.Text, textBox1.Text);
                textBox4.Text = Encryption.AESThenHMAC.SimpleDecryptWithPassword(textBox3.Text, textBox1.Text);
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
