using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebSampleYoutubeAPI {
    public class YouTubeService {
        private readonly string apiKey = "AIzaSyB4PmpWXGu5Wvxer6AngZdmFdw_HP2HnIM";  // あなたのAPIキーを入力してください。

        public async Task<(string title, string thumbnailUrl)> GetVideoDetailsAsync(string videoId) {
            string url = $"https://www.googleapis.com/youtube/v3/videos?part=snippet&id={videoId}&key={apiKey}";

            using (HttpClient client = new HttpClient()) {
                var response = await client.GetStringAsync(url);
                JObject json = JObject.Parse(response);

                var videoTitle = json["items"][0]["snippet"]["title"].ToString();
                var thumbnailUrl = json["items"][0]["snippet"]["thumbnails"]["high"]["url"].ToString();

                return (videoTitle, thumbnailUrl);
            }
        }
    }
}