Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication22
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.customDateNavigator1 = New WindowsApplication22.CustomDateNavigator()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customDateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(464, 362)
			Me.schedulerControl1.Start = New System.DateTime(2008, 8, 21, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' customDateNavigator1
			' 
			Me.customDateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
			Me.customDateNavigator1.Location = New System.Drawing.Point(464, 0)
			Me.customDateNavigator1.Name = "customDateNavigator1"
			Me.customDateNavigator1.SchedulerControl = Me.schedulerControl1
			Me.customDateNavigator1.Size = New System.Drawing.Size(185, 362)
			Me.customDateNavigator1.TabIndex = 1
			Me.customDateNavigator1.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.MonthInfo
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(649, 362)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.customDateNavigator1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customDateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private customDateNavigator1 As CustomDateNavigator
	End Class
End Namespace

