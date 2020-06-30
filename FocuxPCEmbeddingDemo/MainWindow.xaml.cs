using AxFocusPCActiveXLib;
using System.Windows;
using System.Windows.Forms.Integration;

namespace FocuxPCEmbeddingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AxFocusPCActiveX fpc { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            WindowsFormsHost host = new WindowsFormsHost();
            fpc = new AxFocusPCActiveX();
            host.Child = fpc;
            grid1.Children.Add(host);
        }

        private void Hook_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
                fpc.HookFocusPC(FocusPCActiveXLib.EFocusPCVersion.FocusPC10);
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show(ex.Message + " (Error code: 0x" + ex.ErrorCode.ToString("X") + ")");
            }
        }

        private void Unhook_Click(object sender, RoutedEventArgs e)
        {
            fpc.UnhookFocusPC();
        }
    }
}
