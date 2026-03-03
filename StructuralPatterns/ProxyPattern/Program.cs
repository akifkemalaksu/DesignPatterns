IThirdPartyYoutube thirdPartyYoutube = new ThirdPartyYoutubeCacheService(new ThirdPartyYoutubeService());

thirdPartyYoutube.ListVideos();
thirdPartyYoutube.GetVideoInfo(1);
thirdPartyYoutube.DownloadVideo(1);