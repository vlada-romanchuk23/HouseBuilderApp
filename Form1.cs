using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HouseBuilderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавляем элементы в ComboBox при загрузке формы
            comboBoxHouseType.Items.Add("Роскошный");
            comboBoxHouseType.Items.Add("Экономный");
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            IHouseBuilder builder;

            // Выбор строителя в зависимости от выбора в ComboBox
            if (comboBoxHouseType.SelectedItem.ToString() == "Роскошный")
                builder = new LuxuryHouseBuilder();
            else
                builder = new EconomyHouseBuilder();

            // Создание объекта Director и постройка дома
            HouseDirector director = new HouseDirector(builder);

            // Очищение предыдущих шагов в ListBox
            listBoxSteps.Items.Clear();

            // Пошаговое строительство
            listBoxSteps.Items.Add("Строим стены...");
            builder.SetWalls();

            listBoxSteps.Items.Add("Добавляем крышу...");
            builder.SetRoof();

            listBoxSteps.Items.Add("Добавляем гараж...");
            builder.SetGarage();

            listBoxSteps.Items.Add("Добавляем бассейн...");
            builder.SetPool();

            // Получение построенного дома
            House house = builder.GetHouse();

            // Отображение результата в TextBox
            txtResult.Text = house.ToString();
        }

        private void comboBoxHouseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Можно добавить любую логику, если потребуется
        }
    }
}
