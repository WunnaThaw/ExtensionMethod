using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Wunna";
            //s = s.SubString(0, 4);

            var st = new Student();

            //s.SafeSubString(3, 4);
             
            if(s.Length > 3)
                s.Substring(3,5);
            
            
            

            // Wait for user input
            Console.ReadKey();
        }
    }

    public class Student
    {
        public string GetName()
        {
            return String.Empty;
        }
    }

    public static class StringExt
    {
        public static int GetID(this Student stu)
        {
            return 1;
        }

        public static string TeacherName(this Student Tname)
        {
            //string a = string.Empty;
            return "MOMM";
        }

        public static string SafeSubString(this string str, int startIndex, int length)
        {
            string temp = String.Empty;
            if(str.Length > startIndex)
                temp = str.Substring(startIndex,length);
            else 
                temp = str;

            return temp;
        }
    }

    //public static class StringExtension
    //{
    //    public static String SubString(this string str, int from, int maxlength)
    //    {
    //        String res = String.Empty;

    //        if (str != String.Empty && str.Length > (from + maxlength))
    //            res = str.Substring(from, maxlength);
    //        else
    //            res = str;

    //        return res;
    //    }

    //    public static String MyOwnSubString(this string str, int from, int maxlength)
    //    {
    //        String res = String.Empty;

    //        if (str != String.Empty && str.Length > (from + maxlength))
    //            res = str.Substring(from, maxlength);
    //        else
    //            res = str;

    //        return res;
    //    }

    //}
}
