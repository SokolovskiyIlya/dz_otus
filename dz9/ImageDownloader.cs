using System.Net;
namespace dz9;

public class ImageDownloader
{
    public static void Download(string remoteUrl, string fileName)
    {
		var myWebClient = new WebClient();
		Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUrl);
		myWebClient.DownloadFile(remoteUrl, fileName);
		Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUrl);	
    }
}
