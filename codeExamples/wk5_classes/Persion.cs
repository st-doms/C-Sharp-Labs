using System;  //tells compiler to use a liberty called system

namespace stem.stdoms.samples //puts the code into a bucket called exceptions this is so a platform can use files with the same name
{// start definistion of functions in the namespace


    public class Person { //define the template for te veriable 

        private String firstName;
        //Auto Implementation Property, 
        public String lastName { get; set; }
        private DateTime DOB;


        public Person () //constructer
        {

        }

        public void setFirstName(String firstName) // defined setter for attrabute
        {
            this.firstName = firstName;
        }

        public String  getFirstName()
        {
            return this.firstName;
        }

        //override string function
        public override string ToString()
        {
            return "Person: " + firstName + " " + lastName;
        }

        //challage 
        //create a function to gert and set the date of birth attrr
        //create a function to determin the age of the person
        ~Person()
        {

        }
    }




    class triangle // this means create me a template called program
    {//start of definistion of the Program object


        public static void Main(string[] args) //this is a function it teslls the compler to run the following code 
            //fun fact main is the entry point into a thread that one has to use ergo you are using threads out of the gate
        {//start function definistion

            Person person = new Person(); // create a veriable of of type persion

            person.setFirstName("Joe");
            person.lastName = "blogs";

            Console.WriteLine(person);
            Console.ReadLine();

        }// end function
    }//end class
}//end namespace

