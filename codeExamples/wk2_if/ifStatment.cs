using System;  //tells compiler to use a liberty called system

namespace exceptions //puts the code into a bucket called exceptions this is so a platform can use files with the same name
{// start definistion of functions in the namespace
    class Program // this means create me a template called program
    {//start of definistion of the Program object
        public static void Main(string[] args) //this is a function it teslls the compler to run the following code 
            //fun fact main is the entry point into a thread that one has to use ergo you are using threads out of the gate
        {//start function definistion
            int num1 = 12; //tells the complier to make a veriable of type int caled num 1 and assign it the value of 12 the ; means end delcluration
            int num2 = 14; //tells the complier to make a veriable of type int caled num 2 and assign it the value of 14 the ; means end delcluration
            int num3; //tells the complier to make a veriable of type int caled num 3. ; means end delcluration not you do not have to assgin values when declearing veriables

            num3 = num1 + num2; // tells the compiler to add the values of num 1 and 2 and assign it to num 3

            Console.WriteLine(num3); // tells the compile to pass the value of num3 to the call the funtion WriteLine that belongs to console 

            string numToCauseException = "72f"; //tell the compiler to create a veriable of type string called numToCauseException and assign the value 72f

            //so here we need to do a bit of definive code

            //first define a veriable that has no value.
            int result;
            /* 
               * if (boolean) {
               *   do if true
               * }
               * or do if false       
            */

            //check first then deal with issue
            if (int.TryParse(numToCauseException, out result))
            {
                Console.WriteLine("the Number is " + result);
            }
            else
            {
                Console.WriteLine(numToCauseException + "its not a number dave !!!\n\n" + result);
            }


        }// end function
    }//end class
}//end namespace
