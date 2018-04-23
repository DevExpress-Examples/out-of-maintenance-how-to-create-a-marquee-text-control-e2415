Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			repositoryItemMyButtonEdit3.TextToScroll = String.Format("20°C{0}{0}London{0}{0}30°C{0}{0}Paris{0}", Environment.NewLine)
		End Sub


		Private Const maxValue As Integer = 100
		Private value As Integer = -maxValue

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			value += 1
			If value > maxValue Then
				value = -maxValue
			End If
			barEditItem2.EditValue = value
		End Sub
	End Class
End Namespace