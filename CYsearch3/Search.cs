using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace CYsearch3
{
    class Search
    {
        public List<string> Get_watchurl(string liname)
        {
            string searchurl = $"https://www.youtube.com/results?search_query={liname}&sp=EgJAAQ%253D%253D";
            List<string> watch_url = new List<string>();

            using (WebClient client = new WebClient())
            {
                client.Proxy = null;
                client.Encoding = System.Text.Encoding.UTF8;
                string url_body = client.DownloadString(searchurl);

                url_body = url_body.Substring(4200, url_body.Length - 4289);
                MatchCollection matche = Regex.Matches(url_body, @"watch\?v=(?<urll>\S{11})");
                watch_url = matche.Cast<Match>().Select(match => match.Groups["urll"].Value).ToList();
            }

            return watch_url;
        }


        public List<string> Get_comment(List<string> watch_url, string otname)
        {
            List<string> reslt = new List<string>();

            for (int i = 0; i < watch_url.Count; i++)
            {
                using (WebClient web = new WebClient())
                {
                    string url = $"https://www.youtube.com/live_chat?is_popout=1&v={watch_url[i]}";
                    web.Proxy = null;
                    web.Encoding = System.Text.Encoding.UTF8;
                    web.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");
                    string chat_content = web.DownloadString(url);

                    int aaa = chat_content.IndexOf("mainAppWebResponseContext");
                    string chat_co = chat_content.Remove(0, aaa);

                    MatchCollection matche = Regex.Matches(chat_co, "{\"simpleText\":\"(?<namee>.*?)\"}");
                    var list = matche.Cast<Match>().Select(match => match.Groups["namee"].Value).Distinct().ToList();

                    if (list.Count > 11)
                    {
                        if (list.Count > 11)
                            list.RemoveRange(list.Count - 11, 10);
                        list.Remove("送信したすべてのメッセージが公開されます");

                        foreach (var math in list)
                        {
                            if (math.Contains(otname))
                            {
                                string titles = Get_title(watch_url[i]);
                                reslt.Add(titles);
                                reslt.Add(math);
                                reslt.Add(watch_url[i]);
                            }
                        }
                    }
                }
            }

            return reslt;
        }


        //配信名取得
        private string Get_title(string watch_url)
        {
            //初期化
            WebClient wee = new WebClient();
            //ヘッダー作成
            wee.Proxy = null;
            wee.Encoding = System.Text.Encoding.UTF8;
            //DLする
            string url_data = wee.DownloadString("https://www.youtube.com/watch?v="+watch_url);
            //タイトルを返す
            return Regex.Match(url_data, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value.Replace(" - YouTube", "");
        }

    }

}
