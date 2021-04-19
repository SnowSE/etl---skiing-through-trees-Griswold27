using System;
using System.IO;

namespace Skiing_Amongst_Trees
{
    class Program
    {
        static void Main(string[] args)
        {

            int rise;
            int run;
            int hits = 0;

            //String cRow;
            
            
            

            Console.WriteLine("Enter slope for traversal (run over rise): ");

            run = Convert.ToInt32(Console.ReadLine());
            rise = Convert.ToInt32(Console.ReadLine());
            int j = run;

            char current = ' ';
            //int[,] pos = new int[0,0];
            var sr = new StreamReader(@"C:\Users\seth.clark\Documents\CS2450 Projects\Skiing\etl---skiing-through-trees-Griswold27\Skiing_Amongst_Trees\TreeMap.txt");
            String whole = sr.ReadToEnd();

            //while(whole != null)
            String[] lines = whole.Split("\n");
            char[] row = new char[31];
            {
                //for(y=0; y < 323; y++)
                //while(!sr.EndOfStream)
                //while (whole != null) 
                //{
                    for (int i = rise; i < 323; i += rise)
                    {
                    //int j = run;
                        
                        row[j] = (char)lines[i][j];
                            //Console.Write(row[j]);
                            
                            
                        current = row[j];
                        

                    if (current == '#')
                    {
                        //row[j] = 'O';
                        hits++;
                    }

                    //string cRow = new string(row);
                    //Console.WriteLine(row);
                    //Console.WriteLine(lines[i]);

                    j += run;
                    if (j >= 31)
                        j %= 31;
                }
               // }
                Console.WriteLine("\n number of hits: {0}", hits);
                
            }
        }
    }
}
