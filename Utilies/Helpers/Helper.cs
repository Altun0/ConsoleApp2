using System;
namespace Utilies.Helpers
{
    public static class Helper
    {
        public static void ChangeTextColor(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        public enum Menu
        {
            Exit,
            CreateMedicine,
            UpdateMedicine,
            DeleteMedicine,
            GetMedicineWithId,
            GetMedicineWithName,
            GetAllMedicine,
            GetMedicineWithCost,

        }
    }
}
