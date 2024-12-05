using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSampleYoutubeAPI.Models;
using System.Threading.Tasks;


namespace WebSampleYoutubeAPI.Controllers {
    public class HomeController : Controller {
        private readonly YouTubeService _youTubeService;

        public HomeController() {
            _youTubeService = new YouTubeService();  // YouTubeService�̃C���X�^���X���쐬
        }

        // ��������擾���ăr���[�ɓn��
        public async Task<ActionResult> Index() {
            // ����ID�̃��X�g
            var videoIds = new List<string>
            {
            "flX14R4k_6E",
            "ie2qwDwghzo",
            "gSDR4jdzvvQ",
            // ����ɓ���ID��ǉ�
            // ...
        };

            // ��������i�[���郊�X�g
            var videoDetailsList = new List<VideoDetails>();

            // �e����̏����擾
            foreach (var videoId in videoIds) {
                var videoDetails = await _youTubeService.GetVideoDetailsAsync(videoId);
                videoDetailsList.Add(new VideoDetails {
                    Title = videoDetails.title,
                    ThumbnailUrl = videoDetails.thumbnailUrl,
                    VideoId = videoId
                });
            }

            // ViewBag�ɓ������n��
            ViewBag.VideoDetailsList = videoDetailsList;

            return View();
        }
    }
}