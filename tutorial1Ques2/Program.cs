using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial1Ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string Name = "";
            string HomeTown = "";
            string Hobby = "";
            string PetHate = "";

            //assign values
            Name = "Kirstie Chetty";
            HomeTown = "kwamashu";
            Hobby = "Fighting with nowen ";
            PetHate = "I dont know what this means";

            //display 

            Console.WriteLine("*************************************************");
            Console.WriteLine("*" +"Name:"+ "        " + Name + "/" + "      *");
            Console.WriteLine("*" +"HomeTown:"+ "        " + HomeTown + "/" + "       *");
            Console.WriteLine("*" +"Hobby"+ "        " + Hobby + "/" + "        *");
            Console.WriteLine("*" +"Pethate:"+ "        " + PetHate+ "/" + "       *");
            Console.Read();
        }
    }
}
