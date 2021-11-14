using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace CYsearch3
{
    class Search
    {

        //配信URL検索
        public List<string> Get_watchurl(string liname)
        {
            //配信検索用URL
            string searchurl = $"https://www.youtube.com/results?search_query={liname}&sp=EgJAAQ%253D%253D";

            //リスト初期化
            List<string> watch_url = new List<string>();


            //html取得
            using (WebClient client = new WebClient())
            {

                //ヘッダー作成
                client.Proxy = null;
                client.Encoding = System.Text.Encoding.UTF8;

                //DL
                string url_body = client.DownloadString(searchurl);

                //File.WriteAllText("ttt.html", url_body);


                //抽出
                url_body = url_body.Substring(4200, url_body.Length - 4289);
                MatchCollection matche = Regex.Matches(url_body, @"watch\?v=(?<urll>\S{11})");

                //配信url代入
                watch_url = matche.Cast<Match>().Select(match => match.Groups["urll"].Value).ToList();

            }

            return watch_url;
        }




        //配信コメント検索
        public List<string> Get_comment(List<string> watch_url, string otname)
        {
            //リスト初期化
            List<string> reslt = new List<string>();


            //リストからのループ
            for (int i = 0; i < watch_url.Count; i++)
            {


                //配信取得
                using (WebClient web = new WebClient())
                {

                    //ヘッダー作成
                    web.Proxy = null;
                    web.Encoding = System.Text.Encoding.UTF8;
                    web.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");


                    //URL作成
                    string url = $"https://www.youtube.com/live_chat?is_popout=1&v={watch_url[i]}";

                    //DL
                    string chat_content = web.DownloadString(url);


                    //切り取り開始部分
                    int aaa = chat_content.IndexOf("mainAppWebResponseContext");

                    //切り取り
                    string chat_co = chat_content.Remove(0, aaa);


                    //File.WriteAllText("chat.html", chat_co);


                    //名前正規表現
                    MatchCollection matche = Regex.Matches(chat_co, "{\"simpleText\":\"(?<namee>.*?)\"}");

                    //リスト変換
                    var list = matche.Cast<Match>().Select(match => match.Groups["namee"].Value).Distinct().ToList();


                    //結果が12以上でないとコメント無し
                    if (list.Count > 11)
                    {

                        //間削除
                        if (list.Count > 11)
                            list.RemoveRange(list.Count - 11, 10);
                        list.Remove("送信したすべてのメッセージが公開されます");


                        //配信url代入
                        foreach (var math in list)
                        {

                            //名前判定
                            if (math.Contains(otname))
                            {
                                string titles = Get_title(watch_url[i]);
                                reslt.Add(titles);
                                reslt.Add(math);
                                reslt.Add(watch_url[i]);
                            }
                        }

                    } //if終了


                } //取得ループ終了

            } //配信ループ終了

            return reslt;
        } //検索関数終了


        //配信名取得
        private string Get_title(string watch_url)
        {

            //初期化
            WebClient wee = new WebClient();

            //ヘッダー作成
            wee.Proxy = null;
            wee.Encoding = System.Text.Encoding.UTF8;

            string url_data = wee.DownloadString("https://www.youtube.com/watch?v="+watch_url);



            return Regex.Match(url_data, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value.Replace(" - YouTube", "");
        }


    }

}
