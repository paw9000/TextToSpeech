using System;
using System.Threading;
using System.Windows.Forms;

namespace TextToSpeech
{
    internal static class Program {
        // Define a unique name for the mutex
        private const string TextToSpeechMutex = "TextToSpeech_Mutex";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, TextToSpeechMutex)) {
                // Try to acquire the mutex
                if (!mutex.WaitOne(0, false)) {
                    // Another instance is already running, exit this instance
                    MessageBox.Show("Another instance of TextToSpeech is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
