﻿using System.Net;
namespace dz9;

public class ImageDownloader
{
	public event Action<string>? ImageStarted;
	public event Action<string>? ImageCompleted;
    public async Task DownloadAsync(string remoteUrl, string fileName)
    {
		ImageStarted?.Invoke(fileName);
		var myWebClient = new WebClient();
		Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUrl);
		await myWebClient.DownloadFileTaskAsync(remoteUrl, fileName);
		Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUrl);
		ImageCompleted?.Invoke(fileName);	
    }
}
