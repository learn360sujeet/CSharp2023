

class ArrayConcept
{

    public static void ArrayDisplay(int[] arrNum)
    {       

        for (int i = 0; i < arrNum.Length; i++)
        {
            // value =numbers[i]
            // i= index of array
            Console.WriteLine("arr {0} - {1}", i, arrNum[i]);

        }

      
    }
    public static void Main()
    {

        // step 1 - Declaration 
        int[] numbers = new int[5]; // Length=5

        // Step 2 - Initialize 
        numbers[0] = 25;
        numbers[1] = 250;
        numbers[2] = 205;
        numbers[3] = 50;
        numbers[4] = 400;

     

        ArrayConcept.ArrayDisplay(numbers);

    }

}



