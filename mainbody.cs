using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

namespace Merlin_spoke
{
    class mainbody
    {
        static async Task Main()
        {
            await SynthesizeAudioAsync();
        }

        static async Task SynthesizeAudioAsync()
        {
            var config = SpeechConfig.FromSubscription("ENTER_KEY_THERE", "ENTER_REGION_PROJECT_AZURE");
            using var synthesizer = new SpeechSynthesizer(config);

            var ssml = File.ReadAllText("./ssmlvoice.xml");
            await synthesizer.SpeakSsmlAsync(ssml);
        }
    }
}
    
