using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Calculator
{
    public partial class MainFrame : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public MainFrame()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            listPanel.Add(StartPage);
            listPanel.Add(AreaFrame);
            listPanel.Add(VolumeFrame);
            StartPage.BringToFront();
            AreaFrame.Visible = false;
            VolumeFrame.Visible = false;
        }

        private void AreaBtn_Click(object sender, EventArgs e)
        {
            AreaFrame.BringToFront();
            AreaFrame.Visible = true;
            StartPage.SendToBack();
            VolumeFrame.SendToBack();
            StartPage.Visible = false;
            AreaFrame.Visible = true;
            
            VolumeFrame.Visible = false;
        }
    }
}
