using System;
using System.Linq;
using System.Collections.Generic;

namespace Enkripsi
{
  public  class Program
    {
        public static void Main()
        {

            string val;
            Console.Write("Masukan Pesan: ");
            val = Console.ReadLine();

            int L = val.Length;
            int M = 1;
            int msgCount = 0;

            List<List<String>> x = new List<List<String>>();
            List<String> y  = new List<String>();
            List<List<String>> x2 = new List<List<String>>();
            List<String> y2 = new List<String>();
            char[] msgList = val.ToCharArray();
            Boolean isSquareFalse = false;
            String final = "";

            for (int i = 0; i < L; i++)
            {
                var data = i*i;
                if (!isSquareFalse)
                {
                    if (data >= L)
                    {
                        M = i;
                        isSquareFalse = true;
                    }
                }
            }

            for(int i = 0; i < M; i++)
            {
                y = new List<string>();
                for (int j = 0; j < M; j++)
                {
                    if(msgCount < L)
                    {
                        y.Add(msgList[msgCount].ToString());
                    }
                    else
                    {
                        y.Add("*");
                    }
                    msgCount++;
                }
                x.Add(y);
            }

            for (int i = 0; i < M; i++)
            {
                y2 = new List<string>();
                for (int j = 0; j < M; j++)
                {
                    y2.Add(x[(M - 1) - j][i]);
                }
                x2.Add(y2);
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (x2[i][j] != "*")
                    {
                        final = final + x2[i][j];
                    }
                }
            }
            Console.Write(final);
        }
    }
}
