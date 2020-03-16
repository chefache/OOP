namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Models.Animals;
    using WildFarm.Models.Foods;
    using WildFarm.Obj_generator;
    public class Engine
    {
        public void Run()
        {
            var animals = new List<Animal>();
            var generatorOfAnimal = new AnimalGenerator();
            var generatorOfFood = new FoodGenerator();


            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                Animal currentAnimal = generatorOfAnimal.Create
                    (command.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                animals.Add(currentAnimal);
                Console.WriteLine(currentAnimal.ProduceSound());

                Food currentFood = generatorOfFood.Create
                    (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

                try
                {
                    currentAnimal.EatFood(currentFood);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
