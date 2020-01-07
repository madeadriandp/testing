using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class Tugas
    {
        public int hitungjumlahkarakter(string input)
        {
            return input.Length;
        }

        public string grade(int input)
        {
              if(input >= 90)
            { 
                return "A";
            }
            else if (input>=80 && input<=89)
            {
                return "B";
            }

            else if( input>=70 && input<=79)
            {
                return "C";
            }

             else if( input>=60 && input<=69)
            {
               return "D";
            }
            else
            {
                return "E";
            }  
        }

        public string ganjilgenap(string input)
        {
            // int hasil =Int32.Parse(input);
            if(input.Length%2==0)
            { 
                return "Genap";
            }
            else 
            {
               return "Ganjil";
            }
        } 

        public string kabisat(int hasil)
        {
        //   int hasil =Int32.Parse(input);
           if(hasil%400==0)
            { return "Kabisat";
            }
            else if(hasil%4==0 && hasil%100==0)
            {
                return "Bukan Kabisat";
            }
            else if(hasil%4==0)
            {
                return "Kabisat";
            }
            
            else
            {
               return "Bukan Kabisat";
            }

        }

        public string filmrating (int input)
        {
            if(input>=21)
            { return "DEWASA";
            }
            else if(input>=13 && input<=20)
            {
                return "REMAJA";
            }
            else if(input>=9 && input<=12)
            {
               return "BIMBINGAN ORANG TUA";
            }
            else
            {
                return "SEMUA USIA";

            }

        }

        public List<int> looprange (int a, int b)
        {   
            List<int> tampung = new List<int>();
            foreach( int index in Enumerable.Range(a, b))
            {    
                tampung.Add(index);
            }
            return tampung;


        } 

        public List<int> ganjil100 ()
        {
            return Enumerable.Range(1,100).Where(a=>a%2!=0).ToList();
        }

        public List<string> kelipatan1000()
        {
            return Enumerable.Range(1,1000).Select(a=>{
                if (a%100==0)return "Kelipatan Seratus";
                if (a%2==0 && a%5==0) return "Genap Kelipatan Lima";
                if (a%2!=0 && a%5==0) return "Ganjil Kelipatan Lima";
                if (a%2!=0) return "Ganjil";
                return "Genap";
                }).ToList();
        }

        public string balikkata(string input)
        {
            string[] input2 = input.Split(' ');
            Array.Reverse(input2);
            return string.Join(" ", input2);
            //  string input3 = String.Join(" ", input2).ToList();
            
        }

        public List<string> addtoarray()
        {
             string[] stuff = {"Meja", "Buku", "Topi", "Baju", "Kayu"};
            List<string> tampung = stuff.ToList();
            
            tampung.Add("Celana");
            tampung.Insert(0, "Handuk");

            return tampung;

            
        }
    }
}
