using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CYsearch3
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        //グローバル
        //クラス初期化
        Json_ json_class = new Json_();
        Search search_class = new Search();

        //設定保存
        public Json_info setting_json = new Json_info();
        //URL保存
        public List<string> live_url = new List<string>();


        //ロード時
        private void main_Load(object sender, EventArgs e)
        {
            //jsonファイル存在確認
            if (!File.Exists(Json_.json_file))
            {
                //json作成
                json_class.Create_json();
            }

            //json読み込み
            setting_json = json_class.Load_json();
            Setting_view();
            //代入
            if (setting_json.check_livename)
                livename_text.Text = setting_json.live_name;
            if (setting_json.check_othername)
                other_name.Text = setting_json.other_name;
            //終わったら再更新する
            Setting_view();
        }


        //設定ボタン
        private void sseting_button_Click(object sender, EventArgs e)
        {
            //設定を開く
            using (var setting = new setting())
            {
                setting.ShowDialog();
                setting.Dispose();
            }
            //終わったら再更新する
            Setting_view();
        }


        //検索ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            run_search();
        }


        //検索関数
        private void run_search()
        {
            //分岐
            if (livename_text.Text == "" || other_name.Text == "")
            {
                search_log.Text = "配信名かリスナー名が入っていません";
            }
            else
            {
                //ボタン停止
                button1.Enabled = false;
                //検索中表示
                search_group.Visible = true;

                //リストクリア
                search_log.Text = "";
                restl_listv.Items.Clear();
                
                //設定
                if (setting_json.check_livename)
                    setting_json.live_name = livename_text.Text;
                if (setting_json.check_othername)
                    setting_json.other_name = other_name.Text;
                //保存
                json_class.Write_json(setting_json);
                //終わったら再起動する
                Setting_view();

                //検索開始
                if (search_bgwork.IsBusy)
                    search_bgwork.CancelAsync();
                search_bgwork.RunWorkerAsync();
            }

        }


        //検索開始
        private void search_bgwork_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //検索結果初期化
            List<string> sea = new List<string>();
            //配信検索
            Invoke((Action)(() => search_log.Text = "配信を取得中...\r\n"));

            //配信URL取得
            var wathc_list = search_class.Get_watchurl(livename_text.Text);
            //なければ
            if (wathc_list.Count < 0)
            {
                Invoke((Action)(() => search_log.Text += "配信が見つかりませんでした\r\n"));
            }
            else
            {
                //配信数記録
                Invoke((Action)(() => search_log.Text += $"{wathc_list.Count.ToString()} つの配信を検索中\r\n" ));
                //配信検索
                sea = search_class.Get_comment(wathc_list, other_name.Text);
            }

            //結果保存
            e.Result = sea;
        }


        //設定表示
        private void Setting_view()
        {
            //初期化
            setting_listv.Items.Clear();
            //代入
            setting_json = json_class.Load_json();
            
            //リスト追加
            var root = JObject.Parse(File.ReadAllText(Json_.json_file));
            foreach (var i in root)
            {
                setting_listv.Items.Add(i.Key).SubItems.Add($"{i.Value}");
            }

            //保存
            if (setting_json.check_livename)
                livename_text.Text = setting_json.live_name;
            if (setting_json.check_othername)
               other_name.Text = setting_json.other_name;
            json_class.Write_json(setting_json);

            //タイマー確認
            if (setting_json.check_timer == true)
            {
                timer1.Interval = setting_json.wait_time;
                timer1.Enabled = true;

            }
            else
            {
                timer1.Enabled = false;
            }
            //書き換え
            search_log.Text = "設定が適応されました\r\n";
        }

        //終了時
        private void search_bgwork_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //更新
            search_log.Text = "取得完了\r\n";
            //受け取り
            List<string> kekka = (List<string>)e.Result;

            //確認
            if (kekka.Count > 0)
            {

                //ループで追加
                for (int i = 0; i < kekka.Count; i = i + 3)
                {
                    restl_listv.Items.Add(kekka[i]).SubItems.Add(kekka[i + 1]);
                    live_url.Add(kekka[i + 2]);
                }
            }
            //ボタン復活
            button1.Enabled = true;
        }


        //配信を開く
        private void button2_Click(object sender, EventArgs e)
        {
            //分岐 選択が0以上なら
            if (restl_listv.SelectedItems.Count > 0)
            {
                Process.Start("https://www.youtube.com/watch?v="+live_url[restl_listv.SelectedItems[0].Index]);
            }
            else
            {
                search_log.Text = "配信が選択されていません";
            }
        }


        //選択変更
        private void restl_listv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //エラー回避
            if (restl_listv.SelectedItems.Count > 0)
            {
                ListViewItem itemx = restl_listv.SelectedItems[0];
                label3.Text = $"配信名 : {itemx.Text}";
                label4.Text = $"リスナー名 : {itemx.SubItems[1].Text}";
            }
        }


        //時計処理
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (setting_json.check_timer == true)
            {
                timer1.Interval = setting_json.wait_time;
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
            //呼び出し
            run_search();
        }

    }
}
