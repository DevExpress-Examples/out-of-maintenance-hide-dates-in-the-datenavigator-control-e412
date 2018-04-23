Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication22
	Public Class CustomDateNavigator
		Inherits DateNavigator
		Private Class MyDateEditInfoArgs
			Inherits DateEditInfoArgs
			Public Sub New(ByVal calendar As DateEditCalendarBase)
				MyBase.New(calendar)
			End Sub
			Protected Overrides Sub CalcDayNumberCells()
				MyBase.CalcDayNumberCells()
				RemoveInactiveDays()
			End Sub
			Protected Sub RemoveInactiveDays()
				Dim count As Integer = DayCells.Count
				For i As Integer = count - 1 To 0 Step -1
					If (Not DayCells(i).IsActive) Then
						DayCells.RemoveAt(i)
					End If
				Next i
			End Sub
		End Class
		Protected Overrides Function CreateInfoArgs() As DateEditInfoArgs
			Return New MyDateEditInfoArgs(Me)
		End Function
	End Class
End Namespace
