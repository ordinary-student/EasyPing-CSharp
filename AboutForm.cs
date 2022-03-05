using System;
using System.Windows.Forms;

namespace EasyPing
{
    //自定义窗体类-关于
    public partial class AboutForm : Form
    {
        //窗口标题
        protected string Title;
        //内容
        protected string Information;
        //链接
        protected string Link;

        //构造方法
        public AboutForm(string title, string information,string link)
        {
            Title = title;
            Information = information;
            Link = link;
            //加载组件
            InitializeComponent();
            //加载内容
            InitUI();
        }

        //加载内容
        public void InitUI()
        {
            Text = Title;
            Label.Text = Information;
            LinkLabel.Text = "Website："+Link;
            LinkLabel.LinkArea = new LinkArea(8, LinkLabel.Text.Length-1);
        }

        //确认按钮点击事件
        private void OKButton_Click(object sender, EventArgs e)
        {
            //销毁实例
            Dispose();
        }

        //链接点击事件
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //调用系统默认浏览器打开链接
            System.Diagnostics.Process.Start(Link);
        }
    }
}
