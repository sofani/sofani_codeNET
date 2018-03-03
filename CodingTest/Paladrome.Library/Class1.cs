using System;
using System.Text.RegularExpressions;

namespace Paladrome.Library  {
    public class Class1 {


        public string isPaladrome(string myString) {
               
            //    myString = new Regex("[^a-zA-Z]").Replace(myString, "").ToLower();

               char[] array = myString.ToCharArray();
               Array.Reverse(array);
               string backwards = new string(array);
                
        
              return backwards;
           
        }
//
          //This is not working properly
          public bool isPaladrome2(string myString) {
               
               myString = new Regex("[^a-zA-Z]").Replace(myString, "").ToLower();

               char[] array = myString.ToCharArray();
               Array.Reverse(array);
               string backwards = new string(array);
                
               return array.Equals(backwards);
             
           
        }



        public bool isPaladrome3(int myNumber) {
            int r, sum = 0, temp;    
            temp = myNumber;    
            while(myNumber > 0) {    
                r = myNumber % 10;  //getting remainder  
                sum = (sum * 10) + r;    
                myNumber = myNumber / 10;    
            }    
            if(temp ==   sum)    
               return true;    
               else    
               return false;  
        }  
        
    }
}
