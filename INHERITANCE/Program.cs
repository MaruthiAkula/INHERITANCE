using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    public class Baseclass
    {
      public string studentname;
      public string fathername;
      public string number;
    }
    public class Derivedclass:Baseclass
    {
       public string fathernum;
       public string studentnum;
      /*  void Numfunction()
        {
            Console.WriteLine("father Num is {0},Student Num is {1}", fathernum, studentnum);
        }*/
    }
    public class childclass:Derivedclass
    {
       public string fatheroccupation;
       public string studentqualification;
        public void printalldetails()
        {
            Console.WriteLine("father Name is {0},Student Name is {1}", fathername, studentname);
            Console.WriteLine("father occupation is {0},Student qualification is {1}", fatheroccupation, studentqualification);
            Console.WriteLine("father Num is {0},Student Num is {1}", fathernum, studentnum);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            childclass obj = new childclass();
            obj.studentnum = "rahul";
            obj.fathername = "sitaramaraju";
            obj.fathernum = "99999999999";
            obj.studentnum = "11111111111";
            obj.studentqualification = "B.tech";
            obj.fatheroccupation = "farmer";
            obj.printalldetails();
        }
    }
}
