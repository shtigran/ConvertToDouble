using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using ConvertByteArrayToInt64;

namespace ConvertByteArrayToInt64
{
  class Program
  {
    static void Main(string[] args)
    {
      byte[] m = new byte[4];
      RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
      crypto.GetBytes(m);
      double exampl = Converter.MyBitToInt64(m);
      Console.WriteLine($"The double is: {exampl}");
      Console.ReadKey();
    }
  }
}
