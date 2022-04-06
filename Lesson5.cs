using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Homework_1
{
    internal static class Lesson5
    {
        internal static byte[] GetData(string info)
        {
            byte[] _data = new byte[info.Length];
            string buffer = "";
            int j = 0;
            //make byte array with string length
            for (int i = 0; i < info.Length; i++)
            {
                buffer += info[i];
                if (info[i] == ' ' || i == info.Length - 1)
                {
                    _data[i] = byte.Parse(buffer);
                    buffer = "";
                    j++;
                }
            }
            //make byte array without 0
            byte[] data = new byte[j];
            j = 0;
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i] != 0)
                {
                    data[j] = _data[i];
                    j++;
                }
            }
            return data;
        }
    }
}
