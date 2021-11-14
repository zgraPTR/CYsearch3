
namespace CYsearch3
{
    partial class setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.setting_group = new System.Windows.Forms.GroupBox();
            this.timer_check = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.second_nun = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.minute_nun = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.othername_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.livename_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.othername_check = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.livename_check = new System.Windows.Forms.CheckBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.setting_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.second_nun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_nun)).BeginInit();
            this.SuspendLayout();
            // 
            // setting_group
            // 
            this.setting_group.Controls.Add(this.reset_button);
            this.setting_group.Controls.Add(this.timer_check);
            this.setting_group.Controls.Add(this.label6);
            this.setting_group.Controls.Add(this.second_nun);
            this.setting_group.Controls.Add(this.label5);
            this.setting_group.Controls.Add(this.minute_nun);
            this.setting_group.Controls.Add(this.label4);
            this.setting_group.Controls.Add(this.exit_button);
            this.setting_group.Controls.Add(this.othername_text);
            this.setting_group.Controls.Add(this.label3);
            this.setting_group.Controls.Add(this.livename_text);
            this.setting_group.Controls.Add(this.label2);
            this.setting_group.Controls.Add(this.othername_check);
            this.setting_group.Controls.Add(this.label1);
            this.setting_group.Controls.Add(this.livename_check);
            this.setting_group.Location = new System.Drawing.Point(0, 0);
            this.setting_group.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.setting_group.Name = "setting_group";
            this.setting_group.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.setting_group.Size = new System.Drawing.Size(375, 345);
            this.setting_group.TabIndex = 0;
            this.setting_group.TabStop = false;
            this.setting_group.Text = "設定";
            this.setting_group.Enter += new System.EventHandler(this.setting_group_Enter);
            // 
            // timer_check
            // 
            this.timer_check.AutoSize = true;
            this.timer_check.Location = new System.Drawing.Point(10, 220);
            this.timer_check.Name = "timer_check";
            this.timer_check.Size = new System.Drawing.Size(90, 21);
            this.timer_check.TabIndex = 13;
            this.timer_check.Text = "定期検索";
            this.timer_check.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "秒 ごとに取得";
            // 
            // second_nun
            // 
            this.second_nun.Location = new System.Drawing.Point(100, 270);
            this.second_nun.Name = "second_nun";
            this.second_nun.Size = new System.Drawing.Size(65, 25);
            this.second_nun.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "分";
            // 
            // minute_nun
            // 
            this.minute_nun.Location = new System.Drawing.Point(10, 270);
            this.minute_nun.Name = "minute_nun";
            this.minute_nun.Size = new System.Drawing.Size(65, 25);
            this.minute_nun.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "定期検索";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(260, 305);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(110, 30);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "終了";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // othername_text
            // 
            this.othername_text.Location = new System.Drawing.Point(15, 180);
            this.othername_text.Name = "othername_text";
            this.othername_text.Size = new System.Drawing.Size(300, 25);
            this.othername_text.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "視聴者名 (保存済み)";
            // 
            // livename_text
            // 
            this.livename_text.Location = new System.Drawing.Point(15, 130);
            this.livename_text.Name = "livename_text";
            this.livename_text.Size = new System.Drawing.Size(300, 25);
            this.livename_text.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "配信者 (保存済み)";
            // 
            // othername_check
            // 
            this.othername_check.AutoSize = true;
            this.othername_check.Location = new System.Drawing.Point(15, 75);
            this.othername_check.Name = "othername_check";
            this.othername_check.Size = new System.Drawing.Size(105, 21);
            this.othername_check.TabIndex = 2;
            this.othername_check.Text = "リスナー名";
            this.othername_check.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "保存する";
            // 
            // livename_check
            // 
            this.livename_check.AutoSize = true;
            this.livename_check.Location = new System.Drawing.Point(15, 50);
            this.livename_check.Name = "livename_check";
            this.livename_check.Size = new System.Drawing.Size(120, 21);
            this.livename_check.TabIndex = 0;
            this.livename_check.Text = "配信者名保存";
            this.livename_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.livename_check.UseVisualStyleBackColor = true;
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(5, 310);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(115, 30);
            this.reset_button.TabIndex = 14;
            this.reset_button.Text = "設定を初期化";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.ControlBox = false;
            this.Controls.Add(this.setting_group);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "設定";
            this.setting_group.ResumeLayout(false);
            this.setting_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.second_nun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_nun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox setting_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox livename_check;
        private System.Windows.Forms.CheckBox othername_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox livename_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox othername_text;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minute_nun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown second_nun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox timer_check;
        private System.Windows.Forms.Button reset_button;
    }
}