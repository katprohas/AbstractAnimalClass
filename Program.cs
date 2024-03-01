using System;
namespace AbstractAnimalClass
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    } //end abstract animal

    class Program
    {
        class Cat : Animal
        {
            public override string Name { get; set; }
            public string Breed { get; set; }
            public int Age { get; set; }
            public string EyeColor { get; set; }

            public Cat()
            {
                Name = string.Empty;
                Breed = string.Empty;
                Age = 0;
                EyeColor = string.Empty;
            }
            public Cat(string name, string breed, int age, string eyecolor)
            {
                Name = name;
                Breed = breed;
                Age = age;
                EyeColor = eyecolor;
            }
            public override string Describe()
            {
                return "My name is " + Name + " and I am a " + EyeColor + "-eyed, "
                + Age + "-year old " + Breed + " cat.";
            }
        } //end cat

        static void Main(string[] args)
        {
            Cat siamese = new Cat();
            siamese.Name = "Lulu";
            siamese.Breed = "Siamese";
            siamese.Age = 8;
            siamese.EyeColor = "blue";
            Console.WriteLine(siamese.Describe());
            Console.WriteLine();
            Cat mainecoon = new Cat("Mikey", "Maine Coon", 3, "yellow");
            Console.WriteLine(mainecoon.Describe());
        }
    }//end program
} //end namespace