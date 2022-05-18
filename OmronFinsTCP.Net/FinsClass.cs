using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OmronFinsTCP.Net
{
    partial class FinsClass
    {
        /// <summary>
        /// 获取内存区码
        /// </summary>
        /// <param name="mr">寄存器类型</param>
        /// <param name="mt">地址类型</param>
        /// <returns></returns>
        internal static byte GetMemoryCode(PlcMemory mr, MemoryType mt)
        {
            if (mt == MemoryType.Bit)
            {
                switch (mr)
                {
                    case PlcMemory.CIO:
                        return 0x30;
                    case PlcMemory.WR:
                        return 0x31;
                    case PlcMemory.HR:
                        return 0x32;
                    case PlcMemory.AR:
                        return 0x33;
                    case PlcMemory.DM:
                        return 0x02;
                    default:
                        return 0x00;
                }
            }
            else
            {
                switch (mr)
                {
                    case PlcMemory.CIO:
                        return 0xB0;
                    case PlcMemory.WR:
                        return 0xB1;
                    case PlcMemory.HR:
                        return 0xB2;
                    case PlcMemory.AR:
                        return 0xB3;
                    case PlcMemory.DM:
                        return 0x82;
                    default:
                        return 0x00;
                }
            }
        }

        /// <summary>
        /// PC请求连接的握手信号，第一次连接会分配PC节点号
        /// </summary>
        /// <returns></returns>
        internal static byte[] HandShake()
        {
            #region fins command
            byte[] array = new byte[20];
            array[0] = 0x46;
            array[1] = 0x49;
            array[2] = 0x4E;
            array[3] = 0x53;

            array[4] = 0;
            array[5] = 0;
            array[6] = 0;
            array[7] = 0x0C;

            array[8] = 0;
            array[9] = 0;
            array[10] = 0;
            array[11] = 0;

            array[12] = 0;
            array[13] = 0;
            array[14] = 0;
            array[15] = 0;//ERR？

            array[16] = 0;
            array[17] = 0;
            array[18] = 0;
            array[19] = 0;//TODO:ask for client and server node number, the client node will allocated automatically
            //array[19] = this.GetIPNode(lIP);//本机IP地址的末位
            #endregion fins command
            return array;
        }
    }
}
