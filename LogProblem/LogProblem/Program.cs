using System;
using System.IO;
using LogProblem.Entities;

namespace Problem {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();


            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string username = line[0];
                        DateTime instant  = DateTime.Parse(line[1]);
                        Console.WriteLine(line);
                        set.Add(new LogRecord { 
                            Username = username,
                            Instant = instant 
                        });
                    }
                }

            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Total users: " + set.Count);
        }
    }
}