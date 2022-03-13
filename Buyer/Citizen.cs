using System;
namespace FoodShortage
{
    public class Citizen : IBuyer
    {
       private string name;

        public Citizen(string name, int age, string id, string birthDay)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDay = birthDay;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
             private set
            {
                if (value.Length <= 1 )
                {
                    throw new ArgumentException("Invalid Name!");
                }
                this.name = value;
            }
        }


        public int Age { get;}

        public string Id { get; }

        public string BirthDay { get; }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
