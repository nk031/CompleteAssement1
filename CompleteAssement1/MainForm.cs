using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAssement1
{
    public partial class MainForm : Form
    {
        LogicClass Logic = new LogicClass();


        public MainForm()
        {
            InitializeComponent();
        }

        private void GunShootBt_Click(object sender, EventArgs e)
        {

            SoundPlayer sound = new SoundPlayer(CompleteAssement1.Properties.Resources.GunSound);
            sound.Play();
            Logic.GunShootBt();


        }

        private void SoundPlayer()
        {
            throw new NotImplementedException();
        }

        private void ShootAwayBt_Click(object sender, EventArgs e)
        {

            Logic.ShootAwayBt();

        }
    }
}
