using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConvertByteArrayToInt64
{
    public class Converter
    {

    static public double MyBitToInt64(byte[] arr)
    {
      StringBuilder strbuild = new StringBuilder();
      for (int i = 0; i < 4; i++)
      {
        strbuild.Append(arr[i]);
      }
      return Convert.ToInt64(strbuild.ToString());
    }  
  }
}
