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

namespace BigRobot
{
    /// <summary>
    /// Interação lógica para ToggleButton.xam
    /// </summary>
    public partial class ToggleButton : UserControl
    {
        Thickness LeftSide = new Thickness(-39, 0, 0, 0);
        Thickness RightSide = new Thickness(0, 0, -39, 0);
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(130, 190, 125));
        private bool Toogled = false;

        public ToggleButton()
        {
            InitializeComponent();
            Back.Fill = Off;
            Toogled = false;
            Dot.Margin = LeftSide;
        }

        public bool Toggled1 { get => Toggled1; set => Toogled = value; }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toogled){
                Back.Fill = On;
                Toogled = true;
                Dot.Margin = RightSide;
                
            }
            else
            {

                Back.Fill = Off;
                Toogled = false;
                Dot.Margin = LeftSide;

            }
        }

        private void Dot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toogled) {
                Back.Fill = On;
                Toogled = true;
                Dot.Margin = RightSide;
            }else {
                Back.Fill = Off;
                Toogled = false;
                Dot.Margin = LeftSide;
            }
        }
    }
}
