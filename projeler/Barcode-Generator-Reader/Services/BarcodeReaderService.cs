using System.Drawing;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace BarcodeApp.Services
{
    public class BarcodeReaderService
    {
        public BarcodeResult ReadBarcode(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Dosya bulunamadı!", path);

            // Bitmap yükle
            using var bmp = (Bitmap)Image.FromFile(path);

            // ZXing okuyucu
            var reader = new BarcodeReader
            {
                AutoRotate = true,
                TryInverted = true,
                Options = new DecodingOptions
                {
                    TryHarder = true
                }
            };

            var result = reader.Decode(bmp);

            if (result == null)
                throw new Exception("Barkod okunamadı!");

            return new BarcodeResult
            {
                Content = result.Text,
                FilePath = path
            };
        }
    }

    public class BarcodeResult
    {
        public string Content { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
    }
}
