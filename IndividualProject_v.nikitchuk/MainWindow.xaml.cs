using ClassLibrary;
using Microsoft.Win32;
using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IndividualProject_v.nikitchuk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Список заказов
        public List<Order> OrderList = new List<Order>();
        public string DefaulthPath = System.IO.Directory.GetCurrentDirectory() + @"\data\OrderList.txt";
        public MainWindow()
        {
            InitializeComponent();
            LoadOrderList(DefaulthPath);

            DataGrid.IsReadOnly = true;
            DataGrid.CanUserResizeColumns = false;
            DataGrid.CanUserResizeRows = false;
            List<string> ColumnsName = new List<string>()
            {
                "№;35", "Дата заказа;115", "Состав заказа;438", "Покупатель;120", "Стоимость;70",
            };
            for (int i = 0; i < ColumnsName.Count; i++)
            {
                var column = new DataGridTextColumn();
                column.Header = ColumnsName[i].Split(';')[0];
                column.Binding = new Binding("Column" + i);
                column.Width = int.Parse(ColumnsName[i].Split(';')[1]);
                column.CanUserSort = false;
                DataGrid.Columns.Add(column);
            }
        }

        //Загрузка списка заказов из файла
        public void LoadOrderList(string from)
        {
            DataGrid.Items.Clear();
            OrderList.Clear();
            FileStream fs = new FileStream(from, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string rawData = sr.ReadLine();
                while (rawData != "" && rawData != null)
                {
                    OrderList.Add(new Order(int.Parse(rawData.Split(';')[0]), DateTime.Parse(rawData.Split(';')[1]), rawData.Split(';')[2], new NewCustomer(rawData.Split(';')[3].Split(' ')[0], rawData.Split(';')[3].Split(' ')[1], rawData.Split(';')[3].Split(' ')[2].Substring(0, rawData.Split(';')[3].Split(' ')[2].Length - 1), rawData.Split(';')[3].Split(' ')[3]), int.Parse(rawData.Split(';')[4]), bool.Parse(rawData.Split(';')[5])));
                    rawData = sr.ReadLine();
                }
            }
            for (int i = 0; i < OrderList.Count; i++)
            {
                DataGrid.Items.Add(new DataGrid { Column0 = OrderList[i].Number.ToString(), Column1 = OrderList[i].Date.ToString(), Column2 = OrderList[i].Structure, Column3 = OrderList[i].Person.ToDataGrid(), Column4 = OrderList[i].Cost.ToString() });
            }
        }

        //Добавление нового заказа
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var addForm = new AddWindow(this);
            addForm.ShowDialog();
        }
        //Удаление заказа
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataGrid.SelectedIndex != -1)
            {
                if (MessageBox.Show("Вы действительно хотите удалить заказ " + OrderList[DataGrid.SelectedIndex].Number + "?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    OrderList.RemoveAt(DataGrid.SelectedIndex);
                    SaveMenuButton_Click(this, null);
                    LoadOrderList(DefaulthPath);
                }
            }
        }


        //Загрузить список заказов из другой директории
        private void LoadOrderListMenuButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //Открытие файла
            openFileDialog.Filter = "Текстовый документ (*.txt)|*.txt"; //Фильтр текстовых файлов

            if (openFileDialog.ShowDialog() == true)
            {
                LoadOrderList(openFileDialog.FileName);
            }
        }
        //Кнопка сохранения любых изменений
        private void SaveMenuButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //Открытие файла
            openFileDialog.Filter = "Текстовый документ (*.txt)|*.txt"; //Фильтр текстовых файлов
            if (openFileDialog.ShowDialog() == true)
            {
                System.IO.File.WriteAllText(openFileDialog.FileName, string.Empty);
                using (StreamWriter writer = new StreamWriter(openFileDialog.FileName, true, Encoding.Unicode))
                {
                    for (int i = 0; i < OrderList.Count; i++)
                    {
                        writer.Write(OrderList[i].Number + ";");
                        writer.Write(OrderList[i].Date + ";");
                        writer.Write(OrderList[i].Structure + ";");
                        writer.Write(OrderList[i].Person + ";");
                        writer.Write(OrderList[i].Cost + ";");
                        writer.Write(OrderList[i].Status + "\n");
                    }
                }
            }
        }

        //Подробный просмотр заказа
        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DataGrid.SelectedItem == null) return;
            var selectedOrder = OrderList[DataGrid.SelectedIndex];
            MessageBox.Show(string.Format("Дата создания: {1}\nСостав:\n{2}.\nПокупатель: {3}\nЦена: {4} рублей", selectedOrder.Number, selectedOrder.Date, selectedOrder.Structure, selectedOrder.Person.ToString(), selectedOrder.Cost), "Подробное описание заказа № " + selectedOrder.Number);
        }
    }
}
