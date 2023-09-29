namespace Kata
{
    class Program
    {
        public static void Main(string[] args)
        {
            object[][] arrayToSearch = new object[][] { new object[] { 1, 2 }, new object[] { 3, 4 }, new object[] { 5, 6 } };
            var query = new object[] { 9, 2 };

            Console.Write(FindIndex(arrayToSearch, query));
        }

        public static int FindIndex(object[][] arrayToSearch, object[] query)
        {
            if (!HasSubArrayLenthTwo(arrayToSearch, query))
            {
                throw new Exception();
            }

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                object[] inputArr = arrayToSearch[i];
                if (inputArr[0].Equals(query[0]) && inputArr[1].Equals(query[1]))
                {
                    return i;
                }

            }
            return -1;
        }

        public static bool HasSubArrayLenthTwo(object[][] inputArr, object[] query)
        {
            if(inputArr.Where(arr => arr.Count() != 2).Count() > 0 || query.Length != 2)
            {
                return false;
            }
            return true;
        }


    }
}