using System;
using System.Collections.Generic;
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

namespace NewGraficBoard001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Canvas MyCanvas = new Canvas();
            MyCanvas.Width = 640;
            MyCanvas.Height = 480;
            Viewbox viewbox = new Viewbox();
            viewbox.Child = MyCanvas;
            Content = viewbox;

            CGame game = new CGame(ref MyCanvas);
            game.Play();
            CMarker marker = new CMarker(ref MyCanvas,"0");
            marker.Draw();

        }
    }
}
