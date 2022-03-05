using System.Diagnostics;

namespace EasyPing
{
    //Ping类
    public class Ping
    {
        //IP地址
        public string IP;
        //Ping请求数
        public int Number;
        //Ping进程
        public Process Process;

        //构造方法
        public Ping(string ip, int number)
        {
            IP = ip;
            Number = number;
            //创建进程对象
            Process = new Process();
            //调用程序
            Process.StartInfo.FileName = "ping.exe";
            //是否使用Shell
            Process.StartInfo.UseShellExecute = false;
            //本程序接管输入输出流
            //重定向标准输入流
            Process.StartInfo.RedirectStandardInput = true;
            //重定向标准输出流
            Process.StartInfo.RedirectStandardOutput = true;
            //重定向标准错误流
            Process.StartInfo.RedirectStandardError = true;
            //不显示DOS窗口
            Process.StartInfo.CreateNoWindow = true;
            //设置参数
            Process.StartInfo.Arguments = ip + " -n " + number + " -w 600";
        }

        //执行Ping
        public bool Execute()
        {
            //执行Ping
            Process.Start();
            //读取结果
            string outText = Process.StandardOutput.ReadToEnd();
            //Console.WriteLine(outText);
            string upperOutText = outText.ToUpper();
            //查找TTL
            int index = upperOutText.IndexOf("TTL");
            //判断结果
            if (index == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }




    }
}
