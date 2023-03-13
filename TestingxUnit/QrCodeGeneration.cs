using SixLabors.Fonts;
using SixLabors.ImageSharp.Formats.Png;
using ZXing.Common;

public static class QrCodeGeneration
{
    public static byte[] GenerateQrCode()
    {
        var barcodeWriter = new ZXing.ImageSharp.BarcodeWriter<Rgba32>
        {
            Format = ZXing.BarcodeFormat.QR_CODE,
            Options = new EncodingOptions
            {
                Height = 1000,
                Width = 1000,
                Margin = 0,
                PureBarcode = false,
            }
        };

        using (var image = barcodeWriter.Write("https://localhost:7133"))
        {
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, new PngEncoder());
                image.Dispose();
                return memoryStream.ToArray();
            }
        }
    }
    public static Font CreateFont(int size)
    {
        FontCollection collection = new();
        FontFamily family = collection.Add("./fonts/testFont.ttf");
        return family.CreateFont(size, FontStyle.Regular);
    }
}