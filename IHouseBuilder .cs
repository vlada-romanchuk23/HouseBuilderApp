using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilderApp
{
    internal interface IHouseBuilder
    {
        void SetWalls();   // Метод для встановлення стін
        void SetRoof();    // Метод для встановлення даху
        void SetGarage();  // Метод для встановлення гаража
        void SetPool();    // Метод для встановлення басейну
        House GetHouse();  // Метод для отримання готового будинку
    }
}
