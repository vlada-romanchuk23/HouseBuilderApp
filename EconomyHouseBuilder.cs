using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilderApp
{
    internal class EconomyHouseBuilder : IHouseBuilder
    {
        private House house = new House(); // Об'єкт будинку

        public void SetWalls() => house.Walls = "Wooden walls"; // Встановлення стін
        public void SetRoof() => house.Roof = "Metal roof";     // Встановлення даху
        public void SetGarage() => house.HasGarage = false;     // Без гаража
        public void SetPool() => house.HasPool = false;         // Без басейну

        public House GetHouse() => house; // Повертає готовий будинок
    }
}
