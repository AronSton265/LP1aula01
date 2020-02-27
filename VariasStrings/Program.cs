using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
			double xx = 0.12345;
			int ii = 18;
			string a = "A";
			string b = "B";
			string c = "Hello";
			string d = @"C:\Users\pedro\Downloads";
			string e = "\u0061 b \u0063 d";
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine(d);
			Console.WriteLine(e);

			int x = 2;
			int y = 4;
			string f = "Hello" + "world";
			string g = "A" + 9;
			string h= $"Valor de x é {x}";
			string i= $"{x}x{y}={x*y}";
			string j = String.Format("Valor de X é {0}", x);
			Console.WriteLine(f);
			Console.WriteLine(g);
			Console.WriteLine(h);
			Console.WriteLine(i);
			Console.WriteLine(j);
			Console.WriteLine("console write");

			string k = String.Format("{0:f2} e {0:p1}", xx);
			string m = String.Format("{0:x} e {0:c}", ii);
			Console.WriteLine(k);
			Console.WriteLine(m);
		}
    }
}
