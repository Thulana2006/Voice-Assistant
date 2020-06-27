using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;

namespace Voice_Recognizing_project
{
    public partial class Settings : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();

        public Settings()
        {
            InitializeComponent();
        }

        private void sliderTrans_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            Properties.Settings.Default.Transparency = sliderTrans.Value;
            lblVal.Text = sliderTrans.Value + " %";
        }

        private void Settings_Load(object sender, System.EventArgs e)
        {
            //Getting the installed voices Parsing to the combo box
            System.Collections.ObjectModel.ReadOnlyCollection<InstalledVoice> voices = ss.GetInstalledVoices();
           
            foreach (InstalledVoice voice in voices)
                cmbovoice.Items.Add(voice.VoiceInfo.Name);

            cmbovoice.PromptText = Properties.Settings.Default.Voice;
            cmbovoice.SelectedText = Properties.Settings.Default.Voice;
            
            //Setting up the label && slider
            lblVal.Text = Convert.ToString(Properties.Settings.Default.Transparency) + " %";
            sliderTrans.Value = Convert.ToInt32(Properties.Settings.Default.Transparency);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnEnable = true;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void cmbovoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Voice = cmbovoice.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Index = 3;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxCmd.Text != "" && txtBoxPath.Text != "")
            {
                if (File.Exists(txtBoxPath.Text))
                    Properties.Settings.Default.Index = 2;

                else
                    tooltippath.Show(txtBoxPath, "Invalid application path");
            }

            else 
            {
                if(txtBoxCmd.Text == "")
                    tooltipError.Show(txtBoxCmd, "Enter the Command string.");
                if (txtBoxPath.Text == "")
                    tooltippath.Show(txtBoxPath, "Enter the app path");

                txtBoxCmd.LineIdleColor = Color.FromArgb(192, 60, 30);
                txtBoxCmd.HintForeColor = txtBoxCmd.LineIdleColor;
                txtBoxPath.LineIdleColor = txtBoxCmd.LineIdleColor;
                txtBoxPath.HintForeColor = txtBoxCmd.HintForeColor;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                txtBoxPath.Text = ofd.FileName;
            }
            Properties.Settings.Default.Index = 1;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.btnEnable = true;
            Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtBoxCmd.isOnFocused)
                tooltipError.Hide();
            if (txtBoxPath.isOnFocused)
                tooltippath.Hide();
        }

        private void txtBoxCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBoxCmd.LineIdleColor = Color.Gray;
            txtBoxCmd.ForeColor = Color.Silver;
        }

        private void txtBoxPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBoxPath.LineIdleColor = Color.Gray;
            txtBoxPath.ForeColor = Color.Silver;
        }

        private void tooltippath_Popup(object sender, Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs e)
        {
            timer3.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tooltipError.Hide();
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tooltippath.Hide();
            timer3.Enabled = false;
        }

        private void tooltipError_Popup(object sender, Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs e)
        {
            timer2.Enabled = true;
        }

        private void sliderSound_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            int value = sliderSound.Value;
            lblSound.Text = value.ToString();
            Properties.Settings.Default.Volume = value;

            if (value >= 75)
            {
                picBoxSound.BackgroundImage = Image.FromFile(@"C:\Users\Thulana\Desktop\Voice Recognizing project\Resources\sound - 4.png");
            }
            else if (value >= 42)
            {
                picBoxSound.BackgroundImage = Image.FromFile(@"C:\Users\Thulana\Desktop\Voice Recognizing project\Resources\sound - 3.png");
            }
            else if (value >= 16)
            {
                picBoxSound.BackgroundImage = Image.FromFile(@"C:\Users\Thulana\Desktop\Voice Recognizing project\Resources\sound - 2.png");
            }
            else if (value >= 1)
            {
                picBoxSound.BackgroundImage = Image.FromFile(@"C:\Users\Thulana\Desktop\Voice Recognizing project\Resources\sound - 1.png");
            }
            else if (value == 0)
            {
                picBoxSound.BackgroundImage = Image.FromFile(@"C:\Users\Thulana\Desktop\Voice Recognizing project\Resources\sound - 0.png");
            }
        }
    }
}