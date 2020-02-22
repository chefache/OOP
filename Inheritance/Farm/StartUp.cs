using System;

namespace Farm
{
    public class StartUp
    {
        public static void Main()
        {
            var dog = new Dog();
            dog.Bark();
            dog.Eat();

            var puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            var cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
