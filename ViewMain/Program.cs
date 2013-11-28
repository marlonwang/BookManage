/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2013/11/10
 * 时间: 16:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Windows.Forms;

namespace ViewMain
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BMSLogin login = new BMSLogin();
            //Application.Run(login);        //运行 BMSLogin.cs
            //主窗体
            //Application.Run(new MainForm());
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new BookForm());//进入主窗体 
            }
        }
		
	}
}
