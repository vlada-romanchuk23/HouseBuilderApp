using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HouseBuilderApp
{
    internal class House
    {
        public string Walls { get; set; }   // Стіни
        public string Roof { get; set; }     // Дах
        public bool HasGarage { get; set; }  // Наявність гаража
        public bool HasPool { get; set; }    // Наявність басейну

        // Метод для відображення інформації про будинок
        public override string ToString()
        {
            return $"Walls: {Walls}, Roof: {Roof}, Garage: {(HasGarage ? "Yes" : "No")}, Pool: {(HasPool ? "Yes" : "No")}";
        }
    }
}
