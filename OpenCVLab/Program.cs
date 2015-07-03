using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.OCR;
using Emgu.CV;
using Emgu.CV.Structure;

namespace OpenCVLab
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var image = new Image<Bgr, byte>(Path.GetFullPath("text.png")))
            {
                using (var tess = new Tesseract("", "eng", OcrEngineMode.TesseractCubeCombined))
                {
                    tess.Recognize(image);
                    var text = tess.GetText().TrimEnd();
                }
            }
        }
    }
}
