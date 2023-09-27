using desing_for_Konstantin.model;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace desing_for_Konstantin
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            table.Items.Add(new collections() { number = 7,date = new DateTime(2023, 7, 14), seconds = new TimeSpan(15,14,13), pr = 0, source = "brpspsp", events = "fdfdfdf", image="/asset/img/green_flag.png", info = " ", comm = " ", recept_name = "che", place = "block", loop_info = "X", type = "BAY", press = 0 });
            table.Items.Add(new collections() { number = 8,date = new DateTime(2023, 7, 14), seconds = new TimeSpan(15, 14, 13), pr = 0, source = "brpspsp", events = "fdfdfdf", image = "/asset/img/reg_flag.png",info = " ", comm = " ", recept_name = "che", place = "block", loop_info = "X", type = "BAY", press = 1 });
            table.Items.Add(new collections() { number = 9,date = new DateTime(2023, 7, 14), seconds = new TimeSpan(15, 14, 13), pr = 0, source = "brpspsp", events = "fdfdfdf", image = "/asset/img/reg_flag.png",info = " ", comm = " ", recept_name = "che", place = "block", loop_info = "X", type = "BAY", press = 2 });
            
        }
        void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()+1).ToString();
        }

    }
    



}
