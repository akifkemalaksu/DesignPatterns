public class ThirdPartyYoutubeService : IThirdPartyYoutube
{
    public List<VideoInfo> ListVideos()
    {
        Console.WriteLine("Listing videos from YouTube...");
        return new List<VideoInfo>
        {
            new VideoInfo { Id = 1, Title = "C# Design Patterns", Duration = 3600 },
            new VideoInfo { Id = 2, Title = "SOLID Principles", Duration = 2400 },
            new VideoInfo { Id = 3, Title = "Clean Code", Duration = 5400 }
        };
    }

    public VideoInfo GetVideoInfo(int id)
    {
        Console.WriteLine($"Getting video info for video with ID: {id} from YouTube...");
        return new VideoInfo 
        { 
            Id = id, 
            Title = $"Video Title {id}", 
            Duration = 3600 
        };
    }

    public void DownloadVideo(int id)
    {
        Console.WriteLine($"Downloading video with ID: {id} from YouTube...");
    }
}