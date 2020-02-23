using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.CognitiveServices.Speech;
using System.Reflection;
using System.IO;
using DarrenLee.Translator;

namespace EmergencyMedicalTranslator
{
    public partial class EmergencyMedicalTranslator : Form
    {
        OptionsMenu formOptionsMenu;
        public EmergencyMedicalTranslator()
        {
            InitializeComponent();
        }

        private async void btnRecord_Click(object sender, EventArgs e)
        {
            btnRecord.BackColor = Color.LightGreen;
            // other fun language codes:
            //fr-FR
            //ja-JP
            //hi-IN
            //de-DE
            var autoDetectSourceLanguageConfig = AutoDetectSourceLanguageConfig.FromLanguages(new string[] { "fr-FR", "hi-IN" });
            using (var recognizer = new SpeechRecognizer(SpeechConfig.FromSubscription("cb35ce20eade4be2a74a36ab2e9d0ac1", "eastus"), autoDetectSourceLanguageConfig))
            {
                var speechRecognitionResult = await recognizer.RecognizeOnceAsync();
                if (speechRecognitionResult.Reason == ResultReason.Canceled) {
                    var cancellation = CancellationDetails.FromResult(speechRecognitionResult);
                    MessageBox.Show("Error: " + cancellation);
                    this.Close();
                    return;
                }
                var autoDetectSourceLanguageResult = AutoDetectSourceLanguageResult.FromResult(speechRecognitionResult);
                var detectedLanguage = autoDetectSourceLanguageResult.Language;
                btnRecord.BackColor = default(Color);
                // detectedLanguage passed on to the OptionsMenu form
                formOptionsMenu = new OptionsMenu(detectedLanguage);
                //pop up Options Menu
                formOptionsMenu.Show();
            }
            btnRecord.Click += new EventHandler(this.btnRecord_Click);
        }
    }
}
