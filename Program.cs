using System;
using System.Text;

namespace LC_ReverseWordsInAString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "  a  b";
            string expected = "b a";
            Console.WriteLine("Input : "+input);
            string act = reverseWords(input);
            Console.WriteLine("Output : "+act);
            Console.WriteLine("Expect : "+expected);
            bool bEqual = false;
            if(String.Equals(act,expected))
            {
                bEqual = true;
            }
            Console.WriteLine("Pass?"+bEqual);
        
        }

        public static String reverseWords(string s) 
        {
            s = s.Trim();
            String[] strArray = s.Split(' ');
            String retReverseStr = "";
            StringBuilder SB = new StringBuilder();
            //SB = SB.reverse();
            int count  = strArray.Length;
            if(count > 0)
            {
                for(int i=count-1 ; i>=0 ; i--)
                {
                    strArray[i] = strArray[i].Trim();
                    if(strArray[i].Length>0)
                    {
                        SB.Append(strArray[i]).Append(" ");
                    }
            
                }
                if(SB.Length>0)
                {
                    SB = SB.Remove(SB.Length-1,1);
                    retReverseStr = SB.ToString();
                }
            }
            else
            {
                retReverseStr = s;
            }
        
            return retReverseStr;
        }
    }
}
