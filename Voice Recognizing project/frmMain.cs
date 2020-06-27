using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using Microsoft.Win32;
using System.Threading;
using System.Web;

namespace Voice_Recognizing_project
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        SpeechRecognitionEngine normal = new SpeechRecognitionEngine();
        SpeechRecognitionEngine shutdown = new SpeechRecognitionEngine();
        SpeechRecognitionEngine restart = new SpeechRecognitionEngine();
        SpeechSynthesizer ss = new SpeechSynthesizer();
        private bool rec = false;

        public Form1()
        {
            InitializeComponent();
            Properties.Settings.Default.btnEnable = true;

            //setting the voice
            ss.SelectVoice("Microsoft Zira Desktop");

            //Commmand speech recognition engine
            Choices cmd = new Choices();
            cmd.Add(new string[] { "open bluetooth settings", "open whatsapp", "lock my computer", "close edit mode", "go to edit mode", "open youtube", "show my weather", "check my emails", "shutdown", "restart", "Exit", "open notepad", "open google", "open visual studio express", "open visual studio community", "open file explorer", "open photoshop", "open premier", "close notepad", "close google", "close visual studio express", "close visual studio community", "close file explorer", "close photoshop", "close premier", "stop talking", "minimize assistant", "open assistant", "open candela", "close candela" });
            GrammarBuilder grmbui = new GrammarBuilder();
            grmbui.Append(cmd);
            Grammar grm = new Grammar(grmbui);
            sre.LoadGrammar(grm);
            sre.SpeechRecognized += sre_SpeechRecognized;

            //onOff speech recognition engine
            Choices onOff = new Choices();
            onOff.Add(new string[] { "Hey assistant" });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(onOff);
            Grammar gr = new Grammar(gb);
            normal.LoadGrammar(gr);
            normal.SpeechRecognized += normal_SpeechRecognized;

            //shutdown YesNo speech recognition engine
            Choices cmd2 = new Choices();
            cmd2.Add(new string[] { "yes", "no" });
            GrammarBuilder gb2 = new GrammarBuilder();
            gb2.Append(cmd2);
            Grammar g2 = new Grammar(gb2);
            shutdown.LoadGrammar(g2);
            shutdown.SpeechRecognized += shutdown_SpeechRecognized;

            //restart YesNo speech recognition engine
            Choices cmd3 = new Choices();
            cmd3.Add(new string[] { "yes", "no" });
            GrammarBuilder gb3 = new GrammarBuilder();
            gb3.Append(cmd3);
            Grammar g3 = new Grammar(gb3);
            restart.LoadGrammar(g3);
            restart.SpeechRecognized += Restart_SpeechRecognized;
        }

        //=======================================
        //Restart YesNo speech recognition engine
        //=======================================

        private void Restart_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "yes":
                    var psi2 = new ProcessStartInfo("shutdown", "/r /t 0");
                    psi2.CreateNoWindow = true;
                    psi2.UseShellExecute = false;
                    Process.Start(psi2);
                    break;

                case "no":
                    label1.Text = "restart cancel";
                    label1.ForeColor = Color.FromArgb(64, 134, 212);
                    restart.RecognizeAsyncStop();
                    ss.Speak("Ok, i won't restart");
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;
            }
        }

        //========================================
        //Shutdown YessNo speech recognition engine
        //========================================

        void shutdown_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "yes":
                    var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);
                    break;

                case "no":
                    label1.Text = "suhtdown cancel";
                    label1.ForeColor = Color.FromArgb(64, 134, 212);
                    shutdown.RecognizeAsyncStop();
                    ss.Speak("Ok, i won't shutdown");
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;
            }
        }

        //========================================
        //normal SpeechRecognitionEngine Functions
        //========================================

        private void normal_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            normal.RecognizeAsyncStop();
            rec = true;
            ss.Speak("Hi thulana, what can i do for you");
            sre.SetInputToDefaultAudioDevice();
            sre.RecognizeAsync(RecognizeMode.Multiple);
            label1.Text = "I'm listening . . .";
            crclbar.Visible = true;
            Enblbtn.BackgroundImage = Image.FromFile(@"C:\Users\Thulana\Desktop\Voice Recognizing project\Resources\mic.png");
        }

        //======================================
        //main SpeechRecognitionEngine Functions
        //======================================

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(64, 134, 212);
            label1.Text = e.Result.Text;
            panel1.Visible = false;

            switch (e.Result.Text)
            {
                case "shutdown":
                    sre.RecognizeAsyncStop();
                    shutdown.SetInputToDefaultAudioDevice();
                    ss.Speak("do you really need to shutdown");
                    label1.ForeColor = Color.White;
                    label1.Text = "Say 'yes', to shutdown";
                    shutdown.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "restart":
                    sre.RecognizeAsyncStop();
                    restart.SetInputToDefaultAudioDevice();
                    ss.Speak("do you really need to restart");
                    label1.ForeColor = Color.White;
                    label1.Text = "Say 'yes', to restart";
                    restart.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "minimize assistant":
                    this.WindowState = FormWindowState.Minimized;
                    break;

                case "open assistant":
                    this.WindowState = FormWindowState.Normal;
                    break;

                case "stop talking":
                    sre.RecognizeAsyncStop();
                    rec = false;
                    ss.Speak("Ok, I will stay quitely");
                    normal.SetInputToDefaultAudioDevice();
                    normal.RecognizeAsync(RecognizeMode.Multiple);
                    label1.ForeColor = Color.FromArgb(85, 85, 85);
                    label1.Text = "OK, I will stay quietly";
                    crclbar.Visible = false;
                    Enblbtn.BackgroundImage = Image.FromFile(@"C:\Users\Thulana\Desktop\Voice Recognizing project\Resources\mic2.png");
                    break;

                case "Exit":
                    label1.Text = "Good Bye, Have a nice day !";
                    crclbar.Visible = false;
                    Enblbtn.BackgroundImage = Image.FromFile(@"C:\Users\Thulana\Desktop\Voice Recognizing project\Resources\mic2.png");
                    label1.Text = "Good Bye, Have a nice day !";
                    Application.Exit();
                    break;

                case "open bluetooth settings":
                    sre.RecognizeAsyncStop();
                    ss.Speak("openning bluetooth settings");
                    Process.Start("ms-settings:bluetooth");
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "go to edit mode":
                    sre.RecognizeAsyncStop();
                    ss.Speak("You can edit me from here.");
                    btnSettings.PerformClick();
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "close edit mode":
                    sre.RecognizeAsyncStop();
                    ss.Speak("closing edit mode.");
                    Application.OpenForms["Settings"].Close();
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "check my emails":
                    sre.RecognizeAsyncStop();
                    ss.Speak("Checking your emails");
                    Process.Start("chrome", "https://www.gmail.com");
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "lock my computer":
                    sre.RecognizeAsyncStop();
                    ss.Speak("locking your computer");
                    var proc1 = new ProcessStartInfo();
                    proc1.UseShellExecute = true;
                    proc1.WorkingDirectory = @"C:\Windows\System32";
                    proc1.FileName = @"C:\Windows\System32\cmd.exe";
                    proc1.Arguments = "/c " + "rundll32.exe user32.dll,LockWorkStation";
                    proc1.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(proc1);
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open whatsapp":
                    sre.RecognizeAsyncStop();
                    ss.Speak("Openning whatsapp web");
                    Process.Start("chrome", "https://web.whatsapp.com/");
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "show my weather":
                    sre.RecognizeAsyncStop();
                    ss.Speak("Showing the weather result");
                    Process.Start("chrome", "https://www.google.com/search?q=weather&oq=weather&aqs=chrome.0.0l7j46.1379j1j7&sourceid=chrome&ie=UTF-8");
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open youtube":
                    sre.RecognizeAsyncStop();
                    ss.Speak("opening youtube");
                    Process.Start("chrome", "https://www.youtube.com");
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open candela":
                    sre.RecognizeAsyncStop();
                    if (File.Exists("C:/Program Files (x86)/Candela Learning Technologies/Grade09ScienceSin/Setup/CandelaPlayer.exe"))
                    {
                        ss.Speak("opening candela");
                        Process.Start("C:/Program Files (x86)/Candela Learning Technologies/Grade09ScienceSin/Setup/CandelaPlayer.exe");
                    }
                    else
                    {
                        ss.Speak("There is no candela installed");
                    }
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open notepad":
                    sre.RecognizeAsyncStop();
                    ss.Speak("openning notepad");
                    Process.Start("notepad");
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open google":
                    sre.RecognizeAsyncStop();
                    if (File.Exists(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"))
                    {
                        ss.Speak("openning google chrome");
                        Process.Start("chrome", "https://www.google.com");
                    }
                    else
                    {
                        ss.Speak("There is no google chrome installed");
                    }

                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open visual studio express":
                    sre.RecognizeAsyncStop();
                    if (File.Exists("C:/Program Files (x86)/Microsoft Visual Studio 11.0/Common7/IDE/WDExpress.exe"))
                    {
                        ss.Speak("openning visual studio express 2012");
                        Process.Start("C:/Program Files (x86)/Microsoft Visual Studio 11.0/Common7/IDE/WDExpress.exe");
                    }
                    else
                    {
                        ss.Speak("There is no visual studio express installed");
                    }

                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open visual studio community":
                    sre.RecognizeAsyncStop();
                    if (File.Exists(@"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe"))
                    {
                        ss.Speak("openning visual studio community");
                        Process.Start(@"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe");
                    }
                    else
                    {
                        ss.Speak("There is no visual studio community installed");
                    }

                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open file explorer":
                    sre.RecognizeAsyncStop();
                    ss.Speak("openning file explorer");
                    Process.Start("explorer");
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open photoshop":
                    sre.RecognizeAsyncStop();
                    if (File.Exists("C:/Program Files/Adobe/Adobe Premiere Pro CC 2017/Adobe Premiere Pro.exe"))
                    {
                        ss.Speak("openning adobe photoshop");
                        Process.Start("C:/Program Files/Adobe/Adobe Photoshop CS6 (64 Bit)/Photoshop.exe");
                    }
                    else
                    {
                        ss.Speak("There is no adobe photoshop installed");
                    }
                    ss.Speak("openning adobe photoshop");

                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "open premier":
                    sre.RecognizeAsyncStop();
                    if (File.Exists("C:/Program Files/Adobe/Adobe Premiere Pro CC 2017/Adobe Premiere Pro.exe"))
                    {
                        ss.Speak("openning adobe premier pro");
                        Process.Start("C:/Program Files/Adobe/Adobe Premiere Pro CC 2017/Adobe Premiere Pro.exe");
                    }
                    else
                    {
                        ss.Speak("There is no adobe premier pro installed");
                    }

                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "close notepad":

                    sre.RecognizeAsyncStop();
                    Process[] p1 = Process.GetProcessesByName("notepad");
                    if (p1.Length >= 1)
                    {
                        ss.Speak("closing notepad");
                        Process.GetProcessesByName("notepad")[0].Kill();
                    }
                    else
                    {
                        label1.Text = "There's no notepad open";
                        label1.ForeColor = Color.White;
                        ss.Speak("There is no notepad open");
                        label1.ForeColor = Color.FromArgb(85, 85, 85);
                    }
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "close google":

                    sre.RecognizeAsyncStop();
                    Process[] p2 = Process.GetProcessesByName("chrome");
                    if (p2.Length >= 1)
                    {
                        ss.Speak("closing google");
                        var proc = new ProcessStartInfo();
                        proc.UseShellExecute = true;
                        proc.WorkingDirectory = @"C:\Windows\System32";
                        proc.FileName = @"C:\Windows\System32\cmd.exe";
                        proc.Arguments = "/c " + "taskkill /IM chrome.exe";
                        proc.WindowStyle = ProcessWindowStyle.Hidden;
                        Process.Start(proc);
                    }
                    else
                    {
                        label1.Text = "There's no chrome open";
                        label1.ForeColor = Color.White;
                        ss.Speak("There is no google chrome open");
                        label1.ForeColor = Color.FromArgb(85, 85, 85);
                    }
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "close visual studio express":

                    sre.RecognizeAsyncStop();
                    Process[] p3 = Process.GetProcessesByName("WDExpress");
                    if (p3.Length >= 1)
                    {
                        ss.Speak("closing visual studio express");
                        Process.GetProcessesByName("WDExpress")[0].Kill();
                    }
                    else
                    {
                        label1.Text = "There's no visual studio express open";
                        label1.ForeColor = Color.White;
                        ss.Speak("There is no visual studio express open");
                        label1.ForeColor = Color.FromArgb(85, 85, 85);
                    }
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "close visual studio community":

                    sre.RecognizeAsyncStop();
                    Process[] P3 = Process.GetProcessesByName("devenv");
                    if (P3.Length >= 1)
                    {
                        ss.Speak("closing visual studio community");
                        Process.GetProcessesByName("devenv")[0].Kill();
                    }
                    else
                    {
                        label1.Text = "There's no visual studio community open";
                        label1.ForeColor = Color.White;
                        ss.Speak("There is no visual studio community open");
                        label1.ForeColor = Color.FromArgb(85, 85, 85);
                    }
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "close file explorer":

                    sre.RecognizeAsyncStop();
                    Process[] p4 = Process.GetProcessesByName("explorer");
                    if (p4.Length >= 1)
                    {
                        ss.Speak("closing file explorer");
                        Process.GetProcessesByName("explorer")[0].Kill();
                    }
                    else
                    {
                        label1.Text = "There's no file explorer open";
                        label1.ForeColor = Color.White;
                        ss.Speak("There is no file explorer open");
                        label1.ForeColor = Color.FromArgb(85, 85, 85);
                    }
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "close photoshop":
                    label1.ForeColor = Color.White;
                    sre.RecognizeAsyncStop();
                    Process[] p5 = Process.GetProcessesByName("Photoshop");
                    if (p5.Length >= 1)
                    {
                        ss.Speak("closing adobe photoshop");
                        Process.GetProcessesByName("Photoshop")[0].Kill();
                    }
                    else
                    {
                        label1.Text = "There's no adobe photoshop open";
                        ss.Speak("There is no adobe photoshop open");
                    }
                    sre.RecognizeAsync(RecognizeMode.Multiple);

                    label1.ForeColor = Color.FromArgb(85, 85, 85);
                    break;

                case "close premier":

                    sre.RecognizeAsyncStop();
                    Process[] p6 = Process.GetProcessesByName("Adobe Premiere Pro");
                    if (p6.Length >= 1)
                    {
                        ss.Speak("closing adobe premier pro");
                        Process.GetProcessesByName("Adobe Premiere Pro")[0].Kill();
                    }
                    else
                    {
                        label1.Text = "There's no adobe premier pro open";
                        label1.ForeColor = Color.White;
                        ss.Speak("There is no adobe premier pro open");
                        label1.ForeColor = Color.FromArgb(85, 85, 85);
                    }
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "close candela":

                    sre.RecognizeAsyncStop();
                    Process[] p7 = Process.GetProcessesByName("CandelaPlayer");
                    if (p7.Length >= 1)
                    {
                        ss.Speak("closing grade 9 science candela");
                        Process.GetProcessesByName("CandelaPlayer")[0].Kill();
                    }
                    else
                    {
                        label1.Text = "There's no candela open";
                        label1.ForeColor = Color.White;
                        ss.Speak("There is no grade 9 science candela open");
                        label1.ForeColor = Color.FromArgb(85, 85, 85);
                    }
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("Voice Assistant", Application.ExecutablePath.ToString().Replace("/", "\\"));

            this.Opacity = Properties.Settings.Default.Transparency / 100;
            int x = this.Width / 2 - crclbar.Width / 2;
            crclbar.Location = new System.Drawing.Point(x, crclbar.Location.Y);
            rec = false;
            Properties.Settings.Default.Voice = "Microsoft Zira Desktop";
            normal.SetInputToDefaultAudioDevice();
            normal.RecognizeAsync(RecognizeMode.Multiple);
        }

        //==========================================
        //Close, Minimize, Settings Button Functions
        //==========================================

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnEnable = false;
            Settings settings = new Settings();
            settings.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //============
        //Mouse Events
        //============

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        //===========
        //timer event
        //===========

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text.EndsWith("."))
            {
                panel1.Visible = true;

                if (panel1.Location.X <= 159)
                {
                    panel1.Location = new Point(panel1.Location.X + 1, panel1.Location.Y);
                }
                else
                {
                    panel1.Location = new Point(133, 237);
                }
            }
            else
            {
                panel1.Visible = false;
            }
        }

        //==================
        //Form_Closing event
        //==================

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sre.RecognizeAsyncStop();
            normal.RecognizeAsyncStop();
            panel1.Visible = false;
            crclbar.Visible = false;
            crclbar.Visible = false;
            Enblbtn.BackgroundImage = Image.FromFile(@"C:\Users\Thulana\Desktop\Voice Recognizing project\Resources\mic2.png");
            label1.ForeColor = Color.FromArgb(85, 85, 85);
            label1.Text = "Good Bye, Have a nice day !";
            ss.Speak("Good bye, Have a nice Day");
        }

        //========================
        //label1_TextChanged Event
        //========================

        private void label1_TextChanged(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "OK, I will stay quietly") { }
            else if (label1.Text == "Say 'yes', to shutdown") { }
            else
            {
                label1.ForeColor = Color.FromArgb(85, 85, 85);
                label1.Text = "I'm listening . . .";
                timer2.Enabled = true;
            }
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(64,64,64);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(75,75,75);
        }

        private void timerTrueFalse_Tick(object sender, EventArgs e)
        {
            ss.SelectVoice(Properties.Settings.Default.Voice);
            ss.Volume = Properties.Settings.Default.Volume;
            this.Opacity = Properties.Settings.Default.Transparency / 100;

            if (Properties.Settings.Default.btnEnable)
                btnSettings.Enabled = true;
            else
                btnSettings.Enabled = false;

            switch (Properties.Settings.Default.Index) 
            {
                case 1:
                    ss.Speak("Browsing for the application.");
                    Properties.Settings.Default.Index = 0;
                    break;

                case 2:
                    ss.Speak("Command saved succesfuly");
                    Properties.Settings.Default.Index = 0;
                    break;

                case 3:
                    ss.Speak("Voice changed to " + ss.Voice.Name);
                    Properties.Settings.Default.Index = 0;
                    break;
            }
        }
    }
}