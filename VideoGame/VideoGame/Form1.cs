using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGame
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer _player = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_player == null) _player = new WMPLib.WindowsMediaPlayer();

            _player.URL = "Kalimba.mp3";
            _player.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _player.controls.stop();

            ShotCollection shots = new ShotCollection();

            shots.Shots.Add(new Shot()
            {
                TimeOfShot = DateTime.Now,
                PlayerNumber = 1,
                Location = new Point(100, 500),
                Team = "Team A",
                ShotMade = true
            });

            shots.SaveToFile("Game1.xml");
        }
    }
}
