namespace Listt
{
    public class IntList
    {
        private int[] array  = new int[0];

        public void Add(int number)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = number;
        }

        public void Add(int[] numbers)
        {
            int OldArrayLength = array.Length;
            Array.Resize(ref array, array.Length + numbers.Length);
            // 1 2
            // 3 4
            for (int i = array.Length-1; i < array.Length; i++) 
            {
                if(i >= OldArrayLength-1)
                    array[i] = numbers[i-OldArrayLength-1];
            }
        }

        public int Get(int index)
        {
            return array[index];
        }

        public int[] GetAll()
        {
            return array;
        }


        public void Print()
        {
            for(int i=0;i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


    }
}