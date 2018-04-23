Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web
Imports DevExpress.Web.Mvc

Public Class GridDataItem
	Public Property Id() As Integer
	<Required(ErrorMessage := "Field is required")>
	Public Property C1() As Integer
	<Range(0, 100, ErrorMessage := "Must be between 0 and 100")>
	Public Property C2() As Double
	<Required(ErrorMessage := "Field is required"), StringLength(10, ErrorMessage := "Must be under 10 characters")>
	Public Property C3() As String
	<Display(Name := "Current State"), Required(ErrorMessage := "State is required")>
	Public Property C4() As Boolean
	<Display(Name := "Current Date"), Required(ErrorMessage := "Date is required")>
	Public Property C5() As Date
End Class

Public Class BatchEditRepository
	Public Shared ReadOnly Property GridData() As List(Of GridDataItem)
		Get
			Dim key = "34FAA431-CF79-4869-9488-93F6AAE81263"
			Dim Session = HttpContext.Current.Session
			If Session(key) Is Nothing Then
				Session(key) = Enumerable.Range(0, 100).Select(Function(i) New GridDataItem With {.Id = i, .C1 = i Mod 2, .C2 = i * 0.5 Mod 3, .C3 = "C3 " & i, .C4 = i Mod 2 = 0, .C5 = New Date(2013 + i, 12, 16)}).ToList()
			End If
			Return DirectCast(Session(key), List(Of GridDataItem))
		End Get
	End Property

	Protected Shared Sub LoadNewValues(ByVal newItem As GridDataItem, ByVal postedItem As GridDataItem)
		newItem.C1 = postedItem.C1
		newItem.C2 = postedItem.C2
		newItem.C3 = postedItem.C3
		newItem.C4 = postedItem.C4
		newItem.C5 = postedItem.C5
	End Sub

	Public Shared Sub UpdateData(ByVal model As GridDataItem)
		Dim item As GridDataItem = GridData.Find(Function(i) i.Id = model.Id)
		item.C1 = model.C1
		item.C2 = model.C2
		item.C3 = model.C3
		item.C4 = model.C4
		item.C5 = model.C5
	End Sub
End Class