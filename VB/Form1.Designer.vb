Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
			Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemMyButtonEdit3 = New WindowsApplication1.RepositoryItemMyButtonEdit()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemMyButtonEdit2 = New WindowsApplication1.RepositoryItemMyButtonEdit()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.repositoryItemMyButtonEdit1 = New WindowsApplication1.RepositoryItemMyButtonEdit()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar3})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barEditItem1, Me.barEditItem2, Me.barStaticItem1, Me.barStaticItem2})
			Me.barManager1.MaxItemId = 5
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMyButtonEdit1, Me.repositoryItemMyButtonEdit2, Me.repositoryItemMyButtonEdit3})
			Me.barManager1.StatusBar = Me.bar3
			Me.barManager1.TransparentEditors = True
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem2, "", False, True, True, 269)})
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' barStaticItem2
			' 
			Me.barStaticItem2.Caption = "Weather"
			Me.barStaticItem2.Id = 4
			Me.barStaticItem2.Name = "barStaticItem2"
			Me.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' barEditItem2
			' 
			Me.barEditItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.barEditItem2.Appearance.Options.UseFont = True
			Me.barEditItem2.AutoFillWidth = True
			Me.barEditItem2.CanOpenEdit = False
			Me.barEditItem2.Caption = "barEditItem2"
			Me.barEditItem2.Edit = Me.repositoryItemMyButtonEdit3
			Me.barEditItem2.Id = 2
			Me.barEditItem2.Name = "barEditItem2"
			' 
			' repositoryItemMyButtonEdit3
			' 
			Me.repositoryItemMyButtonEdit3.AllowFocused = False
			Me.repositoryItemMyButtonEdit3.Appearance.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.repositoryItemMyButtonEdit3.Appearance.Options.UseFont = True
			Me.repositoryItemMyButtonEdit3.AutoHeight = False
			Me.repositoryItemMyButtonEdit3.Name = "repositoryItemMyButtonEdit3"
			Me.repositoryItemMyButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.repositoryItemMyButtonEdit3.TextToScroll = Nothing
			Me.repositoryItemMyButtonEdit3.UseParentBackground = True
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(437, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 176)
			Me.barDockControlBottom.Size = New System.Drawing.Size(437, 28)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 176)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(437, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 176)
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Caption = "barEditItem1"
			Me.barEditItem1.Edit = Me.repositoryItemMyButtonEdit2
			Me.barEditItem1.EditValue = 6
			Me.barEditItem1.Id = 1
			Me.barEditItem1.Name = "barEditItem1"
			' 
			' repositoryItemMyButtonEdit2
			' 
			Me.repositoryItemMyButtonEdit2.AutoHeight = False
			Me.repositoryItemMyButtonEdit2.Name = "repositoryItemMyButtonEdit2"
			Me.repositoryItemMyButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.repositoryItemMyButtonEdit2.TextToScroll = "Hello"
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Caption = "label"
			Me.barStaticItem1.Id = 3
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' repositoryItemMyButtonEdit1
			' 
			Me.repositoryItemMyButtonEdit1.AutoHeight = False
			Me.repositoryItemMyButtonEdit1.Name = "repositoryItemMyButtonEdit1"
			Me.repositoryItemMyButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
			Me.repositoryItemMyButtonEdit1.TextToScroll = Nothing
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 70
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(437, 204)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar3 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private repositoryItemMyButtonEdit1 As RepositoryItemMyButtonEdit
		Private barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemMyButtonEdit2 As RepositoryItemMyButtonEdit
		Private barEditItem2 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemMyButtonEdit3 As RepositoryItemMyButtonEdit
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private barStaticItem2 As DevExpress.XtraBars.BarStaticItem
		Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
	End Class
End Namespace

