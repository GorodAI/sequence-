using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {  char[] ar;
            string a;
            FileStream input = new FileStream(@"INPUT.txt", FileMode.Open, FileAccess.Read);
            FileStream output = new FileStream("OUTPUT.txt", FileMode.Create, FileAccess.Write);
            StreamReader reader=new StreamReader(input);
            StreamWriter writer = new StreamWriter(output);
            a=reader.ReadLine();
            //ar=a.ToCharArray(0,a.Length);
            //File.WriteAllText("INPUT.txt","");
            int k = 0, h = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                    if (a[i] == '1')
                    {
                        k++;
                    }
                    else
                    {
                        if (h < k)
                            h = k;
                    }
                if (i > 0)
                {
                    if ((a[i - 1] == '1') && (a[i] == '1'))
                    {
                        k++;
                    }
                    else
                    {
                        if (h < k)
                            h = k;
                        if (h >= a.Length - i)
                            break;
                    }
                }
            }
                if (k>h) h=k;
            Console.WriteLine(h);
            ar = new char[h];
            for (int i = 0; i < h; i++)
                ar[i] = '1';
                writer.WriteLine(ar);
                writer.Close();
            Console.ReadKey();
        }
    }
}
