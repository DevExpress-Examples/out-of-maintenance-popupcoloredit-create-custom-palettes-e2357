Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Editors

Namespace DXEditors_PopupColorEdit
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			' Removes the 'Standard Colors' palette.
			popupColorEdit1.Palettes.Remove(popupColorEdit1.Palettes("Standard Colors"))
			' Adds a custom gradient palette.
			popupColorEdit1.Palettes.Add(CustomPalette.CreateGradientPalette("Apex Colors", PredefinedColorCollections.Apex))
			' Adds a new palette with three custom RGB colors.
            Dim customColors As List(Of Color) = New List(Of Color)
            customColors.Add(Color.FromRgb(150, 18, 30))
            customColors.Add(Color.FromRgb(20, 40, 20))
            customColors.Add(Color.FromRgb(88, 73, 29))
			Dim palette As CustomPalette = New CustomPalette("Custom RGB Colors", customColors)
            popupColorEdit1.Palettes.Add(palette)
		End Sub
	End Class
End Namespace
