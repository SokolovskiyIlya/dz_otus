namespace dz9
{
    internal class Program
    {
        private static void Main()
        {
            ImageDownloader imgDwn = new ImageDownloader();
            ImageDownloader.Download("https://proprikol.ru/wp-content/uploads/2020/06/krasivye-kartinki-zvezd-10.jpg", "space.jpg");
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
