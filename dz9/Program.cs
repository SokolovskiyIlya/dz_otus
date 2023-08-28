namespace dz9
{
    internal class Program
    {
        private static void Main()
        {
            ImageDownloader imgDwn = new ImageDownloader();
            var start = (string fileName) => Console.WriteLine($"Скачивание файла {fileName} началось");
            var complete = (string fileName) => Console.WriteLine($"Скачивание файла {fileName} завершилось");
            imgDwn.ImageStarted += start;
            imgDwn.ImageCompleted += complete;
            Task download = imgDwn.DownloadAsync("https://img3.akspic.ru/crops/8/9/7/4/7/174798/174798-harlej_devidson-motocikl-harli-harley_davidson_sportster-harley_davidson_fat_boy-7680x4320.jpg", "space.jpg");
            Console.WriteLine("Нажмите клавишу A для выхода или любую другую клавишу для проверки статуса скачивания");
            while (true)
            {
                var key = Console.ReadKey();
                if (key.KeyChar == 'a' || key.KeyChar == 'а')
                {
                    break;
                }
                else
                {
                    Console.WriteLine(String.Format("Загрузка завершена? - {0}", download.IsCompleted));
                }
            }
            imgDwn.ImageStarted -= start;
            imgDwn.ImageCompleted -= complete;
        }
    }
}
