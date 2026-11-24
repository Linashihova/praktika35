using System.Collections.Generic;
using System.Windows;

namespace PermDynamics_Shihova
{
    public partial class MainWindow : Window
    {
        public List<Classes.PointInfo> pointsInfo = new List<Classes.PointInfo>();
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            OpenPages(pages.main);
        }
        public enum pages
        {
            main,
            chart
        }

        public void OpenPages(pages _pages)
        {
            if (_pages == pages.main)
                frame.Navigate(new Pages.Main());
            else if (_pages == pages.chart)
            {
                frame.Navigate(new Pages.Chart());
            }
        }
    }
}
