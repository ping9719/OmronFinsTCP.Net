using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OmronFinsTCP.Net
{
    partial class ConvertClass
    {
        /// <summary>
        /// 得到枚举值
        /// </summary>
        /// <param name="txt">如：D100,W100.1</param>
        /// <param name="txtq"></param>
        /// <returns></returns>
        internal static PlcMemory GetPlcMemory(string txt, out string txtq)
        {
            PlcMemory pm = PlcMemory.DM;
            var da = txt.Trim().ToUpper().FirstOrDefault();
            switch (da)
            {
                case 'D':
                    pm = PlcMemory.CIO;
                    break;
                case 'W':
                    pm = PlcMemory.CIO;
                    break;
                case 'H':
                    pm = PlcMemory.CIO;
                    break;
                case 'A':
                    pm = PlcMemory.CIO;
                    break;
                case 'C':
                    pm = PlcMemory.CIO;
                    break;
                default:
                    throw new Exception($"寄存器【{txt}】无效的前缀[{da}]");
            }

            //保留数字和.
            txtq = Regex.Replace(txt, "[^0-9.]", "");
            return pm;
        }
    }
}
