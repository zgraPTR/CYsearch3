﻿using System;
using System.Windows.Forms;

namespace CYsearch3
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }


        //グローバル

        //jsonクラス初期化
        Json_ jj = new Json_();


        //ロード時
        private void setting_group_Enter(object sender, EventArgs e)
        {

            //ファイル読み込み
            Json_info jj1 = jj.Load_json();
            
            //代入
            livename_check.Checked = jj1.check_livename;
            othername_check.Checked = jj1.check_othername;
            timer_check.Checked = jj1.check_timer;

            livename_text.Text = jj1.live_name;
            othername_text.Text = jj1.other_name;

            minute_nun.Value = jj1.minute;
            second_nun.Value = jj1.second;

        }


        //終了
        private void exit_button_Click(object sender, EventArgs e)
        {
            //時間計算
            int time = ((int)second_nun.Value * 1000) + ((int)minute_nun.Value * 60000);

            //jsonファイル情報

            Json_info json_data = new Json_info
            {
                check_livename = livename_check.Checked,
                check_othername = othername_check.Checked,
                check_timer = timer_check.Checked,

                live_name = livename_text.Text,
                other_name = othername_text.Text,

                minute = (int)minute_nun.Value,
                second = (int)second_nun.Value,
                wait_time = time
            };


            //書き込む
            jj.Write_json(json_data);

            //終了
            this.Close();
        }


        //リセットボタン
        private void reset_button_Click(object sender, EventArgs e)
        {

            //確認
            DialogResult result = MessageBox.Show("設定をリセットしますか?", "確認", MessageBoxButtons.YesNo);

            //分岐
            if (result == DialogResult.OK)
            {
                jj.Create_json();
                MessageBox.Show("設定をリセットしました");
            }

        }
    }
}