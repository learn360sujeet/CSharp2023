namespace One_property_simple
{
    public class PropertyClass
    {
        // variable // private - only accessed inside class 
        private string name;
        private int age;

        // Variable is good to be used withing the same class 
        // Variable normaly should not be used outside of class 

        // If somehow or some reason if we need value for variable from outside of class then we should use property 

        // property - wrapper of variable
        // Property help you to not let variable be accessed directly outside of class
        // rather use and call property from outside of class and property will assign value to variabe internally

        // Proerty help us to assign variable value conditionally in setter 
        public int Age
        {
            // getter to get value 
            get
            {
                return age;
            }

            // settter to set value
            set
            {
                if (value >= 18)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be greate or equal than 18");
                }
            }
        }

        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }


    }
}
