using System;
namespace Maxfour
{
    class Fourdigit
    {

        string input = "3489794532324";
        int[] array = new int[20];
        int index = 0;
        int max = 0;
        public static void Main(string[] args)
        {
            Fourdigit obj_Digit = new Fourdigit();

            if (obj_Digit.input.Length < 4)
            {
                Console.WriteLine("not possible");
            }

            else if(obj_Digit.input.Length==4)
            {
                Console.WriteLine(obj_Digit.input);
            }

            else 
            {
                //input values dupping into the array by converting in to int;
                while (obj_Digit.index != obj_Digit.input.Length)
                {
                    int num = (int)obj_Digit.input[obj_Digit.index]-48;

                    obj_Digit.array[obj_Digit.index] = num;
                    obj_Digit.index += 1;

                }

                // product of four adjecent digits
                for (int j_index = 0; j_index < obj_Digit.array.Length - 3; j_index++)
                {
                    int fourdigit_product = obj_Digit.array[j_index] * obj_Digit.array[j_index + 1] *obj_Digit.array[j_index + 2] * obj_Digit.array[j_index + 3];

                    //it checks which is max product
                    if (fourdigit_product > obj_Digit.max)
                    {
                        obj_Digit.max = fourdigit_product;
                    }
                }
                Console.WriteLine(obj_Digit.max);
            }
        }
        
    }
}