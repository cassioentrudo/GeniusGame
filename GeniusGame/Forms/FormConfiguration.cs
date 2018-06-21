using System.Windows.Forms;

namespace GeniusGame
{
    public partial class FormConfiguration : Form
    {
        private string redButtonSongPath;
        private string blueButtonSongPath;
        private string yellowButtonSongPath;
        private string greenButtonSongPath;
        private bool mute = false;

        public string RedButtonSongPath
        {
            get { return this.redButtonSongPath; }
            set { this.redButtonSongPath = value; }
        }

        public string BlueButtonSongPath
        {
            get { return this.blueButtonSongPath; }
            set { this.blueButtonSongPath = value; }
        }

        public string YellowButtonSongPath
        {
            get { return this.yellowButtonSongPath; }
            set { this.yellowButtonSongPath = value; }
        }

        public string GreenButtonSongPath
        {
            get { return this.greenButtonSongPath; }
            set { this.greenButtonSongPath = value; }
        }

        public bool Mute
        {
            get { return this.mute; }
            set { this.mute = value; }
        }

        public FormConfiguration()
        {
            InitializeComponent();

            this.redButtonSongPath = Properties.Settings.Default.RedButtonSong;
            this.blueButtonSongPath = Properties.Settings.Default.BlueButtonSong;
            this.yellowButtonSongPath = Properties.Settings.Default.YellowButtonSong;
            this.greenButtonSongPath = Properties.Settings.Default.GreenButtonSong;
            this.mute = false;
    }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            this.redButtonSongPath = this.textBoxRedPathSong.Text;
            this.blueButtonSongPath = this.textBoxBluePathSong.Text;
            this.yellowButtonSongPath = this.textBoxYellowPathSong.Text;
            this.greenButtonSongPath = this.textBoxGreenPathSong.Text;
            this.mute = this.checkBoxMute.Checked;
        }

        private string FindFile()
        {
            string songPath = string.Empty;

            this.openFileDialog1.Title = "Seleção do arquivo de som";
            this.openFileDialog1.Filter = "Som|*.wav";

            DialogResult res = this.openFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                songPath = this.openFileDialog1.FileName;
            }

            return songPath;
        }

        private void buttonFindYellow_Click(object sender, System.EventArgs e)
        {            
            this.yellowButtonSongPath = FindFile();
            this.UpdateObjects();
        }

        private void buttonFindRed_Click(object sender, System.EventArgs e)
        {
            this.redButtonSongPath = FindFile();
            this.UpdateObjects();
        }

        private void buttonFindGreen_Click(object sender, System.EventArgs e)
        {
            this.greenButtonSongPath = FindFile();
            this.UpdateObjects();
        }

        private void buttonFindBlue_Click(object sender, System.EventArgs e)
        {
            this.blueButtonSongPath = FindFile();
            this.UpdateObjects();
        }

        private void FormConfiguration_Shown(object sender, System.EventArgs e)
        {
            this.UpdateObjects();
        }

        private void UpdateObjects()
        {
            this.textBoxBluePathSong.Text = this.blueButtonSongPath;
            this.textBoxGreenPathSong.Text = this.greenButtonSongPath;
            this.textBoxRedPathSong.Text = this.redButtonSongPath;
            this.textBoxYellowPathSong.Text = this.yellowButtonSongPath;
        }

        private void checkBoxMute_CheckedChanged(object sender, System.EventArgs e)
        {
            this.mute = this.checkBoxMute.Checked;
        }
    }
}
