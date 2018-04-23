Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1
	Public Class MyButtonEditPainter
		Inherits ButtonEditPainter

		Public Sub New()

		End Sub

		Public Function GetScrollPosition(ByVal info As ControlGraphicsInfoArgs) As Integer
			Dim value As Object = (CType(info.ViewInfo, ButtonEditViewInfo)).EditValue
			Return Convert.ToInt32(value)
		End Function
		Protected Overrides Sub DrawContent(ByVal info As ControlGraphicsInfoArgs)
			DrawText(info)
		End Sub

		Protected Overrides Sub DrawText(ByVal info As ControlGraphicsInfoArgs)
			Dim scrollPosition As Integer = GetScrollPosition(info)
			Dim appearance As DevExpress.Utils.AppearanceObject = info.ViewInfo.Appearance
			Dim bounds As Rectangle = (TryCast(info.ViewInfo, ButtonEditViewInfo)).MaskBoxRect
			Dim displayText As String = info.ViewInfo.DisplayText
			bounds.Offset(0, scrollPosition)
			bounds.Height = info.Graphics.MeasureString(displayText, appearance.GetFont()).ToSize().Height
			appearance.DrawString(info.Cache, displayText, bounds)
		End Sub
	End Class
End Namespace
