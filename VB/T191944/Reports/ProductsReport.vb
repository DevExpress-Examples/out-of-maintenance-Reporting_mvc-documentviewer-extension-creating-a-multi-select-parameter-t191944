Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Imports System.Linq
Imports T191944.Models

Namespace T191944.Reports
	Partial Public Class ProductsReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ProductsReport_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
'INSTANT VB NOTE: The variable categories was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim categories_Renamed() As String = Convert.ToString(Me.Parameters("Categories").Value).Split("|"c)
			Dim selectedCategories As New List(Of Integer)()
'INSTANT VB NOTE: The variable category was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			For Each category_Renamed As String In categories_Renamed
				Dim categoryID As Integer
				If Int32.TryParse(category_Renamed, categoryID) Then
					selectedCategories.Add(categoryID)
				End If
			Next category_Renamed

			Dim db As New NorthwindEntities()
			Me.DataSource = From product In db.Products
			                Where product.CategoryID.HasValue AndAlso selectedCategories.Contains(product.CategoryID.Value)
			                Select product
		End Sub

	End Class
End Namespace
