using System;
using System.Windows.Forms;

namespace EasyPing
{
    //自定义窗口类-设置
    public partial class SettingForm : Form
    {
        //构造方法
        public SettingForm(Form Parent, int number)
        {
            Owner = Parent;
            //加载组件
            InitializeComponent();
            //显示原来的请求数
            NumericUpDown.Value = number;
        }

        //数字输入框按键按下事件
        private void NumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine();
            //允许输入回车键 退格键 0-9
            if ((e.KeyChar == '\b') || ((e.KeyChar >= '0') && (e.KeyChar <= '9')))
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


        //取消按钮单击事件
        private void NoButton_Click(object sender, EventArgs e)
        {
            //销毁实例
            Dispose();
        }

        //确认按钮单击事件
        private void OKButton_Click(object sender, EventArgs e)
        {
            //获取父级
            MainForm parent = (MainForm)Owner;
            //设置请求数
            parent.SetPingRequestsNumber(int.Parse(NumericUpDown.Value.ToString()));
            //销毁实例
            Dispose();
        }

        //输入框获取光标
        public void GetFocus()
        {
            //输入框获取光标
            NumericUpDown.Focus();
            //NumericUpDown.Select(0, NumericUpDown.Text.Length);
        }

       
    }
}
