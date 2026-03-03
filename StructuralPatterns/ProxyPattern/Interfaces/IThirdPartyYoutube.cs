public interface IThirdPartyYoutube
{
    List<VideoInfo> ListVideos();
    VideoInfo GetVideoInfo(int id);
    void DownloadVideo(int id);
}