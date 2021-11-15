using Newtonsoft.Json;
using System.IO;

namespace CYsearch3
{

    //jsonファイル 構成
    public class Json_info
    {
        //チェック 配信名、ユーザー名、 定期
        public bool check_livename, check_othername, check_timer;
        //配信者名、 リスナー名
        public string live_name, other_name;
        //定期検索時間保存
        public int minute, second, wait_time;
    }


    //json系クラス
    public class Json_
    {
        //グローバル
        //json名
        public static string json_file = "setting.json";

        //jsonファイル作成
        public void Create_json()
        {
            //作成
            Json_info json_data = new Json_info
            {
                check_livename = false,
                check_othername = false,
                check_timer = false,
                live_name = "",
                other_name = "",
                minute = 0,
                second = 0,
                wait_time = 0
            };
            //書き込む
            Write_json(json_data);
        }
        
        //json書き換え
        public void Write_json(Json_info info)
        {
            //整えて書き込み
            string json_text = JsonConvert.SerializeObject(info, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(json_file ,json_text);
        }

        //jsonファイルロード
        public Json_info Load_json()
        {
            //読み込み変換して、返す
            string load_json = File.ReadAllText(json_file);
            return JsonConvert.DeserializeObject<Json_info>(load_json);
        }
    }

}
