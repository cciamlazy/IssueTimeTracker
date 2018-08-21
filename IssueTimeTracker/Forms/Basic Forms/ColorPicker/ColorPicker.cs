using adobe_color_picker_clone_part_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Basic_Forms.ColorPicker
{
    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();

            //	Display the color hex value
            string red = Convert.ToString(m_lbl_SelectedColor.BackColor.R, 16);
            if (red.Length < 2) red = "0" + red;
            string green = Convert.ToString(m_lbl_SelectedColor.BackColor.G, 16);
            if (green.Length < 2) green = "0" + green;
            string blue = Convert.ToString(m_lbl_SelectedColor.BackColor.B, 16);
            if (blue.Length < 2) blue = "0" + blue;

            m_lbl_HexColor.Text = "#" + red.ToUpper() + green.ToUpper() + blue.ToUpper();
            m_lbl_HexColor.Update();
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {

        }

        private void m_lbl_SelectedColor_Click(object sender, System.EventArgs e)
        {
            frmColorPicker ColorDialog = new frmColorPicker(m_lbl_SelectedColor.BackColor);
            ColorDialog.DrawStyle = m_eDrawStyle;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                //	Display the color
                m_lbl_SelectedColor.BackColor = ColorDialog.PrimaryColor;

                //	Display the color hex value
                string red = Convert.ToString(m_lbl_SelectedColor.BackColor.R, 16);
                if (red.Length < 2) red = "0" + red;
                string green = Convert.ToString(m_lbl_SelectedColor.BackColor.G, 16);
                if (green.Length < 2) green = "0" + green;
                string blue = Convert.ToString(m_lbl_SelectedColor.BackColor.B, 16);
                if (blue.Length < 2) blue = "0" + blue;

                m_lbl_HexColor.Text = "#" + red.ToUpper() + green.ToUpper() + blue.ToUpper();
                m_lbl_HexColor.Update();

                m_eDrawStyle = ColorDialog.DrawStyle;
            }
        }
    }
}
