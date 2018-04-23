Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsApplication1
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyButtonEdit
		Inherits RepositoryItemButtonEdit

		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
			TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		End Sub

		Public Overrides Sub CreateDefaultButton()
		End Sub



		Friend Const EditorName As String = "MYButtonEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyButtonEdit), GetType(RepositoryItemMyButtonEdit), GetType(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo), New MyButtonEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			TextToScroll = (CType(item, RepositoryItemMyButtonEdit)).TextToScroll
		End Sub

		Private _TextToScroll As String

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
		Public Property TextToScroll() As String
			Get
				Return _TextToScroll
			End Get
			Set(ByVal value As String)
				_TextToScroll = value
			End Set
		End Property

		Public Overrides Overloads Function GetDisplayText(ByVal editValue As Object) As String
			Return TextToScroll
		End Function

		Public Overrides Overloads Function GetDisplayText(ByVal format As DevExpress.Utils.FormatInfo, ByVal editValue As Object) As String
			Return TextToScroll
		End Function

	End Class
End Namespace