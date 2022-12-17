Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports DevExpress.Xpf.Editors

Namespace DXEditors_PopupColorEdit

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            ' Removes the 'Standard Colors' palette.
            Me.popupColorEdit1.Palettes.Remove(Me.popupColorEdit1.Palettes("Standard Colors"))
            ' Adds a custom gradient palette.
            Me.popupColorEdit1.Palettes.Add(ColorPalette.CreateGradientPalette("Apex Colors", PredefinedColorCollections.Apex))
            ' Adds a new palette with three custom RGB colors.
            Me.popupColorEdit1.Palettes.Add(New CustomPalette("Custom RGB Colors", New List(Of Color)() From {Color.FromRgb(150, 18, 30), Color.FromRgb(20, 40, 20), Color.FromRgb(88, 73, 29)}))
        End Sub
    End Class
End Namespace
