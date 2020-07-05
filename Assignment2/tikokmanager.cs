using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;

namespace Assignment2
{
    class tikokmanager
    {
        static  List<Tikok> tikos;
      
        static string filename = "assign.txt";

        static tikokmanager()
        {
            initialize();
            using (StreamReader sr = new StreamReader("assign.txt"))
            {
                // Read the stream to a string, and write the string to the console.
                String ine = sr.ReadToEnd();

                sr.Close();


                while (null != ine)       //stop if readline return null
                {
                    //Tikok.Parse(ine);
                    Tikok.Parse(ine);


                }
            }
        }

        public static void initialize()
        {
            
            
                Tikok t = new Tikok("richard", 34, "#elridge", audience.world);
                Tikok t1 = new Tikok("Dashawn", 24, "#Davis", audience.group);
                Tikok t2 = new Tikok("Bobby", 4, "#Black", audience.special);
                Tikok t3 = new Tikok("Dacy", 40, "#elridge", audience.world);
                Tikok t4 = new Tikok("Livistand", 39, "#callotto", audience.group);
            List<Tikok> tikos = new List<Tikok>()
            { t,t1,t2,t3,t4};

           

            foreach (Tikok item in tikos)
            {
                filename = item.ToString();
                Console.WriteLine(item);
            }


        }

        public static void show()
        {
            foreach (Tikok item in tikos)
            {
                Console.WriteLine(item);
            }

        }

        public static void show(string tag)
        {
            foreach (Tikok item in tikos)
            {
                
                if(item.Hastag ==tag)
                {
                    for (int i = 0; i < tag.Length; i++)
                    {
                        if (char.IsUpper(tag[i]))
                        {
                            Console.WriteLine(item);
                        }
                    }
                   
                    
                }
                else
                {
                    Console.WriteLine("Not matched");
                }
            }
        }

        public static void show(int lengh)
        {
            foreach (Tikok item in tikos)
            {

                if (item.Lengh > lengh)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("Not matched");
                }
            }

        }

        public static void show(audience aud)
        {
            foreach (Tikok item in tikos)
            {

                if (item.Audience == aud )
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("Not matched");
                }
            }
        }


    }
}
