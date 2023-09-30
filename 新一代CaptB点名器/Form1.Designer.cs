namespace 新一代CaptB点名器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入名单AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑名单BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出名单CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出CaptB点名器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完整名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未点名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.首选项PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入门GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增功能WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.发送反馈FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报告问题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.建议功能LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.检查更新LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.技术支持TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐私政策PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关于CaptB点名器ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制当前值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.首选项PToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入名单AToolStripMenuItem,
            this.编辑名单BToolStripMenuItem,
            this.导出名单CToolStripMenuItem,
            this.删除名单ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出CaptB点名器ToolStripMenuItem});
            this.文件ToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_27081;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 导入名单AToolStripMenuItem
            // 
            this.导入名单AToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_5060;
            this.导入名单AToolStripMenuItem.Name = "导入名单AToolStripMenuItem";
            this.导入名单AToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.导入名单AToolStripMenuItem.Text = "导入名单(&A)";
            this.导入名单AToolStripMenuItem.Click += new System.EventHandler(this.导入名单AToolStripMenuItem_Click);
            // 
            // 编辑名单BToolStripMenuItem
            // 
            this.编辑名单BToolStripMenuItem.Enabled = global::新一代CaptB点名器.Properties.Settings.Default.编辑名单_Enabled;
            this.编辑名单BToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("编辑名单BToolStripMenuItem.Image")));
            this.编辑名单BToolStripMenuItem.Name = "编辑名单BToolStripMenuItem";
            this.编辑名单BToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.编辑名单BToolStripMenuItem.Text = "编辑名单(&B)";
            this.编辑名单BToolStripMenuItem.Click += new System.EventHandler(this.编辑名单BToolStripMenuItem_Click);
            // 
            // 导出名单CToolStripMenuItem
            // 
            this.导出名单CToolStripMenuItem.Enabled = global::新一代CaptB点名器.Properties.Settings.Default.导出名单_Enabled;
            this.导出名单CToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_9752;
            this.导出名单CToolStripMenuItem.Name = "导出名单CToolStripMenuItem";
            this.导出名单CToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.导出名单CToolStripMenuItem.Text = "导出名单(&C)";
            this.导出名单CToolStripMenuItem.Click += new System.EventHandler(this.导出名单CToolStripMenuItem_Click);
            // 
            // 删除名单ToolStripMenuItem
            // 
            this.删除名单ToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_9916;
            this.删除名单ToolStripMenuItem.Name = "删除名单ToolStripMenuItem";
            this.删除名单ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.删除名单ToolStripMenuItem.Text = "删除名单";
            this.删除名单ToolStripMenuItem.Click += new System.EventHandler(this.删除名单ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // 退出CaptB点名器ToolStripMenuItem
            // 
            this.退出CaptB点名器ToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_5059;
            this.退出CaptB点名器ToolStripMenuItem.Name = "退出CaptB点名器ToolStripMenuItem";
            this.退出CaptB点名器ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.退出CaptB点名器ToolStripMenuItem.Text = "退出CaptB点名器(&E)";
            this.退出CaptB点名器ToolStripMenuItem.Click += new System.EventHandler(this.退出CaptB点名器ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.完整名单ToolStripMenuItem,
            this.未点名单ToolStripMenuItem});
            this.查看ToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_9905;
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.查看ToolStripMenuItem.Text = "查看(&V)";
            // 
            // 完整名单ToolStripMenuItem
            // 
            this.完整名单ToolStripMenuItem.Enabled = global::新一代CaptB点名器.Properties.Settings.Default.完整名单_Enabled;
            this.完整名单ToolStripMenuItem.Name = "完整名单ToolStripMenuItem";
            this.完整名单ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.完整名单ToolStripMenuItem.Text = "完整名单(&A)";
            this.完整名单ToolStripMenuItem.Click += new System.EventHandler(this.完整名单ToolStripMenuItem_Click);
            // 
            // 未点名单ToolStripMenuItem
            // 
            this.未点名单ToolStripMenuItem.Enabled = global::新一代CaptB点名器.Properties.Settings.Default.未点名单_Enabled;
            this.未点名单ToolStripMenuItem.Name = "未点名单ToolStripMenuItem";
            this.未点名单ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.未点名单ToolStripMenuItem.Text = "未点名单(&B)";
            this.未点名单ToolStripMenuItem.Click += new System.EventHandler(this.未点名单ToolStripMenuItem_Click);
            // 
            // 首选项PToolStripMenuItem
            // 
            this.首选项PToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_9960;
            this.首选项PToolStripMenuItem.Name = "首选项PToolStripMenuItem";
            this.首选项PToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.首选项PToolStripMenuItem.Text = "首选项(&P)";
            this.首选项PToolStripMenuItem.Click += new System.EventHandler(this.首选项PToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入门GToolStripMenuItem,
            this.新增功能WToolStripMenuItem,
            this.toolStripSeparator2,
            this.发送反馈FToolStripMenuItem,
            this.toolStripSeparator3,
            this.检查更新LToolStripMenuItem,
            this.toolStripSeparator4,
            this.技术支持TToolStripMenuItem,
            this.隐私政策PToolStripMenuItem,
            this.toolStripSeparator5,
            this.关于CaptB点名器ToolStripMenuItem1});
            this.帮助HToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_5350;
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 入门GToolStripMenuItem
            // 
            this.入门GToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_0378;
            this.入门GToolStripMenuItem.Name = "入门GToolStripMenuItem";
            this.入门GToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.入门GToolStripMenuItem.Text = "入门(&G)";
            this.入门GToolStripMenuItem.Click += new System.EventHandler(this.入门GToolStripMenuItem_Click);
            // 
            // 新增功能WToolStripMenuItem
            // 
            this.新增功能WToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_1657;
            this.新增功能WToolStripMenuItem.Name = "新增功能WToolStripMenuItem";
            this.新增功能WToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.新增功能WToolStripMenuItem.Text = "新增功能(&W)";
            this.新增功能WToolStripMenuItem.Click += new System.EventHandler(this.新增功能WToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // 发送反馈FToolStripMenuItem
            // 
            this.发送反馈FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.报告问题ToolStripMenuItem,
            this.建议功能LToolStripMenuItem});
            this.发送反馈FToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_0096;
            this.发送反馈FToolStripMenuItem.Name = "发送反馈FToolStripMenuItem";
            this.发送反馈FToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.发送反馈FToolStripMenuItem.Text = "发送反馈(&F)";
            // 
            // 报告问题ToolStripMenuItem
            // 
            this.报告问题ToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_0068;
            this.报告问题ToolStripMenuItem.Name = "报告问题ToolStripMenuItem";
            this.报告问题ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.报告问题ToolStripMenuItem.Text = "报告问题(&P)";
            this.报告问题ToolStripMenuItem.Click += new System.EventHandler(this.报告问题ToolStripMenuItem_Click);
            // 
            // 建议功能LToolStripMenuItem
            // 
            this.建议功能LToolStripMenuItem.Name = "建议功能LToolStripMenuItem";
            this.建议功能LToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.建议功能LToolStripMenuItem.Text = "建议功能(&S)";
            this.建议功能LToolStripMenuItem.Click += new System.EventHandler(this.建议功能LToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // 检查更新LToolStripMenuItem
            // 
            this.检查更新LToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_0248;
            this.检查更新LToolStripMenuItem.Name = "检查更新LToolStripMenuItem";
            this.检查更新LToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.检查更新LToolStripMenuItem.Text = "检查更新(&U)";
            this.检查更新LToolStripMenuItem.Click += new System.EventHandler(this.检查更新LToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // 技术支持TToolStripMenuItem
            // 
            this.技术支持TToolStripMenuItem.Image = global::新一代CaptB点名器.Properties.Resources.Icon_9948;
            this.技术支持TToolStripMenuItem.Name = "技术支持TToolStripMenuItem";
            this.技术支持TToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.技术支持TToolStripMenuItem.Text = "技术支持(&T)";
            this.技术支持TToolStripMenuItem.Click += new System.EventHandler(this.技术支持TToolStripMenuItem_Click);
            // 
            // 隐私政策PToolStripMenuItem
            // 
            this.隐私政策PToolStripMenuItem.Name = "隐私政策PToolStripMenuItem";
            this.隐私政策PToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.隐私政策PToolStripMenuItem.Text = "隐私政策(&P)";
            this.隐私政策PToolStripMenuItem.Click += new System.EventHandler(this.隐私政策PToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(184, 6);
            // 
            // 关于CaptB点名器ToolStripMenuItem1
            // 
            this.关于CaptB点名器ToolStripMenuItem1.Image = global::新一代CaptB点名器.Properties.Resources.Icon_9922;
            this.关于CaptB点名器ToolStripMenuItem1.Name = "关于CaptB点名器ToolStripMenuItem1";
            this.关于CaptB点名器ToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.关于CaptB点名器ToolStripMenuItem1.Text = "关于CaptB点名器(&A)";
            this.关于CaptB点名器ToolStripMenuItem1.Click += new System.EventHandler(this.关于CaptB点名器ToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(201, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 118);
            this.button1.TabIndex = 1;
            this.button1.Text = global::新一代CaptB点名器.Properties.Settings.Default.InitialWord;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制当前值ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // 复制当前值ToolStripMenuItem
            // 
            this.复制当前值ToolStripMenuItem.Name = "复制当前值ToolStripMenuItem";
            this.复制当前值ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.复制当前值ToolStripMenuItem.Text = "复制当前值";
            this.复制当前值ToolStripMenuItem.Click += new System.EventHandler(this.复制当前值ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(201, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = global::新一代CaptB点名器.Properties.Resources.button2_Text;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(391, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = global::新一代CaptB点名器.Properties.Resources.button3_Text;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(201, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(378, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = global::新一代CaptB点名器.Properties.Resources.button4_Text;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CaptB点名器";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::新一代CaptB点名器.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 407);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "CaptB点名器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出CaptB点名器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完整名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 未点名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入名单AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出名单CToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 首选项PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入门GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增功能WToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 发送反馈FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报告问题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 建议功能LToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 检查更新LToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 技术支持TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐私政策PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 关于CaptB点名器ToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.ToolStripMenuItem 编辑名单BToolStripMenuItem;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制当前值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除名单ToolStripMenuItem;
        internal System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

