using System.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace AS2324._3G.MarongiuMarco.battagliaNavale
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;




        public Form1()
        {
            InitializeComponent();

            soundPlayer = new SoundPlayer();

            soundPlayer.SoundLocation = @"C:\Users\coent\OneDrive\Documenti\compiti informatica\console\AS2324.3G.MarongiuMarco.battagliaNavale\sound\cannon-fire-161072.wav";
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }


    }
}