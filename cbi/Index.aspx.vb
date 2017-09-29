Partial Class Index
	Inherits System.Web.UI.Page

	Private Sub Index_Load(sender As Object, e As EventArgs) Handles Me.Load
		Dim calc As CBILite.Core.ICalc = New CBILite.Calculator()
		Page.Title = calc.Add(1, 2)

	End Sub
End Class
