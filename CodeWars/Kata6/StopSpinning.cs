namespace CodeWars.Kata6 {
    class Program {
       
        public static string SpinWords(string sentence) {

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++) {
                if (words[i].Length >= 5) {

                    words[i] = new string(words[i].Reverse().ToArray());

                }
            }
            string modifiedSentence = string.Join(' ', words);

            return modifiedSentence;
        }
    }
}