using System;  //tells compiler to use a liberty called system

namespace stem.stdoms.samples //puts the code into a bucket called exceptions this is so a platform can use files with the same name
{// start definistion of functions in the namespace


    public class Person { //define the template for te veriable 

        protected String firstName;
        //Auto Implementation Property, 
        public String lastName { get; set; }
        private DateTime DOB;


        public Person (String firstName, String lastName) //constructer
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Console.WriteLine("I am a Person object " + firstName + " " + lastName);
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
            Console.WriteLine("I am destorying a Person object " + firstName + " " + lastName);
        }
    }


    public class Teachair : Person //this means define a public template that has all the attr of a person and some more 
    { //define the template for te veriable

        String[] subjects = new String[10]; //create a veriable of type string array which can hould 10 items
        int numberOfSubjectsTought = 0; //ctrate a veriable of type int called numberOfSubjectsTought with the value od 0

        public Teachair(String firstName, String lastName): base(firstName, lastName) //constructer
        {
            Console.WriteLine("I am a Teachair object " + firstName + " " + lastName);
        }

        ~Teachair()
        {
            Console.WriteLine("I am destorying a Teachair object " + firstName + " " + lastName);
        }

        public void addSubject(String subject) 
        {
            bool isPresent = false;
            foreach (String currewntSubject in this.subjects) 
            {
                if (currewntSubject != null && currewntSubject.Contains(subject))
                {
                    isPresent = true;
                    break;
                }
            }
            if (!isPresent)
            { 
                subjects[numberOfSubjectsTought] = subject;
                numberOfSubjectsTought++;
            }
        }

        public void printSubjects()
        {
            int size = this.subjects.Length;
            for (int index = 0; size > index; index++ )
            {
                Console.WriteLine(subjects[index]);
            }
        }

        //challange create a to string functions that says
        // teatcher { "name":<nameOfTeach> <lastName> "subjects": [subject 1 , subject2 .....] }

    }

    //challage create a student class and a string Array veriable of what subject they take 




    class triangle // this means create me a template called program
    {//start of definistion of the Program object


        public static void Main(string[] args) //this is a function it teslls the compler to run the following code 
            //fun fact main is the entry point into a thread that one has to use ergo you are using threads out of the gate
        {//start function definistion

            Person person = new Person("joe", "blogs"); // create a veriable of of type persion
            Teachair teach = new Teachair("Mr", "Parker");

            teach.addSubject("IT");
            teach.addSubject("ICT");
            teach.printSubjects();

            Console.WriteLine(person);
            Console.ReadLine();

        }// end function
    }//end class
}//end namespace

