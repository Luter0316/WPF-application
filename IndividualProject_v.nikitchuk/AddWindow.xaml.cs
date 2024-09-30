using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace IndividualProject_v.nikitchuk
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public List<ProductList> MenuList = new List<ProductList>(); //Список всей продукции
        public static MainWindow mainWindow; //Ссылка на основное окно
        public string OrderToSave = ""; //Заказ который будет сохранен
        public int TotalCost; //Общая стоимость заказа

        public AddWindow(MainWindow main)
        {
            mainWindow = main;
            InitializeComponent();
            LoadMenuList();
            for (int i = 0; i < MenuList.Count; i++)
            {
                ProductComboBox.Items.Add(MenuList[i].Name);
            }
            ProductComboBox.SelectedIndex = 0;
        }

        //Загрузка списка продукции
        private void LoadMenuList()
        {
            FileStream fs = new FileStream(System.IO.Directory.GetCurrentDirectory() + @"\data\MenuList.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string rawData = sr.ReadLine();
                while (rawData != null)
                {
                    MenuList.Add(new ProductList(rawData.Split(';')[0], int.Parse(rawData.Split(';')[1])));
                    rawData = sr.ReadLine();
                }
            }
        }

        //Добавление продукци в заказ
        private void AddToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (CountProductTextBox.Text == "" || int.Parse(CountProductTextBox.Text) <= 0)
            {
                MessageBox.Show("Некорректно указано колчичество продукции");
                CountProductTextBox.Focus();
            }
            else
            {
                OrderTextBox.Text += CountProductTextBox.Text + "x " + ProductComboBox.SelectedItem.ToString() + " - " + (int.Parse(CountProductTextBox.Text) * int.Parse(OneCostTextBox.Text)) + " рублей\n";
                OrderToSave += CountProductTextBox.Text + "x " + ProductComboBox.SelectedItem.ToString() + ", ";
                TotalCost += int.Parse(CountProductTextBox.Text) * int.Parse(OneCostTextBox.Text);
                ProductComboBox.SelectedIndex = 0;
                CountProductTextBox.Text = "1";
            }
        }
        //Очистить заказ
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            OrderTextBox.Text = "";
            ProductComboBox.SelectedIndex = 0;
            CountProductTextBox.Text = "1";
            OrderToSave = "";
            TotalCost = 0;
        }
        //Добавить новый заказ в общий список
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (OrderToSave == "")
            {
                MessageBox.Show("Заказ пуст!", "Ошибка ввода данных");
            }else if (NameClientTextBox.Text == "")
            {
                MessageBox.Show("Поле ФИО должно быть заполнено", "Ошибка ввода данных");
                NameClientTextBox.Focus();
            }
            else if (PhoneNumberTextBox.Text == "")
            {
                MessageBox.Show("Отсутствует контактный номер телефона", "Ошибка ввода данных");
                PhoneNumberTextBox.Focus();
            }
            else
            {
                OrderToSave = OrderToSave.Substring(0, OrderToSave.Length - 2);
                mainWindow.OrderList.Add(new Order(OrderToSave, new NewCustomer(NameClientTextBox.Text.Split(' ')[0], NameClientTextBox.Text.Split(' ')[1], NameClientTextBox.Text.Split(' ')[2], PhoneNumberTextBox.Text), TotalCost, false));
                using (StreamWriter writer = new StreamWriter(mainWindow.DefaulthPath, true, Encoding.Unicode))
                {
                    writer.Write(mainWindow.OrderList[mainWindow.OrderList.Count - 1].Number + ";");
                    writer.Write(mainWindow.OrderList[mainWindow.OrderList.Count - 1].Date + ";");
                    writer.Write(mainWindow.OrderList[mainWindow.OrderList.Count - 1].Structure + ";");
                    writer.Write(mainWindow.OrderList[mainWindow.OrderList.Count - 1].Person + ";");
                    writer.Write(mainWindow.OrderList[mainWindow.OrderList.Count - 1].Cost + ";");
                    writer.Write(mainWindow.OrderList[mainWindow.OrderList.Count - 1].Status + "\n");
                }
                mainWindow.LoadOrderList(mainWindow.DefaulthPath);
            }
        }

        //Вывод цены за 1 единицу продукции
        private void ProductComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OneCostTextBox.Text = MenuList[ProductComboBox.SelectedIndex].Price.ToString();
        }

        //Проверка на ввод чисел в поле "количество"
        private void CountProductTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        //Проверка на ввод только букв в поле "ФИО"
        private void NameClientTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]");
            e.Handled = regex.IsMatch(e.Text);
        }
        //Проверка на ввод чисел в поле "номер телефона"
        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
