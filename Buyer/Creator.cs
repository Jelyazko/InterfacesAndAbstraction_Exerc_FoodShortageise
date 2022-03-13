using System;
namespace FoodShortage.Buyer
{
    public class Creator
    {
        public static IBuyer CreateBuyer(string[] inputInfo)
        {
            IBuyer buyer;
            string name = inputInfo[0];
            int age = int.Parse(inputInfo[1]);
            if (inputInfo.Length == 3)
            {
                string group = inputInfo[2];
                buyer = new Rebel(name, age, group);
            }
            else
            {
                string id = inputInfo[2];
                string bDay = inputInfo[3];
                buyer = new Citizen(name, age, id, bDay);
            }

            return buyer;
        }
    }
}
