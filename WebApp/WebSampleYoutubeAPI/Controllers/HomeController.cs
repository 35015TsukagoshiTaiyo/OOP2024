using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSampleYoutubeAPI.Models;
using System.Threading.Tasks;


namespace WebSampleYoutubeAPI.Controllers {
    public class HomeController : Controller {
        private readonly YouTubeService _youTubeService;

        public HomeController() {
            _youTubeService = new YouTubeService();  // YouTubeServiceのインスタンスを作成
        }

        // 動画情報を取得してビューに渡す
        public async Task<ActionResult> Index() {
            // 動画IDのリスト
            var videoIds = new List<string>
            {
            "flX14R4k_6E",
            "ie2qwDwghzo",
            "gSDR4jdzvvQ",
            // さらに動画IDを追加
            // ...
        };

            // 動画情報を格納するリスト
            var videoDetailsList = new List<VideoDetails>();

            // 各動画の情報を取得
            foreach (var videoId in videoIds) {
                var videoDetails = await _youTubeService.GetVideoDetailsAsync(videoId);
                videoDetailsList.Add(new VideoDetails {
                    Title = videoDetails.title,
                    ThumbnailUrl = videoDetails.thumbnailUrl,
                    VideoId = videoId
                });
            }

            // ViewBagに動画情報を渡す
            ViewBag.VideoDetailsList = videoDetailsList;

            return View();
        }
    }
}