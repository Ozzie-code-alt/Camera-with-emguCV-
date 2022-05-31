using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Camera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FaceRec camera = new FaceRec();
        private void btnCam_Click(object sender, EventArgs e)
        {
            camera.openCamera(pictureBox1,pictureBox2);
            camera.Save_IMAGE(textBox1.Text);
            camera.isTrained = true;
        }

    

    }
}
