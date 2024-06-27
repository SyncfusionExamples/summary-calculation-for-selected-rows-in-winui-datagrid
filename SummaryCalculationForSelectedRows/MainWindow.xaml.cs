using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.Storage;
using Windows.UI.Popups;
using Syncfusion.UI.Xaml.DataGrid.Export;
using Syncfusion.XlsIO;
using Syncfusion.UI.Xaml.DataGrid;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SummaryCalculation
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnComboBoSexlectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (summaryUnitComboBox.SelectedIndex == 0)
                sfDataGrid.SummaryCalculationUnit = Syncfusion.UI.Xaml.Data.SummaryCalculationUnit.AllRows;
            else if (summaryUnitComboBox.SelectedIndex == 1)
                sfDataGrid.SummaryCalculationUnit = Syncfusion.UI.Xaml.Data.SummaryCalculationUnit.SelectedRows;
            else
                sfDataGrid.SummaryCalculationUnit = Syncfusion.UI.Xaml.Data.SummaryCalculationUnit.Mixed;

        }
    }
}