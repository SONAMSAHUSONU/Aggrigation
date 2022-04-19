using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        // inheritance is clld the reused the code inheritance is the is-A relationship and 
        //if we have reused the the code then there is two way 1.Is-A Relationship 2.Has-A Relationship
        //
        public string fname = "Keylong";
        public string Lname = "System";
        public int age = 20;
        public int  Sum(int i, int j)
        {
        return i + j;
        }
        
    }
   public class Employee// Has-A Relationship:- we have to used as new keyworde it is called Has-A relationShip
    {
        public static void Main(string[] args)
        {
        Program p = new Program();
        Console.WriteLine(p.fname);
        Console.WriteLine(p.Sum(10, 20));

        }
    }

