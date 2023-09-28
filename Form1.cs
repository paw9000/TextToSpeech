using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Diagnostics;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        //From https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-registerhotkey
        //Modifier keys:
        private const int MOD_ALT = 0x0001;
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_SHIFT = 0x0004;
        private const int MOD_WIN = 0x0008;

        //From https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-hotkey
        private const int WM_HOTKEY = 0x0312;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private int hotkeyId = 1; 

        private SpeechSynthesizer synthesizer;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY) {                
                if (synthesizer.State == SynthesizerState.Speaking) {
                    //If we are currently playing stop
                    synthesizer.SpeakAsyncCancelAll();
                } else if (Clipboard.ContainsText()) {
                    string clipboardText = Clipboard.GetText();

                    try {
                        // Convert text to speech
                        synthesizer.SpeakAsync(clipboardText);
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while performing text-to-speech: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Handle the exception as needed
                    }                    
                }
            }
            base.WndProc(ref m);
        }

        // Check if speech synthesis is supported on the system
        private bool IsSpeechSynthesisSupported()
        {
            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices()) {
                if (voice.Enabled)
                    return true;
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();

            try {
                // Initialize the SpeechSynthesizer
                synthesizer = new SpeechSynthesizer();

                // Check if speech synthesis is supported
                if (!IsSpeechSynthesisSupported()) {
                    MessageBox.Show("Speech synthesis is not supported on this system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    activeVoice.Items.Clear();

                    // Get the installed voices
                    foreach (InstalledVoice voice in synthesizer.GetInstalledVoices()) {
                        VoiceInfo info = voice.VoiceInfo;
#if DEBUG
                        Console.WriteLine("Name: " + info.Name);
                        Console.WriteLine("Gender: " + info.Gender);
                        Console.WriteLine("Age: " + info.Age);
                        Console.WriteLine("Culture: " + info.Culture);
                        Console.WriteLine("Description: " + info.Description);
                        Console.WriteLine("ID: " + info.Id);
                        Console.WriteLine();
#endif
                        activeVoice.Items.Add(info.Name);
                    }
                }
            } catch (Exception ex) {
                // Handle the exception as needed
                MessageBox.Show("An error occurred while initializing speech synthesis: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            Activate();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (keyHasBeenRegistered)
                UnregisterHotKey(this.Handle, hotkeyId);

            Application.Exit();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            if (e.Button == MouseButtons.Right)
                notifyIcon1.ContextMenuStrip.Show(new Point(Cursor.Position.X + 1, Cursor.Position.Y + 1));            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restoreState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void activeVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking) 
                synthesizer.SpeakAsyncCancelAll();
            
            string selectedVoice = activeVoice.SelectedItem.ToString();
            synthesizer.SelectVoice(selectedVoice);

            saveState();
        }

        private void rateSlider_Scroll(object sender, EventArgs e)
        {
            synthesizer.Rate = rateSlider.Value;

            saveState();
        }

        private void volumeSlider_Scroll(object sender, EventArgs e)
        {
            synthesizer.Volume = volumeSlider.Value;

            saveState();
        }

        private bool keyHasBeenRegistered = false;

        private bool updateKeyCombo()
        {
            string letterStr = letterKey.Text;

            if (1 != letterStr.Length)
                return false;

            char letter = letterStr.ToUpper()[0];
            bool validCharacter = false;
            if (letter >= 'A' && letter <= 'Z')
                validCharacter = true;

            if (validCharacter) {
                int modifiersCombined = 0;
                if (shiftCheckbox.Checked)
                    modifiersCombined |= MOD_SHIFT;
                if (altCheckbox.Checked)
                    modifiersCombined |= MOD_ALT;
                if (ctrlCheckbox.Checked)
                    modifiersCombined |= MOD_CONTROL;
                if (windowsCheckbox.Checked)
                    modifiersCombined |= MOD_WIN;

                if (keyHasBeenRegistered)
                    UnregisterHotKey(this.Handle, hotkeyId);

                RegisterHotKey(this.Handle, hotkeyId, modifiersCombined, (int)letter);
                keyHasBeenRegistered = true;
                return true;
            }

            return false;
        }

        private void letterKey_TextChanged(object sender, EventArgs e)
        {
            bool validInput = updateKeyCombo();
            if (validInput)
                saveState();
        }

        private void shiftCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            updateKeyCombo();
            saveState();
        }

        private void altCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            updateKeyCombo();
            saveState();
        }

        private void ctrlCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            updateKeyCombo();
            saveState();
        }

        private void windowsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            updateKeyCombo();
            saveState();
        }

        bool fullyLoaded = false;

        private void saveState()
        {
            if (!fullyLoaded)
                return;

            Properties.Settings.Default.voiceIndex = activeVoice.SelectedIndex;
            Properties.Settings.Default.rate = rateSlider.Value;
            Properties.Settings.Default.volume = volumeSlider.Value;
            Properties.Settings.Default.letterKey = letterKey.Text;
            Properties.Settings.Default.shift = shiftCheckbox.Checked;
            Properties.Settings.Default.ctrl = ctrlCheckbox.Checked;
            Properties.Settings.Default.alt = altCheckbox.Checked;
            Properties.Settings.Default.win = windowsCheckbox.Checked;

            Properties.Settings.Default.Save();
        }

        private void restoreState()
        {
            activeVoice.SelectedIndex = Properties.Settings.Default.voiceIndex;
            rateSlider.Value = Properties.Settings.Default.rate;
            volumeSlider.Value = Properties.Settings.Default.volume;

            string debugLetter = Properties.Settings.Default.letterKey;
            letterKey.Text = debugLetter;
            shiftCheckbox.Checked = Properties.Settings.Default.shift;
            ctrlCheckbox.Checked = Properties.Settings.Default.ctrl;
            bool debugAlt = Properties.Settings.Default.alt;
            altCheckbox.Checked = debugAlt;
            windowsCheckbox.Checked = Properties.Settings.Default.win;

            //Set voice
            try {
                string selectedVoice = synthesizer.GetInstalledVoices()[activeVoice.SelectedIndex].VoiceInfo.Name;
                synthesizer.SelectVoice(selectedVoice);
            } catch (Exception ex) {
                //If the user disables some voices as the OS level the set could go down in size
                //So reset it to the first in that case.
                activeVoice.SelectedIndex = 0;
                string selectedVoice = synthesizer.GetInstalledVoices()[activeVoice.SelectedIndex].VoiceInfo.Name;
                synthesizer.SelectVoice(selectedVoice);
            }

            synthesizer.Rate = rateSlider.Value;
            synthesizer.Volume = volumeSlider.Value;

            updateKeyCombo();

            fullyLoaded = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Hide();            
        }

        private void openSpeechSettingButton_Click(object sender, EventArgs e)
        {
            try {
                // Note: This URI might change in future Windows updates,
                // make sure to verify if it still works on the target system.

                // Open "Time & language" section
                Process.Start("ms-settings:speech");
            } catch (Exception ex) {
                MessageBox.Show("Error opening settings: " + ex.Message);
            }
        }

        private void testVoiceButton_Click(object sender, EventArgs e)
        {
            string testMessage = "This is what the current voice sounds like, do you like it?";

            try {
                // Convert text to speech
                synthesizer.SpeakAsync(testMessage);
            } catch (Exception ex) {
                MessageBox.Show("Speech synthesizer error: " + ex.Message);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            Activate();
        }
    }
}
