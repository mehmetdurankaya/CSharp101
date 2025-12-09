namespace BarcodeApp.Models
{
    public class BarcodeResult
    {
        public string Content { get; set; }
        public string FilePath { get; set; }

        public BarcodeResult(string content, string filePath)
        {
            Content = content;
            FilePath = filePath;
        }
    }
}
