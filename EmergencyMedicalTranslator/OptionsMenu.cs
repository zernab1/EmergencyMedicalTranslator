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
    public partial class OptionsMenu : Form
    {
        private string DetectedLanguage { get; set; }
        private string ForeignLanguagePhrase { get; set; }
        public OptionsMenu(string givenDetectedLanguage)
        {
            InitializeComponent();
            DetectedLanguage = givenDetectedLanguage;
            foreach (Control control in Controls)
            {
                if(control is Label || control is Button)
               control.Text = Translator.Translate(control.Text, "en", DetectedLanguage.Substring(0, 2));
            }
            TranslateAudio();
            txtBoxTranslatedMessage.Text = Translator.Translate(ForeignLanguagePhrase, DetectedLanguage.Substring(0, 2), "en");

        }

        private async void TranslateAudio()
        {
            using (var recognizer = new SpeechRecognizer(SpeechConfig.FromSubscription(" 0935f3c388b84fc98a8aa3f8457f2229", "westus"), DetectedLanguage.Substring(0, 2)))
            {
                var speechRecognitionResult = await recognizer.RecognizeOnceAsync();
                if (speechRecognitionResult.Reason == ResultReason.Canceled)
                {
                    var cancellation = CancellationDetails.FromResult(speechRecognitionResult);
                    MessageBox.Show("Error: " + cancellation);
                }
                ForeignLanguagePhrase = speechRecognitionResult.Text;
            }
        }

        private void btnChoking_Click(object sender, EventArgs e)
        {
            if (btnChoking.BackColor == Color.Red)
            {
                btnChoking.BackColor = default(Color);
            }
            else { btnChoking.BackColor = Color.Red; }
        }

        private void btnChestPain_Click(object sender, EventArgs e)
        {
            if (btnChestPain.BackColor == Color.Red)
            {
                btnChestPain.BackColor = default(Color);
            }
            else { btnChestPain.BackColor = Color.Red; }
        }

        private void buttonSevereBleeding_Click(object sender, EventArgs e)
        {
            if (buttonSevereBleeding.BackColor == Color.Red)
            {
                buttonSevereBleeding.BackColor = default(Color);
            }
            else { buttonSevereBleeding.BackColor = Color.Red; }
        }

        private void btnAbdominalPain_Click(object sender, EventArgs e)
        {
            if (btnAbdominalPain.BackColor == Color.Red)
            {
                btnAbdominalPain.BackColor = default(Color);
            }
            else { btnAbdominalPain.BackColor = Color.Red; }
        }

        private void btnDifficultyBreathing_Click(object sender, EventArgs e)
        {
            if (btnDifficultyBreathing.BackColor == Color.Red)
            {
                btnDifficultyBreathing.BackColor = default(Color);
            }
            else { btnDifficultyBreathing.BackColor = Color.Red; }
        }

        private void btnChangeInVision_Click(object sender, EventArgs e)
        {
            if (btnChangeInVision.BackColor == Color.Red)
            {
                btnChangeInVision.BackColor = default(Color);
            }
            else { btnChangeInVision.BackColor = Color.Red; }
        }

        private void btnSeizure_Click(object sender, EventArgs e)
        {
            if (btnSeizure.BackColor == Color.Red)
            {
                btnSeizure.BackColor = default(Color);
            }
            else { btnSeizure.BackColor = Color.Red; }
        }

        private void btnChangeInMentalStatus_Click(object sender, EventArgs e)
        {
            if (btnChangeInMentalStatus.BackColor == Color.Red)
            {
                btnChangeInMentalStatus.BackColor = default(Color);
            }
            else { btnChangeInMentalStatus.BackColor = Color.Red; }
        }

        private void btnVomitting_Click(object sender, EventArgs e)
        {
            if (btnVomitting.BackColor == Color.Red)
            {
                btnVomitting.BackColor = default(Color);
            }
            else { btnVomitting.BackColor = Color.Red; }
        }

        private void btnLossOfConsciousness_Click(object sender, EventArgs e)
        {
            if (btnLossOfConsciousness.BackColor == Color.Red)
            {
                btnLossOfConsciousness.BackColor = default(Color);
            }
            else { btnLossOfConsciousness.BackColor = Color.Red; }
        }
    }
}
