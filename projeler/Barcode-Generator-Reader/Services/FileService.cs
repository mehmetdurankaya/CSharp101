namespace BarcodeApp.Services
{
    public class FileService
    {
        public void Save(byte[] data, string path)
        {
            string? dir = Path.GetDirectoryName(path);

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            File.WriteAllBytes(path, data);
        }
    }
}
