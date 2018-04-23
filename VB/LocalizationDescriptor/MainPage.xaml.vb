Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace LocalizationDescriptor
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			view.RuntimeLocalizationStrings.Add(New RuntimeStringIdInfo(GridControlRuntimeStringId.GridGroupPanelText, "To group by a column, drag its header here"))
			Dim source As New List(Of String) (New String() {"test string"})
			grid.ItemsSource = New ProductList()
		End Sub

		Private Sub view_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			grid.View.ShowColumnChooser()
		End Sub
	End Class
End Namespace
