using Newtonsoft.Json;
using System.IO;

namespace CYsearch3
{
    //jsonファイル 構成
    public class Json_info
    {
        public bool check_livename, check_othername, check_timer;
        public string live_name, other_name;
        public int minute, second, wait_time;
    }

    public class Json_
    {
        public static string json_file = "setting.json";

        //jsonファイル作成
        public void Create_json()
        {
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
            Write_json(json_data);
        }
        
        public void Write_json(Json_info info)
        {
            //整えて書き込み
            string json_text = JsonConvert.SerializeObject(info, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(json_file ,json_text);
        }

        public Json_info Load_json()
        {
            string load_json = File.ReadAllText(json_file);
            return JsonConvert.DeserializeObject<Json_info>(load_json);
        }
    }
}
