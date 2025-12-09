using System;
using System.IO;
using BarcodeApp.Services;

class Program
{
    static void Main(string[] args)
    {
        var generator = new BarcodeGenerator();
        var reader = new BarcodeReaderService();
        var fileService = new FileService();

        Console.Write("Barcode içeriği girin: ");
        string? content = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(content))
        {
            Console.WriteLine("Boş içerik girildi. Çıkılıyor.");
            return;
        }

        // Kaydetme yolu — Windows için örnek. İstediğin yolu alabilirsin.
        string saveDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Barcodes");
        string savePath = Path.Combine(saveDir, "barcode.png");

        try
        {
            // Oluştur
            var pngBytes = generator.GenerateBarcode(content);
            fileService.Save(pngBytes, savePath);

            Console.WriteLine("\nBarcode oluşturuldu ve kaydedildi.\n");

            // Oku
            var result = reader.ReadBarcode(savePath);

            Console.WriteLine("Barcode Başarıyla Okundu:");
            Console.WriteLine($"İçerik: {result.Content}");
            Console.WriteLine($"Dosya: {result.FilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}
