using System;
using System.Threading.Channels;

namespace Str
{
    public class Substrings
    {
        
        string main_str ="";
        string sub_str = "ab";
        int count = 0;
        public static void Main(string[] args)
        {
            Substrings str_obj = new Substrings();

            Console.WriteLine("enter the string");
            str_obj.main_str = Console.ReadLine();

            int main_len = str_obj.main_str.Length;
            int sub_len = str_obj.sub_str.Length;

            //checking the len of main_str and sub_str
            if (main_len<sub_len)
            {
                Console.WriteLine("not possible");
            }

            //to split main_str to substring and checking with the sub_string
            for(int index=0 ; index<main_len +1 - sub_len ; index++)
            {
                string s3 = str_obj.main_str.Substring(index, sub_len);

                if (str_obj.sub_str == s3)
                {
                    str_obj.count += 1;
                    Console.WriteLine(index);
                }
                
            }
            Console.WriteLine(str_obj.count);
        }
    }
}