using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilderApp
{
    internal class LuxuryHouseBuilder : IHouseBuilder
    {
        private House house = new House(); // Об'єкт будинку

        public void SetWalls() => house.Walls = "Brick walls"; // Встановлення стін
        public void SetRoof() => house.Roof = "Tile roof";     // Встановлення даху
        public void SetGarage() => house.HasGarage = true;     // Додавання гаража
        public void SetPool() => house.HasPool = true;         // Додавання басейну

        public House GetHouse() => house; // Повертає готовий будинок
    }
}

