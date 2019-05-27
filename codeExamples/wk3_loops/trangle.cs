using System;  //tells compiler to use a liberty called system

namespace stem.stdoms.samples //puts the code into a bucket called exceptions this is so a platform can use files with the same name
{// start definistion of functions in the namespace
    class triangle // this means create me a template called program
    {//start of definistion of the Program object
        public static void Main(string[] args) //this is a function it teslls the compler to run the following code 
            //fun fact main is the entry point into a thread that one has to use ergo you are using threads out of the gate
        {//start function definistion

            char astrix = '*'; //create a veriable of type char called astrix with the value of * note the ' ' are not " "  
            char space = ' ';

            int height = 5; // crete a veriable of type int name height with the value of 5 this is the height of the triangle
            int numSpaces = height - 1;
            int numOfAstrix = 1; 

/*
   how a do while works
   do { 
      stuff to do 
   } while ( what ever condistion is true) when the condistion is false the loop ends
*/
            do
            {
       // for (loopcount; condistions or condistions ; decrament loop)
                for (int spacesForRow = height; spacesForRow > 0; spacesForRow--)
                {
                    Console.Write(space);
                }

                for (int astrixForRow = numOfAstrix + (numOfAstrix -1); astrixForRow > 0; astrixForRow--)
                {
                    Console.Write(astrix);
                }

                numOfAstrix++;
                numSpaces--;
                height--;
                Console.Write("\n");
            } while (height > 0 );


        }// end function
    }//end class
}//end namespace

