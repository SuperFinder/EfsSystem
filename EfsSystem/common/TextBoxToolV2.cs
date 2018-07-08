using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace EfsSystem.common
{
    public static class TextBoxToolV2
    {
        private const int emSetcuebanner = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern Int32 SendMessage
            (IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        /// <summary>
        /// 为TextBox设置水印文字
        /// </summary>
        /// <param name="textBox">TextBox</param>
        /// <param name="watermark">水印文字</param>
        public static void setWatermark(this ComboBox textBox, string watermark)
        {
            SendMessage(textBox.Handle, emSetcuebanner, 0, watermark);
        }
        /// <summary>
        /// 清除水印文字
        /// </summary>
        /// <param name="textBox">TextBox</param>
        public static void clearWatermark(this ComboBox textBox)
        {
            SendMessage(textBox.Handle, emSetcuebanner, 0, string.Empty);
        }
    }
}
