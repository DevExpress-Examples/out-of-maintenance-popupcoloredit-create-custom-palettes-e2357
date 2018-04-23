using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Editors;

namespace DXEditors_PopupColorEdit {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            // Removes the 'Standard Colors' palette.
            popupColorEdit1.Palettes.Remove(popupColorEdit1.Palettes["Standard Colors"]);
            // Adds a custom gradient palette.
            popupColorEdit1.Palettes.Add(CustomPalette.CreateGradientPalette("Apex Colors", PredefinedColorCollections.Apex));
            // Adds a new palette with three custom RGB colors.
            popupColorEdit1.Palettes.Add(
                new CustomPalette("Custom RGB Colors",
                new List<Color>() {
                    Color.FromRgb(150, 18, 30),
                    Color.FromRgb(20, 40, 20),
                    Color.FromRgb(88, 73, 29) }));
        }
    }
}
