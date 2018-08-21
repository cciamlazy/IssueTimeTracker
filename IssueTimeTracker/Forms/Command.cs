using IssueTimeTracker.Classes.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace IssueTimeTracker.Forms
{
    public partial class Command : Form
    {
        CommandHelper command = new CommandHelper();

        private static Command instance;

        public Command()
        {
            InitializeComponent();
            if (instance == null)
                instance = this;
        }

        public static void WriteLine(string line)
        {
            if(instance != null)
                instance.messages.Items.Add(line + "\n");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnterCommand();
            }
        }

        private void EnterCommand()
        {
            string[] builder = textBox1.Text.Split(' ');
            string[] parameters = new string[builder.Length - 1];
            for (int i = 1; i < builder.Length; i++)
                parameters[i - 1] = builder[i];

            messages.Items.Add(command.HandleCommand(builder[0], parameters));
            textBox1.Text = "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            EnterCommand();
        }

        private void Command_Load(object sender, EventArgs e)
        {

        }
    }
}
