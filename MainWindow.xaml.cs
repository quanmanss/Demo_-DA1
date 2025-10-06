using System.Windows;

namespace SmartHomeApp
{
    public partial class MainWindow : Window
    {
        private int devicesOn = 0;

        public MainWindow()
        {
            InitializeComponent();
            UpdateDevicesOnDisplay();
        }

        private void DeviceToggle_Checked(object sender, RoutedEventArgs e)
        {
            devicesOn++;
            UpdateDevicesOnDisplay();
        }

        private void DeviceToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            if (devicesOn > 0)
                devicesOn--;
            UpdateDevicesOnDisplay();
        }

        private void UpdateDevicesOnDisplay()
        {
            TextBlockDevicesOn.Text = devicesOn.ToString();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}


