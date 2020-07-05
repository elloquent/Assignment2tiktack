using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assignment2
{
    enum audience { world =1,group=2,special=3}
    class Tikok
    {
        //Private field
        private int _ID = 1;

        //public properties
        public string Originator { get; }
        public int Lengh { get; }

        public string Hastag { get; }

        public audience Audience { get; }

        public string id { get; }

        //pblic method
        public Tikok(string originator,int lengh,string hastag,audience aud)
        {
            Originator = originator;
            Lengh = lengh;
            Hastag = hastag;
            Audience = aud;
            id = _ID.ToString();
            _ID++;
          
                

        }

        private Tikok(string orig, string leng, string hast, string audience, string iD)
        {
          
        }

        public override string ToString()
        {
            return  $"{Originator } { Lengh} {Hastag } {Audience } {id }";
        }

        public static Tikok Parse (string line) 
        {
            string name = "", name1="", name2="", name3="",name4="";
           
            
            using (StreamReader sr = new StreamReader(line))
            {
                // Read the stream to a string, and write the string to the console.
                String lin = sr.ReadToEnd();
                
                sr.Close();
                TextReader reader = new StreamReader(line);
                string ine;

                while (null != (ine = reader.ReadLine()))            //stop if readline return null
                {
                    string[] arts = line.Split('\t');                //split the line into its parts
                   
                     name = arts[0];
                     name1 = arts[1];
                     name2 = arts[2];
                     name3 = arts[3];
                    name3 = arts[4];

                }
                reader.Close();
                Tikok ki = new Tikok(name, name1, name2, name3,name4);





                return ki;
            {
                
            }
                
                

            }
        }


    }
}
