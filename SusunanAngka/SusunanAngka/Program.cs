using System;
using System.Collections.Generic;

namespace SusunanAngka
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            Console.Write("Masukan Nilai: ");
            val = Console.ReadLine();
            Console.WriteLine(val);
            int x = int.Parse(val);
            int xx = x - 1;
            String  seq = "";

            List<String> temp1 = new List<String>();
            List<String> temp2 = new List<String>();
           
            for (int i = 0; i < x; i++)
            {
                if (xx > 0)
                {
                    temp1.Add(xx.ToString());
                }
                xx -= 1;
            }
            temp2 = temp1;

            for (int i = 0;i < temp1.Count;i++)
            {
                int ii = int.Parse(temp1[i]);
                for (int j = 0;j < temp2.Count;j++)
                {
                    int jj = int.Parse(temp2[j]);
                    int countSeq = ii;
                    seq = ii.ToString() + ",";
                    bool isSeqCheck = false;
                    for (int k = 0;k < x; k++)
                    {
                        if (jj > 0 && jj <= ii)
                        {
                            countSeq = countSeq + jj;
                            if (countSeq <= x)
                            {
                                seq = seq + jj.ToString() + ",";
                                isSeqCheck = true;
                            }
                            else
                            {
                                if (isSeqCheck)
                                {
                                    countSeq = countSeq - jj;
                                    jj = jj - 1;
                                }
                            }
                        }
                    }
                    String[] seqList = seq.Split(',');
                    if (seqList.Length > 2)
                    {
                        Console.WriteLine(seq);
                    }
                }
            }

        }
		
	}
}
