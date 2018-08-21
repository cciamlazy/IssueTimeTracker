using adobe_color_picker_clone_part_1;

namespace IssueTimeTracker.Forms.Basic_Forms.ColorPicker
{
    partial class ColorPicker
    {
        #region Class Variables

        private System.Windows.Forms.Label m_lbl_CurrentlySelectedColorLabel;
        private System.Windows.Forms.Label m_lbl_ClickDescription;
        private System.Windows.Forms.Label m_lbl_SelectedColor;
        private System.Windows.Forms.Label m_lbl_HexColor;
        private frmColorPicker.eDrawStyle m_eDrawStyle = frmColorPicker.eDrawStyle.Hue;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_lbl_SelectedColor = new System.Windows.Forms.Label();
            this.m_lbl_CurrentlySelectedColorLabel = new System.Windows.Forms.Label();
            this.m_lbl_HexColor = new System.Windows.Forms.Label();
            this.m_lbl_ClickDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lbl_SelectedColor
            // 
            this.m_lbl_SelectedColor.BackColor = System.Drawing.Color.Red;
            this.m_lbl_SelectedColor.Location = new System.Drawing.Point(8, 8);
            this.m_lbl_SelectedColor.Name = "m_lbl_SelectedColor";
            this.m_lbl_SelectedColor.Size = new System.Drawing.Size(80, 56);
            this.m_lbl_SelectedColor.TabIndex = 0;
            this.m_lbl_SelectedColor.Click += new System.EventHandler(this.m_lbl_SelectedColor_Click);
            // 
            // m_lbl_CurrentlySelectedColorLabel
            // 
            this.m_lbl_CurrentlySelectedColorLabel.Location = new System.Drawing.Point(96, 8);
            this.m_lbl_CurrentlySelectedColorLabel.Name = "m_lbl_CurrentlySelectedColorLabel";
            this.m_lbl_CurrentlySelectedColorLabel.Size = new System.Drawing.Size(136, 24);
            this.m_lbl_CurrentlySelectedColorLabel.TabIndex = 1;
            this.m_lbl_CurrentlySelectedColorLabel.Text = "Currently Selected Color:";
            // 
            // m_lbl_HexColor
            // 
            this.m_lbl_HexColor.Location = new System.Drawing.Point(96, 40);
            this.m_lbl_HexColor.Name = "m_lbl_HexColor";
            this.m_lbl_HexColor.Size = new System.Drawing.Size(136, 24);
            this.m_lbl_HexColor.TabIndex = 2;
            this.m_lbl_HexColor.Text = "#xxxxxx";
            // 
            // m_lbl_ClickDescription
            // 
            this.m_lbl_ClickDescription.Location = new System.Drawing.Point(8, 72);
            this.m_lbl_ClickDescription.Name = "m_lbl_ClickDescription";
            this.m_lbl_ClickDescription.Size = new System.Drawing.Size(344, 24);
            this.m_lbl_ClickDescription.TabIndex = 3;
            this.m_lbl_ClickDescription.Text = "(Click on color to open the color picker dialog box.)";
            // 
            // ColorPicker
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(360, 94);
            this.Controls.Add(this.m_lbl_ClickDescription);
            this.Controls.Add(this.m_lbl_HexColor);
            this.Controls.Add(this.m_lbl_CurrentlySelectedColorLabel);
            this.Controls.Add(this.m_lbl_SelectedColor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ColorPicker";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorPicker";
            this.Load += new System.EventHandler(this.ColorPicker_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}