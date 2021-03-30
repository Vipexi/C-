namespace PersonExample
{
    /* 
        -first name
        - last name
        - is the person studying
        - full name (first name + last name)
        (-address)
        - public or private

    */
    class Person
    {
        public string lastName = "UnknownLastName";
        private string firstName ="UnknownFirstName";

        public string FirstName {
            get {
                return firstName;
            }
            set {
                firstName = value;
            }
        }

        public bool IsStudying { set; get;}

        public string FullName => FirstName + " " + lastName;

       

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public Person() 
        {

        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstName) 
        {
            this.firstName = firstName;
        }

        /*~Person()
        {
            System.Console.WriteLine("Person destructor");
        }*/
    }
}