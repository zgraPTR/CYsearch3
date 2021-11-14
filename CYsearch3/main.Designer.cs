
namespace CYsearch3
{
    partial class main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.search_group = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.other_name = new System.Windows.Forms.TextBox();
            this.sseting_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.livename_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restl_group = new System.Windows.Forms.GroupBox();
            this.restl_listv = new System.Windows.Forms.ListView();
            this.livename_listv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.othername_listv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progrees_group = new System.Windows.Forms.GroupBox();
            this.search_log = new System.Windows.Forms.TextBox();
            this.setting_group = new System.Windows.Forms.GroupBox();
            this.setting_listv = new System.Windows.Forms.ListView();
            this.setting_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.setting_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_bgwork = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.search_group.SuspendLayout();
            this.restl_group.SuspendLayout();
            this.progrees_group.SuspendLayout();
            this.setting_group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_group
            // 
            this.search_group.Controls.Add(this.button1);
            this.search_group.Controls.Add(this.other_name);
            this.search_group.Controls.Add(this.sseting_button);
            this.search_group.Controls.Add(this.label2);
            this.search_group.Controls.Add(this.livename_text);
            this.search_group.Controls.Add(this.label1);
            this.search_group.Location = new System.Drawing.Point(5, 10);
            this.search_group.Name = "search_group";
            this.search_group.Size = new System.Drawing.Size(355, 130);
            this.search_group.TabIndex = 0;
            this.search_group.TabStop = false;
            this.search_group.Text = "検索";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // other_name
            // 
            this.other_name.Location = new System.Drawing.Point(145, 50);
            this.other_name.Name = "other_name";
            this.other_name.Size = new System.Drawing.Size(201, 25);
            this.other_name.TabIndex = 3;
            // 
            // sseting_button
            // 
            this.sseting_button.Location = new System.Drawing.Point(10, 80);
            this.sseting_button.Name = "sseting_button";
            this.sseting_button.Size = new System.Drawing.Size(110, 30);
            this.sseting_button.TabIndex = 6;
            this.sseting_button.Text = "設定";
            this.sseting_button.UseVisualStyleBackColor = true;
            this.sseting_button.Click += new System.EventHandler(this.sseting_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "リスナー名";
            // 
            // livename_text
            // 
            this.livename_text.Location = new System.Drawing.Point(145, 20);
            this.livename_text.Name = "livename_text";
            this.livename_text.Size = new System.Drawing.Size(201, 25);
            this.livename_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "配信者(ゲーム)名";
            // 
            // restl_group
            // 
            this.restl_group.Controls.Add(this.restl_listv);
            this.restl_group.Location = new System.Drawing.Point(375, 10);
            this.restl_group.Name = "restl_group";
            this.restl_group.Size = new System.Drawing.Size(620, 380);
            this.restl_group.TabIndex = 7;
            this.restl_group.TabStop = false;
            this.restl_group.Text = "結果";
            // 
            // restl_listv
            // 
            this.restl_listv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.livename_listv,
            this.othername_listv});
            this.restl_listv.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.restl_listv.HideSelection = false;
            this.restl_listv.Location = new System.Drawing.Point(5, 20);
            this.restl_listv.MultiSelect = false;
            this.restl_listv.Name = "restl_listv";
            this.restl_listv.Size = new System.Drawing.Size(610, 360);
            this.restl_listv.TabIndex = 0;
            this.restl_listv.UseCompatibleStateImageBehavior = false;
            this.restl_listv.View = System.Windows.Forms.View.Details;
            this.restl_listv.SelectedIndexChanged += new System.EventHandler(this.restl_listv_SelectedIndexChanged);
            // 
            // livename_listv
            // 
            this.livename_listv.Text = "配信名";
            this.livename_listv.Width = 400;
            // 
            // othername_listv
            // 
            this.othername_listv.Text = "リスナー名";
            this.othername_listv.Width = 200;
            // 
            // progrees_group
            // 
            this.progrees_group.Controls.Add(this.search_log);
            this.progrees_group.Location = new System.Drawing.Point(5, 145);
            this.progrees_group.Name = "progrees_group";
            this.progrees_group.Size = new System.Drawing.Size(355, 100);
            this.progrees_group.TabIndex = 9;
            this.progrees_group.TabStop = false;
            this.progrees_group.Text = "ログ";
            // 
            // search_log
            // 
            this.search_log.Location = new System.Drawing.Point(10, 25);
            this.search_log.Multiline = true;
            this.search_log.Name = "search_log";
            this.search_log.Size = new System.Drawing.Size(340, 70);
            this.search_log.TabIndex = 0;
            // 
            // setting_group
            // 
            this.setting_group.Controls.Add(this.setting_listv);
            this.setting_group.Location = new System.Drawing.Point(5, 250);
            this.setting_group.Name = "setting_group";
            this.setting_group.Size = new System.Drawing.Size(355, 240);
            this.setting_group.TabIndex = 10;
            this.setting_group.TabStop = false;
            this.setting_group.Text = "設定確認";
            // 
            // setting_listv
            // 
            this.setting_listv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.setting_name,
            this.setting_text});
            this.setting_listv.HideSelection = false;
            this.setting_listv.Location = new System.Drawing.Point(10, 25);
            this.setting_listv.Name = "setting_listv";
            this.setting_listv.Size = new System.Drawing.Size(330, 210);
            this.setting_listv.TabIndex = 0;
            this.setting_listv.UseCompatibleStateImageBehavior = false;
            this.setting_listv.View = System.Windows.Forms.View.Details;
            // 
            // setting_name
            // 
            this.setting_name.Text = "設定名";
            this.setting_name.Width = 150;
            // 
            // setting_text
            // 
            this.setting_text.Text = "内容";
            this.setting_text.Width = 150;
            // 
            // search_bgwork
            // 
            this.search_bgwork.WorkerReportsProgress = true;
            this.search_bgwork.WorkerSupportsCancellation = true;
            this.search_bgwork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.search_bgwork_DoWork);
            this.search_bgwork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.search_bgwork_RunWorkerCompleted);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "配信を開く";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(375, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "結果の選択";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "リスナー名 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "選択された配信 : ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.setting_group);
            this.Controls.Add(this.progrees_group);
            this.Controls.Add(this.restl_group);
            this.Controls.Add(this.search_group);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "main";
            this.ShowIcon = false;
            this.Text = "CYsearch3";
            this.Load += new System.EventHandler(this.main_Load);
            this.search_group.ResumeLayout(false);
            this.search_group.PerformLayout();
            this.restl_group.ResumeLayout(false);
            this.progrees_group.ResumeLayout(false);
            this.progrees_group.PerformLayout();
            this.setting_group.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox search_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox livename_text;
        private System.Windows.Forms.TextBox other_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sseting_button;
        private System.Windows.Forms.GroupBox restl_group;
        private System.Windows.Forms.GroupBox progrees_group;
        private System.Windows.Forms.GroupBox setting_group;
        private System.Windows.Forms.ListView restl_listv;
        private System.Windows.Forms.ColumnHeader livename_listv;
        private System.Windows.Forms.ColumnHeader othername_listv;
        private System.ComponentModel.BackgroundWorker search_bgwork;
        private System.Windows.Forms.ListView setting_listv;
        private System.Windows.Forms.ColumnHeader setting_name;
        private System.Windows.Forms.ColumnHeader setting_text;
        private System.Windows.Forms.TextBox search_log;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

