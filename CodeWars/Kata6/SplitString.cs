
using System.Collections.Generic;

namespace CodeWars.Kata6 {

    class Split {
       
        public static string[] SplitInPairs(string str) {

            List<string> pairs = new List<string>();

            for (int i = 0; i < str.Length; i += 2) {
                if (i + 1 < str.Length) {
                    pairs.Add(str.Substring(i, 2));
                }
                else {
                    pairs.Add(str.Substring(i) + '_');
                }
            }
            return pairs.ToArray();
        }
    }

}










