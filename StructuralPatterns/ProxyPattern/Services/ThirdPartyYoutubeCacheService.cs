
public class ThirdPartyYoutubeCacheService : IThirdPartyYoutube
{
    private readonly ThirdPartyYoutubeService _youtubeService;

    private Dictionary<int, VideoInfo> _videoCache;

    private List<VideoInfo> _listCache;

    private bool _needResetCache;

    public ThirdPartyYoutubeCacheService(ThirdPartyYoutubeService youtubeService)
    {
        _youtubeService = youtubeService;
    }

    public List<VideoInfo> ListVideos()
    {
        if (_listCache == null || _needResetCache)
        {
            _listCache = _youtubeService.ListVideos();
        }
        return _listCache;
    }

    public VideoInfo GetVideoInfo(int id)
    {
        if (_videoCache == null || _needResetCache)
        {
            _videoCache = new Dictionary<int, VideoInfo>();
        }

        if (!_videoCache.ContainsKey(id))
        {
            _videoCache[id] = _youtubeService.GetVideoInfo(id);
        }
        return _videoCache[id];
    }

    public void DownloadVideo(int id)
    {
        var info = GetVideoInfo(id);

        Console.WriteLine($"Downloading video with ID: {id} from YouTube...");
        Console.WriteLine($"Video title: {info.Title}");
        Console.WriteLine($"Duration: {info.Duration} seconds");
        Console.WriteLine("Download completed successfully!");
    }
}