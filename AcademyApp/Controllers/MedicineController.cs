using System;
using Business.Servicess;
using Entities.Models;
using Utilies.Helpers;

namespace AcademyApp.Controllers
{
    public class MedicineController
    {
        public MedicineService medicineService { get; }

        public MedicineController()
        {
            medicineService = new MedicineService();
        }

        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Medicine name:");
            string name = Console.ReadLine();
        EnterName: Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Medicine Cost:");
            string minCost = Console.ReadLine();
            int Cost;
            bool isTrueminCost = int.TryParse(minCost, out Cost);
            if (isTrueminCost)
            {
                Medicinetype medicine = new() { name = name, Cost = Cost };
                if (medicineService.Create(medicine) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{medicine.name} created");
                    return;
                }
                else if (medicineService.Create(medicine) == null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{medicine.name} created");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"Something is wrong!!!");
                }
                return;
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Enter Correct Cost");
                goto EnterName;
            }

        }

        public void GetAll()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "All medicine:");
            foreach (Medicinetype medicine in medicineService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"{medicine.Id} - {medicine.name}");

            }
        }
        public void Delete()
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter medicine Id");
            string input = Console.ReadLine();
            int medicineId;
            bool isTrueCost = int.TryParse(input, out medicineId);
                if (isTrueCost)
            {
                if (medicineService.Delete(medicineId) != null) 
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "medicine is deleted");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{medicineId} is not find");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Please, select correct format");

            }

        }


        public void GetmedicineWithCost()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter medicine Cost");
            string input = Console.ReadLine();
            int minCost;
            bool isTrue = int.TryParse(input, out minCost);
            if (isTrue)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"medicines whith cost is {minCost}:");

                foreach (var item in medicineService.GetAll())
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, item.name);

                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Please, select correct format");

        }


    }
}
