using System;
using AcademyApp.Controllers;
using Business.Servicess;
using Entities.Models;
using Utilies.Helpers;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MedicineController medicineController = new MedicineController();


            Helper.ChangeTextColor(ConsoleColor.Blue, "Welcome");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu>=1 && menu>=7)
                {
                    switch (menu)
                    {
                        case (int)Helper.Menu.CreateMedicine:
                            medicineController.Create();
                            break;

                        case (int)Helper.Menu.UpdateMedicine:
                            break;
                        case (int)Helper.Menu.DeleteMedicine:
                            medicineController.Delete();
                            break;
                        case (int)Helper.Menu.GetMedicineWithId:
                            break;
                        case (int)Helper.Menu.GetMedicineWithName:
                            break;
                        case (int)Helper.Menu.GetAllMedicine:
                            medicineController.GetAll();

                            
                            break;
                        case (int)Helper.Menu.GetMedicineWithCost:
                            medicineController.GetmedicineWithCost();
                            break;
  
                    };
                 }
                else if (menu == 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, "Bye-Bye");
                    break;

                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please,select correct option");
                }
            }
        }

        static void ShowMenu()
        {
            Helper.ChangeTextColor(ConsoleColor.Green, "1-Create Medicine,2-Update Medicine,3-Delete Medicine," +
                    "4-Get Medicine with Id,5-Get Medicine with Name,6-All Medicine ,7-Get Medicines with Cost,0-Exit ");
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Select option Number:");
        }
    }
}
