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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OpacityBack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DoubleAnimation opacityAnimation;

        public MainWindow()
        {
            InitializeComponent();
             opacityAnimation = new DoubleAnimation
            {
                From = 0.1,
                To = 1,
                Duration = TimeSpan.FromSeconds(0.3),
                AutoReverse = true
            };
        }

        private void b1_MouseEnter(object sender, MouseEventArgs e)
        {
            b1.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b2_MouseEnter(object sender, MouseEventArgs e)
        {
            b2.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b3_MouseEnter(object sender, MouseEventArgs e)
        {
            b3.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b4_MouseEnter(object sender, MouseEventArgs e)
        {
            b4.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b5_MouseEnter(object sender, MouseEventArgs e)
        {
            b5.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b6_MouseEnter(object sender, MouseEventArgs e)
        {
            b6.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b7_MouseEnter(object sender, MouseEventArgs e)
        {
            b7.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b8_MouseEnter(object sender, MouseEventArgs e)
        {
            b8.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b9_MouseEnter(object sender, MouseEventArgs e)
        {
            b9.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b10_MouseEnter(object sender, MouseEventArgs e)
        {
            b10.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b11_MouseEnter(object sender, MouseEventArgs e)
        {
            b11.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b12_MouseEnter(object sender, MouseEventArgs e)
        {
            b12.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b13_MouseEnter(object sender, MouseEventArgs e)
        {
            b13.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b14_MouseEnter(object sender, MouseEventArgs e)
        {
            b14.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b15_MouseEnter(object sender, MouseEventArgs e)
        {
            b15.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b16_MouseEnter(object sender, MouseEventArgs e)
        {
            b16.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b17_MouseEnter(object sender, MouseEventArgs e)
        {
            b17.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b18_MouseEnter(object sender, MouseEventArgs e)
        {
            b18.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b19_MouseEnter(object sender, MouseEventArgs e)
        {
            b19.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b20_MouseEnter(object sender, MouseEventArgs e)
        {
            b20.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b21_MouseEnter(object sender, MouseEventArgs e)
        {
            b21.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b22_MouseEnter(object sender, MouseEventArgs e)
        {
            b22.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b23_MouseEnter(object sender, MouseEventArgs e)
        {
            b23.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b24_MouseEnter(object sender, MouseEventArgs e)
        {
            b24.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b25_MouseEnter(object sender, MouseEventArgs e)
        {
            b25.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b26_MouseEnter(object sender, MouseEventArgs e)
        {
            b26.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b27_MouseEnter(object sender, MouseEventArgs e)
        {
            b27.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b28_MouseEnter(object sender, MouseEventArgs e)
        {
            b28.BeginAnimation(Border.OpacityProperty, opacityAnimation);

        }

        private void b29_MouseEnter(object sender, MouseEventArgs e)
        {
            b29.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b30_MouseEnter(object sender, MouseEventArgs e)
        {
            b30.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b31_MouseEnter(object sender, MouseEventArgs e)
        {
            b31.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b32_MouseEnter(object sender, MouseEventArgs e)
        {
            b32.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b33_MouseEnter(object sender, MouseEventArgs e)
        {
            b33.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b34_MouseEnter(object sender, MouseEventArgs e)
        {
            b34.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b35_MouseEnter(object sender, MouseEventArgs e)
        {
            b35.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b36_MouseEnter(object sender, MouseEventArgs e)
        {
            b36.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b37_MouseEnter(object sender, MouseEventArgs e)
        {
            b37.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b38_MouseEnter(object sender, MouseEventArgs e)
        {
            b38.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b39_MouseEnter(object sender, MouseEventArgs e)
        {
            b39.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b40_MouseEnter(object sender, MouseEventArgs e)
        {
            b40.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b41_MouseEnter(object sender, MouseEventArgs e)
        {
            b41.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b42_MouseEnter(object sender, MouseEventArgs e)
        {
            b42.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b43_MouseEnter(object sender, MouseEventArgs e)
        {
            b43.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b44_MouseEnter(object sender, MouseEventArgs e)
        {
            b44.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b45_MouseEnter(object sender, MouseEventArgs e)
        {
            b45.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b46_MouseEnter(object sender, MouseEventArgs e)
        {
            b46.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b47_MouseEnter(object sender, MouseEventArgs e)
        {
            b47.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b48_MouseEnter(object sender, MouseEventArgs e)
        {
            b48.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b49_MouseEnter(object sender, MouseEventArgs e)
        {
            b49.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b50_MouseEnter(object sender, MouseEventArgs e)
        {
            b50.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b51_MouseEnter(object sender, MouseEventArgs e)
        {
            b51.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b52_MouseEnter(object sender, MouseEventArgs e)
        {
            b52.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b53_MouseEnter(object sender, MouseEventArgs e)
        {
            b53.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b54_MouseEnter(object sender, MouseEventArgs e)
        {
            b54.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b55_MouseEnter(object sender, MouseEventArgs e)
        {
            b55.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b56_MouseEnter(object sender, MouseEventArgs e)
        {
            b56.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b57_MouseEnter(object sender, MouseEventArgs e)
        {
            b57.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b58_MouseEnter(object sender, MouseEventArgs e)
        {
            b58.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b59_MouseEnter(object sender, MouseEventArgs e)
        {
            b59.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b60_MouseEnter(object sender, MouseEventArgs e)
        {
            b60.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b61_MouseEnter(object sender, MouseEventArgs e)
        {
            b61.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b62_MouseEnter(object sender, MouseEventArgs e)
        {
            b62.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b63_MouseEnter(object sender, MouseEventArgs e)
        {
            b63.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b64_MouseEnter(object sender, MouseEventArgs e)
        {
            b64.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b65_MouseEnter(object sender, MouseEventArgs e)
        {
            b65.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b66_MouseEnter(object sender, MouseEventArgs e)
        {
            b66.BeginAnimation(Border.OpacityProperty, opacityAnimation);

        }

        private void b67_MouseEnter(object sender, MouseEventArgs e)
        {
            b67.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b68_MouseEnter(object sender, MouseEventArgs e)
        {
            b68.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b70_MouseEnter(object sender, MouseEventArgs e)
        {
            b70.BeginAnimation(Border.OpacityProperty, opacityAnimation);

        }

        private void b71_MouseEnter(object sender, MouseEventArgs e)
        {
            b71.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b72_MouseEnter(object sender, MouseEventArgs e)
        {
            b72.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b73_MouseEnter(object sender, MouseEventArgs e)
        {
            b73.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b74_MouseEnter(object sender, MouseEventArgs e)
        {
            b74.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b75_MouseEnter(object sender, MouseEventArgs e)
        {
            b75.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b76_MouseEnter(object sender, MouseEventArgs e)
        {
            b76.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b77_MouseEnter(object sender, MouseEventArgs e)
        {
            b77.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b78_MouseEnter(object sender, MouseEventArgs e)
        {
            b78.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b79_MouseEnter(object sender, MouseEventArgs e)
        {
            b79.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b80_MouseEnter(object sender, MouseEventArgs e)
        {
            b80.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }

        private void b81_MouseEnter(object sender, MouseEventArgs e)
        {
            b81.BeginAnimation(Border.OpacityProperty, opacityAnimation);
        }
    }
}
