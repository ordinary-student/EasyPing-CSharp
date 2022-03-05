using System;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace EasyPing
{
    //主窗口类
    public partial class MainForm : Form
    {
        //APP名称
        public string AppName = "EasyPing";
        //APP描述
        public string AppSummary = "检测局域网内IP地址的使用情况";
        //作者
        public string Author = "ordinary-student";
        //链接
        public string Href = "https://github.com/ordinary-student";
        //版本
        public string Version = "v1.0.0";
        //最后更新时间
        public string LastUpdateTime = "2022-03-01";

        //IP正则表达式
        public string IPRex = @"((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))$)";

        //标签数组
        public Label[] IPLabels = new Label[256];
        //不检测数量
        public int UnCheckCount = 0;
        //允许按钮标志
        public bool ButtonAllowClick = true;
        //请求数
        private int PingRequestsNumber = 4;

        //本机IP地址
        protected string LocalIP = "";
        //定义一个键值对集合
        public Dictionary<string, bool> ResultDictionary;
        // 显示进度条的委托声明
        public delegate void ShowProgressDelegate();


        //构造方法
        public MainForm()
        {
            //加载组件
            InitializeComponent();
            //时间标签文本设置为当前时间
            TimeLabel.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            //加载表格布局面板
            InitTableLayoutPanel();
            //获取本机IP地址
            GetLocalIP();

            //分割字符串
            string[] localips = LocalIP.Split('.');
            //输入框默认设置本机IP地址
            TextBox_StartIP.Text = localips[0] + "." + localips[1] + "." + localips[2] + ".0";
            //选中最后文本
            TextBox_StartIP.Select(TextBox_StartIP.Text.Length, 0);
            //光标移至最后
            TextBox_StartIP.ScrollToCaret();
        }

        //加载表格布局面板
        private void InitTableLayoutPanel()
        {
            int k = 0;
            //循环加载
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    //添加标签
                    Label ipLabel = new Label
                    {
                        Text = k.ToString(),
                        Width = 55,
                        Height = 30,
                        Font = new Font("隶书", 12, FontStyle.Bold),
                        BackColor = Color.LightGray,
                        TextAlign = ContentAlignment.MiddleCenter,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(2)
                    };

                    //添加标签
                    TableLayoutPanel.Controls.Add(ipLabel, j, i);
                    IPLabels[k] = ipLabel;

                    //
                    k += 1;
                }
            }
        }

        //检查IP地址是否合法
        private bool IsIPLegal(string ip)
        {
            return new Regex(IPRex).IsMatch(ip);
        }

        //检查两个输入框的IP地址是否合法
        private void CheckIP()
        {
            string tempString1;
            string tempString2;
            //判断输入的起始IP是否合法
            if (IsIPLegal(TextBox_StartIP.Text))
            {
                tempString1 = "起始IP地址合法  ";
            }
            else
            {
                tempString1 = "起始IP地址不合法  ";
            }

            //判断输入的结束IP是否合法
            if (IsIPLegal(TextBox_EndIP.Text))
            {
                tempString2 = "结束IP地址合法";
            }
            else
            {
                tempString2 = "结束IP地址不合法";
            }

            //设置状态栏文本
            StatusLabel.Text = tempString1 + tempString2;
        }

        //设置请求数
        public void SetPingRequestsNumber(int value)
        {
            PingRequestsNumber = value;
        }

        //获取本机IP地址
        private void GetLocalIP()
        {
            //获取本机主机名
            string name = Dns.GetHostName();
            //获取本机IP列表
            IPAddress[] ipadrlist = Dns.GetHostAddresses(name);
            //获取最后一个IP为本机IP地址
            LocalIP = ipadrlist[ipadrlist.Length - 1].ToString();
            //窗口标题文本
            string title = "EasyPing - 本机IP地址：";
            //遍历
            foreach (IPAddress ipa in ipadrlist)
            {
                //判断是否IPV4
                if (ipa.AddressFamily == AddressFamily.InterNetwork)
                    //拼接IP地址字符串
                    title += ipa.ToString() + "  ";
            }

            //设置窗体标题
            this.Text = title;
        }

        //Ping按钮鼠标进入事件
        private void Button_Ping_MouseEnter(object sender, EventArgs e)
        {
            //背景变绿色
            Button button = (Button)sender;
            button.BackColor = Color.Green;
            //文字变白色
            button.ForeColor = Color.White;
        }

        //Ping按钮鼠标离开事件
        private void Button_Ping_MouseLeave(object sender, EventArgs e)
        {
            //背景变回原色
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(225, 225, 225);
            //文字变黑色
            button.ForeColor = Color.Black;
        }

        //定时器触发事件
        private void Timer_Tick(object sender, EventArgs e)
        {
            //时间标签文本设置为当前时间
            TimeLabel.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            //判断进程是否结束
            if (ProgressBar.Value == ProgressBar.Maximum)
            {
                //当进度已达最大值，开放按钮
                ButtonAllowClick = true;
                Button_Ping.Enabled = true;
            }
        }

        //窗体加载事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            //定时器时间间隔-500毫秒
            Timer.Interval = 500;
            //启动定时器
            Timer.Start();
        }

        //关于按钮单击事件
        private void Button_About_Click(object sender, EventArgs e)
        {
            //组成内容
            string message = AppName + "\r\n" + AppSummary + "\r\nAuthor：" + Author + "\r\nVersion：" + Version + "\r\nLastUpdate：" + LastUpdateTime;
            //创建关于窗体
            AboutForm aboutForm = new AboutForm("关于" + AppName, message, Href);
            //阻塞父窗口
            aboutForm.ShowDialog();
        }

        //关于设置单击事件
        private void Button_Settting_Click(object sender, EventArgs e)
        {
            //创建设置窗体
            SettingForm settingForm = new SettingForm(this, PingRequestsNumber);
            //阻塞父窗口
            settingForm.ShowDialog();
            //输入框获取光标
            settingForm.GetFocus();
        }

        //起始IP输入框按键按下事件
        private void TextBox_StartIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //允许输入回车键 退格键 0-9 .
            if ((e.KeyChar == '\b') || (e.KeyChar == '.') || ((e.KeyChar >= '0') && (e.KeyChar <= '9')))
            {
                //获取或设置一个值，该值指示事件是否处理过
                //事件没有处理过，继续提交系统处理，即是填写所输入的字符到输入框
                e.Handled = false;
            }
            else
            {
                //输出其它内容则默认处理过，不再提交系统处理
                e.Handled = true;
            }
        }

        //起始IP输入框按键释放事件
        private void TextBox_StartIP_KeyUp(object sender, KeyEventArgs e)
        {
            //回车-结束IP输入框获取光标
            if (e.KeyCode == Keys.Enter)
            {
                //获取焦点
                TextBox_EndIP.Focus();
                //选中最后文本
                TextBox_EndIP.Select(TextBox_EndIP.Text.Length, 0);
                //TextBox_EndIP.SelectionStart = TextBox_EndIP.Text.Length;
                //光标移至最后
                TextBox_EndIP.ScrollToCaret();
            }
        }

        //起始IP输入框文本变化事件
        private void TextBox_StartIP_TextChanged(object sender, EventArgs e)
        {
            //判断输入的IP是否合法
            CheckIP();
            if (IsIPLegal(TextBox_StartIP.Text))
            {
                //分割起始IP地址
                string[] ips = TextBox_StartIP.Text.Split(new char[] { '.' });
                //拼接-尾部-作为结束IP
                TextBox_EndIP.Text = ips[0] + "." + ips[1] + "." + ips[2] + ".255";
            }
            else
            {
                //清空结束IP
                TextBox_EndIP.Text = "";
            }
        }

        //结束IP输入框按键按下事件
        private void TextBox_EndIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //允许输入回车键 退格键 0-9 .
            if ((e.KeyChar == '\b') || (e.KeyChar == '.') || ((e.KeyChar >= '0') && (e.KeyChar <= '9')))
            {
                //获取或设置一个值，该值指示事件是否处理过
                //事件没有处理过，继续提交系统处理，即是填写所输入的字符到输入框
                e.Handled = false;
            }
            else
            {
                //输出其它内容则默认处理过，不再提交系统处理
                e.Handled = true;
            }
        }

        //结束IP输入框按键释放事件
        private void TextBox_EndIP_KeyUp(object sender, KeyEventArgs e)
        {
            //回车-自动按下Ping按钮
            if (e.KeyCode == Keys.Enter)
            {
                Button_Ping.PerformClick();
            }
        }

        //结束IP输入框文本变化事件
        private void TextBox_EndIP_TextChanged(object sender, EventArgs e)
        {
            //判断输入的IP是否合法
            CheckIP();
        }

        //Ping按钮单击事件
        private void Button_Ping_Click(object sender, EventArgs e)
        {
            if (ButtonAllowClick)
            {
                ButtonAllowClick = false;
                Button_Ping.Enabled = false;
                //判断输入的IP是否合法
                CheckIP();
                if (IsIPLegal(TextBox_StartIP.Text) && IsIPLegal(TextBox_EndIP.Text))
                {                   
                    //创建结果键值对
                    ResultDictionary = new Dictionary<string, bool>(256);
                    //初始化所有IP标签背景为灰色
                    InitIPLabels();
                    //设置状态栏文本
                    StatusLabel.Text = "正在检测中...";
                    ProgressBar.Value = 0;
                    //获取待检测的IP数组
                    string[] ips = GetIPRange(TextBox_StartIP.Text, TextBox_EndIP.Text);
                    //设置进度最大值
                    ProgressBar.Maximum = ips.Length;
                    //未检测数量
                    UnCheckCount = 256 - ips.Length;

                    //循环创建线程
                    foreach (string ip in ips)
                    {
                        Thread t = new Thread(() => Ping(ip))
                        {
                            //后台线程
                            IsBackground = true
                        };

                        //执行
                        t.Start();
                    }

                    //设置状态栏文本
                    //StatusLabel.Text = "检测完成";
                }
                else
                {
                    ButtonAllowClick = true;
                    Button_Ping.Enabled = true;
                    MessageBox.Show("IP地址不合法！", "错误");
                    TextBox_EndIP.SelectAll();
                }
            }

        }

        //初始化所有IP标签
        private void InitIPLabels()
        {
            //初始化所有IP标签背景为灰色
            for (int i = 0; i < IPLabels.Length; i++)
            {
                IPLabels[i].BackColor = Color.LightGray;
            }
        }

        //根据Ping结果设置标签背景颜色
        private void SetLabelBackColor(string ip, bool result)
        {
            //分割字符串
            string[] ips = ip.Split('.');
            //获取IP最后一项
            int index = int.Parse(ips[ips.Length - 1]);
            //判断结果
            if (result)
            {
                IPLabels[index].BackColor = Color.Green;
            }
            else
            {
                IPLabels[index].BackColor = Color.LightCoral;
            }

        }

        //获取IP地址范围-需要检测的IP地址数组
        private string[] GetIPRange(string startIP, string endIP)
        {
            //分割字符串
            string[] ips1 = startIP.Split('.');
            string[] ips2 = endIP.Split('.');
            //获取IP最后一项
            int a1 = int.Parse(ips1[ips1.Length - 1]);
            int a2 = int.Parse(ips2[ips2.Length - 1]);
            //定义起始结束IP数字
            int startIndex, endIndex;
            //判断大小
            if (a2 < a1)
            {
                //结束IP小于起始IP
                startIndex = a2;
                endIndex = a1;
            }
            else
            {
                startIndex = a1;
                endIndex = a2;
            }

            //结果数组
            string[] ipRange = new string[endIndex - startIndex + 1];
            int x = 0;

            //组成数组
            for (int i = startIndex; i <= endIndex; i++)
            {
                ipRange[x] = ips1[0] + "." + ips1[1] + "." + ips1[2] + "." + i.ToString();
                x += 1;
            }

            //返回结果
            return ipRange;
        }

        //ping方法
        private void Ping(string ip)
        {
            //创建Ping实例
            Ping ping = new Ping(ip, PingRequestsNumber);
            //执行ping
            bool r = ping.Execute();
            //添加键值对数据,键必须唯一,值可重复
            ResultDictionary.Add(ip, r);
            //Console.WriteLine(ip);
            //设置标签背景色
            SetLabelBackColor(ip, r);
            //设置进度条
            ShowProgress();
        }

        // 更新进度条
        private void ShowProgress()
        {
            if (ProgressBar.ProgressBar.InvokeRequired)
            {
                //为了避免工作线程被阻塞，采用异步调用委托，ShowProgress方法套上一层壳（委托）
                //子线程把ShowProgress方法扔给主线程，叫主线程去执行，自己不会等，继续往下执行
                ProgressBar.ProgressBar.BeginInvoke(new ShowProgressDelegate(ShowProgress));
                //带参数
                //ProgressBar.ProgressBar.BeginInvoke(new ShowProgressDelegate(ShowProgress), new object[] { totalStep,currentStep });

                //区别
                //子线程把showProgress方法扔给主线程，叫主线程去执行，自己会等主线程执行完这个方法了，才继续往下执行
                //ProgressBar.ProgressBar.Invoke(new ShowProgressDelegate(ShowProgress), new object[] { currentStep });
            }
            else
            {
                //统计结果-结果为true的数量
                int count = CountResultDictionary();
                //状态栏显示统计结果
                StatusLabel.Text = " [ True：" + count.ToString() + " ]  [ False：" + (256 - UnCheckCount - count).ToString() + " ]  [ 未检测：" + UnCheckCount.ToString() + " ]";
                //更新进度条-进度+1步              
                ProgressBar.PerformStep();
            }
        }

        //统计字典结果
        private int CountResultDictionary()
        {
            //结果为true的数量
            int count = 0;
            //用数组把Dictionary的Value值存起来，然后遍历Values数组
            bool[] values = ResultDictionary.Values.ToArray();
            //遍历字典得到键值对
            foreach (bool v in values)
            {
                //如果值为true，则计数加一
                if (v)
                {
                    count += 1;
                }
            }

            //返回数量
            return count;
        }



    }
}
