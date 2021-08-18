using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_PictureViewer
{
    public partial class Form_pictureViewer : Form
    {
        public Form_pictureViewer()
        {
            InitializeComponent();
        }

        private void Form_pictureViewer_Load(object sender, EventArgs e)
        {

        }

        private void Button_showPicture_Click(object sender, EventArgs e)
        {
            //Show the open file dialog. 
            //If user selects 'OK', display the picture selected.
            if(OpenFileDialog_selectPicture.ShowDialog() == DialogResult.OK)
            {
                PictureBox_main.Load(OpenFileDialog_selectPicture.FileName);
            }
        }

        private void Button_clearPicture_Click(object sender, EventArgs e)
        {
            //Clear the picture.
            PictureBox_main.Image = null;
        }

        private void Button_setBackgroundColor_Click(object sender, EventArgs e)
        {
            //Show the color select dialog.
            //If user selects OK, display the color selected.
            if(ColorDialogue_background.ShowDialog() == DialogResult.OK)
            {
                PictureBox_main.BackColor = ColorDialogue_background.Color;
            }
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            //Close the Form.
            this.Close();
        }

        private void CheckBox_stretch_CheckedChanged(object sender, EventArgs e)
        {
            //If 'stretch' box is checked, stretch the picture box.
            //If 'stretch' box is unchecked, normalize the picture box.
            if (CheckBox_stretch.Checked)
            {
                PictureBox_main.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PictureBox_main.SizeMode = PictureBoxSizeMode.Normal;
            }
        }


    }
}
