namespace dz9
{
    internal class Program
    {
        private static void Main()
        {
            ImageDownloader imgDwn = new ImageDownloader();
            var start = (string fileName) => Console.WriteLine($"Скачивание файла {fileName} началось");
            var complete = (string fileName) => Console.WriteLine($"Скачивание файла {fileName} звершилось");
            imgDwn.ImageStarted += start;
            imgDwn.ImageCompleted += complete;
            imgDwn.Download("https://img3.akspic.ru/crops/8/9/7/4/7/174798/174798-harlej_devidson-motocikl-harli-harley_davidson_sportster-harley_davidson_fat_boy-7680x4320.jpg", "space.jpg");
            imgDwn.ImageStarted -= start;
            imgDwn.ImageCompleted -= complete;
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
        
    }
}
