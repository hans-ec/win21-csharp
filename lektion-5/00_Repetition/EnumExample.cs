using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition
{
    enum State
    {
        NoModel,
        ImagePrepared,
        ImageProcessed,
        ImageFinalized,
        ModelCreated
    }



    internal class EnumExample
    {
        public State _state = State.NoModel;
        public string _image = "";



        public void CaptureImage()
        {
            // tar en bild med kameran
            _image = "bilden.jpg";
        }

        public void PrepareImageForProcessing()
        {

            // ändrar hög och bredd på bilden (height, width)
            // ändrar pixeltätheten (dpi)
            _state = State.ImagePrepared;
        }

        public void ProcessingImage()
        {
            // AI analys av bilden
            _state = State.ImageProcessed;
        }

        public void ScoringImage()
        {
            // hämtar slutresultatet i procentuellt värde: (0.00 - 1)
            // bygger upp en graf med värdet
            _state = State.ImageFinalized;
        }

        public void RemoveImage()
        {
            // tar bort bilden från lagringsuttrymmet.
        }

        public void BuildModel()
        {
            // bygger modellen så vi kan göra förfrågningar mot AI:t
            _state = State.ModelCreated;
        }

        public void RemoveModel()
        {
            // Tar bort modellen för att sedan kunna skapa en ny modell
            _state = State.NoModel;
        }
    }
}
