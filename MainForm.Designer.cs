using System;
namespace EasyPing
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_About = new System.Windows.Forms.Button();
            this.Button_Settting = new System.Windows.Forms.Button();
            this.Button_Ping = new System.Windows.Forms.Button();
            this.TextBox_EndIP = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox_StartIP = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.TimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.Button_About);
            this.GroupBox1.Controls.Add(this.Button_Settting);
            this.GroupBox1.Controls.Add(this.Button_Ping);
            this.GroupBox1.Controls.Add(this.TextBox_EndIP);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.TextBox_StartIP);
            this.GroupBox1.Location = new System.Drawing.Point(13, 13);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(959, 83);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "请填写待检测的IP地址范围";
            // 
            // Button_About
            // 
            this.Button_About.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_About.Font = new System.Drawing.Font("宋体", 14F);
            this.Button_About.Location = new System.Drawing.Point(840, 30);
            this.Button_About.Name = "Button_About";
            this.Button_About.Size = new System.Drawing.Size(100, 29);
            this.Button_About.TabIndex = 4;
            this.Button_About.Text = "关于";
            this.Button_About.UseVisualStyleBackColor = true;
            this.Button_About.Click += new System.EventHandler(this.Button_About_Click);
            // 
            // Button_Settting
            // 
            this.Button_Settting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Settting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Settting.Font = new System.Drawing.Font("宋体", 14F);
            this.Button_Settting.Location = new System.Drawing.Point(720, 30);
            this.Button_Settting.Name = "Button_Settting";
            this.Button_Settting.Size = new System.Drawing.Size(100, 29);
            this.Button_Settting.TabIndex = 3;
            this.Button_Settting.Text = "设置";
            this.Button_Settting.UseVisualStyleBackColor = true;
            this.Button_Settting.Click += new System.EventHandler(this.Button_Settting_Click);
            // 
            // Button_Ping
            // 
            this.Button_Ping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Ping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Button_Ping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Ping.Font = new System.Drawing.Font("宋体", 14F);
            this.Button_Ping.Location = new System.Drawing.Point(600, 30);
            this.Button_Ping.Name = "Button_Ping";
            this.Button_Ping.Size = new System.Drawing.Size(100, 29);
            this.Button_Ping.TabIndex = 2;
            this.Button_Ping.Text = "Ping";
            this.Button_Ping.UseVisualStyleBackColor = false;
            this.Button_Ping.Click += new System.EventHandler(this.Button_Ping_Click);
            this.Button_Ping.MouseEnter += new System.EventHandler(this.Button_Ping_MouseEnter);
            this.Button_Ping.MouseLeave += new System.EventHandler(this.Button_Ping_MouseLeave);
            // 
            // TextBox_EndIP
            // 
            this.TextBox_EndIP.AcceptsReturn = true;
            this.TextBox_EndIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBox_EndIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_EndIP.Location = new System.Drawing.Point(287, 30);
            this.TextBox_EndIP.MaxLength = 15;
            this.TextBox_EndIP.Name = "TextBox_EndIP";
            this.TextBox_EndIP.Size = new System.Drawing.Size(200, 29);
            this.TextBox_EndIP.TabIndex = 1;
            this.TextBox_EndIP.WordWrap = false;
            this.TextBox_EndIP.TextChanged += new System.EventHandler(this.TextBox_EndIP_TextChanged);
            this.TextBox_EndIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_EndIP_KeyPress);
            this.TextBox_EndIP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_EndIP_KeyUp);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(220, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 22);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "    -    ";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_StartIP
            // 
            this.TextBox_StartIP.AcceptsReturn = true;
            this.TextBox_StartIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBox_StartIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_StartIP.Location = new System.Drawing.Point(10, 30);
            this.TextBox_StartIP.MaxLength = 15;
            this.TextBox_StartIP.Name = "TextBox_StartIP";
            this.TextBox_StartIP.Size = new System.Drawing.Size(200, 29);
            this.TextBox_StartIP.TabIndex = 0;
            this.TextBox_StartIP.WordWrap = false;
            this.TextBox_StartIP.TextChanged += new System.EventHandler(this.TextBox_StartIP_TextChanged);
            this.TextBox_StartIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_StartIP_KeyPress);
            this.TextBox_StartIP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_StartIP_KeyUp);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.TableLayoutPanel);
            this.GroupBox2.Location = new System.Drawing.Point(13, 103);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(959, 583);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "IP检测结果";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 16;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.TableLayoutPanel.RowCount = 16;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.Size = new System.Drawing.Size(953, 558);
            this.TableLayoutPanel.TabIndex = 10;
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ProgressBar,
            this.TimeLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 689);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(984, 22);
            this.StatusStrip.TabIndex = 8;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(550, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "欢迎使用";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoSize = false;
            this.ProgressBar.Maximum = 256;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(200, 16);
            this.ProgressBar.Step = 1;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(186, 17);
            this.TimeLabel.Text = "当前时间：2022-03-06 00:00:00";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyPing - 本机IP地址：";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox TextBox_StartIP;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBox_EndIP;
        private System.Windows.Forms.Button Button_Ping;
        private System.Windows.Forms.Button Button_About;
        private System.Windows.Forms.Button Button_Settting;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimeLabel;
        private System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        public System.Windows.Forms.ToolStripProgressBar ProgressBar;
    }
}

