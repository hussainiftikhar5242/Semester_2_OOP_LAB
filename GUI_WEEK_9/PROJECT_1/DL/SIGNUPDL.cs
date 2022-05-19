using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_1.BL;

namespace Project_1.DL
{
    class SIGNUPDL
    {
        static List<SIGNUP> Data = new List<SIGNUP>();
        public static void AddIntoList(string Name,string Password)
        {
            SIGNUP Temp = new SIGNUP(Name, Password);
            Data.Add(Temp);
        }
        public static bool CheckUser(string Name,string Password)
        {
            foreach(SIGNUP temp in Data)
            {
                if(temp.Name1 == Name && temp.Password1 == Password)
                {
                    return true;
                }
            }
            return false;
        }
        public static void AddDataIntoFile(string Path,SIGNUP Temp)
        {
            StreamWriter UFile = new StreamWriter(Path,true);
            UFile.WriteLine(Temp.Name1 + "," + Temp.Password1);
            UFile.Flush();
            UFile.Close();
        }
        public static void ReadDataFromFile(string Path)
        {
            StreamReader UFile = new StreamReader(Path);
            string Record;
            if(File.Exists(Path))
            {
                while ((Record = UFile.ReadLine()) != null)
                {
                    string[] SplitReccord = Record.Split(',');
                    string Name = SplitReccord[0];
                    string Password = SplitReccord[1];
                    AddIntoList(Name, Password);
                }
                UFile.Close();
            }

        }
    }
}
