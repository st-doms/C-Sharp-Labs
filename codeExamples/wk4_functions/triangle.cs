using System;  //tells compiler to use a liberty called system

namespace stem.stdoms.samples //puts the code into a bucket called exceptions this is so a platform can use files with the same name
{// start definistion of functions in the namespace
    class triangle // this means create me a template called program
    {//start of definistion of the Program object


        //define a function to do the work
        public static void printChar(int numLoops, char charToprint)
        {
            for (int spacesForRow = numLoops; spacesForRow > 0; spacesForRow--)
            {
                Console.Write(charToprint);
            }
        }


        public static void Main(string[] args) //this is a function it teslls the compler to run the following code 
            //fun fact main is the entry point into a thread that one has to use ergo you are using threads out of the gate
        {//start function definistion

            char astrix = '*';
            char space = ' ';

            int height = 5;
            int numSpaces = height - 1;
            int numOfAstrix = 1; 

            do
            {
                printChar(height, space);

                printChar(numOfAstrix + (numOfAstrix - 1), astrix);

                numOfAstrix++;
                numSpaces--;
                height--;
                Console.Write("\n");
            } while (height > 0 );


        }// end function
    }//end class
}//end namespace

