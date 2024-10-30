using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilderApp
{
    internal class HouseDirector
    {
        private IHouseBuilder builder; // Об'єкт будівника

        public HouseDirector(IHouseBuilder builder)
        {
            this.builder = builder; // Ініціалізація будівника
        }

        public void BuildHouse() // Метод для побудови будинку
        {
            builder.SetWalls();
            builder.SetRoof();
            builder.SetGarage();
            builder.SetPool();
        }
    }
}
