Imports DevExpress.Web.Mvc
Imports Newtonsoft.Json
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace E430_MVC.Controllers
	Public Class HomeController
		Inherits Controller

		' GET: Home
		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView(BatchEditRepository.GridData)
		End Function

	   Public Function UpdateData(ByVal data As String) As JsonResult
			Try
				BatchEditRepository.UpdateData(JsonConvert.DeserializeObject(Of GridDataItem)(data))
				Return Json("OK")
			Catch ex As Exception
				Return Json(ex.Message)
			End Try
	   End Function
	End Class
End Namespace