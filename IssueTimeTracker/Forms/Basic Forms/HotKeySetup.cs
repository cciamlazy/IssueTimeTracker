using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class HotKeySetup : Form
    {
        NewSettings settings;
        HotKeyLayout _Hotkey;
        private bool isChangingKey = false;

        public HotKeySetup(NewSettings parent, HotKeyLayout hotkey)
        {
            InitializeComponent();
            Ctrl.Checked = hotkey.Ctrl;
            Shift.Checked = hotkey.Shift;
            Alt.Checked = hotkey.Alt;
            KeyButton.Text = hotkey.Key.ToString();
            settings = parent;
            _Hotkey = hotkey;
        }

        private void OnWindowKeyUp(object sender, KeyPressEventArgs e)
        {
            if (isChangingKey)
            {
                Keys k = (Keys)char.ToUpper(e.KeyChar);
                _Hotkey.Key = k;
                KeyButton.Text = char.ToUpper(e.KeyChar).ToString();
                isChangingKey = false;
            }
        }

        private void HotKeySetup_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void KeyButton_Click(object sender, EventArgs e)
        {
            isChangingKey = true;
            KeyButton.Text = "Press Any Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Hotkey.Ctrl = Ctrl.Checked;
            _Hotkey.Shift = Shift.Checked;
            _Hotkey.Alt = Alt.Checked;
            settings.UpdateHotkey(_Hotkey);
            this.Close();
        }

        private void HotKeySetup_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(OnWindowKeyUp);
        }
    }
}
