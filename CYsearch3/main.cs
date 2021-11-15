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

        Json_ json_class = new Json_();
        Search search_class = new Search();

        public Json_info setting_json = new Json_info();
        public List<string> live_url = new List<string>();

        
        private void main_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Json_.json_file))
            {
                json_class.Create_json();
            }

            setting_json = json_class.Load_json();
            Setting_view();
        
            if (setting_json.check_livename)
                livename_text.Text = setting_json.live_name;
            if (setting_json.check_othername)
                other_name.Text = setting_json.other_name;
            Setting_view();
        }


        private void sseting_button_Click(object sender, EventArgs e)
        {
            using (var setting = new setting())
            {
                setting.ShowDialog();
                setting.Dispose();
            }
            Setting_view();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            run_search();
        }


        private void run_search()
        {
            if (livename_text.Text == "" || other_name.Text == "")
            {
                search_log.Text = "配信名かリスナー名が入っていません";
            }
            else
            {
                button1.Enabled = false;
                search_group.Visible = true;

                search_log.Text = "";
                restl_listv.Items.Clear();
                
                if (setting_json.check_livename)
                    setting_json.live_name = livename_text.Text;
                if (setting_json.check_othername)
                    setting_json.other_name = other_name.Text;
                
                json_class.Write_json(setting_json);
                Setting_view();

                if (search_bgwork.IsBusy)
                    search_bgwork.CancelAsync();
                search_bgwork.RunWorkerAsync();
            }

        }


        private void search_bgwork_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<string> search_result = new List<string>();
            Invoke((Action)(() => search_log.Text = "配信を取得中...\r\n"));

            var wathc_list = search_class.Get_watchurl(livename_text.Text);
            
            if (wathc_list.Count < 0)
            {
                Invoke((Action)(() => search_log.Text += "配信が見つかりませんでした\r\n"));
            }
            else
            {
                Invoke((Action)(() => search_log.Text += $"{wathc_list.Count.ToString()} つの配信を検索中\r\n" ));
                search_result = search_class.Get_comment(wathc_list, other_name.Text);
            }

            e.Result = search_result;
        }


        private void Setting_view()
        {
            setting_listv.Items.Clear();
            setting_json = json_class.Load_json();
            
            var root = JObject.Parse(File.ReadAllText(Json_.json_file));
            foreach (var i in root)
            {
                setting_listv.Items.Add(i.Key).SubItems.Add($"{i.Value}");
            }

            if (setting_json.check_livename)
                livename_text.Text = setting_json.live_name;
            if (setting_json.check_othername)
               other_name.Text = setting_json.other_name;
            json_class.Write_json(setting_json);

            if (setting_json.check_timer == true)
            {
                timer1.Interval = setting_json.wait_time;
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
            search_log.Text = "設定が適応されました\r\n";
        }

        private void search_bgwork_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            search_log.Text = "取得完了\r\n";
            List<string> kekka = (List<string>)e.Result;

            if (kekka.Count > 0)
            {

                for (int i = 0; i < kekka.Count; i = i + 3)
                {
                    restl_listv.Items.Add(kekka[i]).SubItems.Add(kekka[i + 1]);
                    live_url.Add(kekka[i + 2]);
                }
            }
            button1.Enabled = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (restl_listv.SelectedItems.Count > 0)
            {
                Process.Start("https://www.youtube.com/watch?v="+live_url[restl_listv.SelectedItems[0].Index]);
            }
            else
            {
                search_log.Text = "配信が選択されていません";
            }
        }


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
            run_search();
        }

    }
}
