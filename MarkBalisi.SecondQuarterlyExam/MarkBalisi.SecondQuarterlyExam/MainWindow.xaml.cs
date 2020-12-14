using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Net;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RestSharp;
using Newtonsoft.Json;

namespace MarkBalisi.SecondQuarterlyExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string resultAsJson;

        public MainWindow()
        {
            var url = "http://newsapi.org/v2/top-headlines?country=ar&category=business&apiKey=21abf07344d6405e8b0c8a04d2de23b8" +
          "country=ar&" +
          "apiKey=21abf07344d6405e8b0c8a04d2de23b8";

            var json = new WebClient().DownloadString(url);

            Console.WriteLine(json);
        }
    }
}
