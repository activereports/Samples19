﻿Imports System
Imports System.IO
Imports System.Windows
Imports System.Windows.Controls
Imports GrapeCity.ActiveReports
Imports System.Xml

Public Class MainWindow

	Dim CurrentFileLocation As String = System.AppDomain.CurrentDomain.BaseDirectory & "..\..\..\..\..\..\Reports\"

	Public Sub New()
		InitializeComponent()
		Icon = New System.Windows.Media.Imaging.BitmapImage(New Uri("..\\..\\..\\..\\resources\\app.ico", UriKind.Relative))
	End Sub

	Private Sub InitializeCustomCommand(resources As ResourceDictionary)
		If resources Is Nothing Then
			Throw New ArgumentNullException(NameOf(resources))
		End If
		resources("MyCommand") = New MyCommand()
	End Sub
	''' <summary>
	''' Preview Button Click- Load selected report on click 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
		Dim _report As ComboBoxItem = DirectCast(CmbListBox.SelectedItem, ComboBoxItem)

		'If the 'Add Custom Button' checkbox is checked load custom menu of Wpf Viewer 
		If chkCustomButton.IsChecked = True Then
			Dim langDictPath As String = "DefaultWPFViewerTemplates.xaml"
			Dim langDictUri As New Uri(langDictPath, UriKind.Relative)
			ResourceTheme.Source = langDictUri
			InitializeCustomCommand(ResourceTheme)
		End If

		'If the 'Add Custom Button' checkbox is not checked, clear the resource dictionary values.
		If chkCustomButton.IsChecked = False Then
			ResourceTheme.Clear()
		End If

		'Load Selected Report
		LoadReport(_report.Content.ToString())
	End Sub

	Private Sub LoadReport(reportName As String)
		Dim extension = Path.GetExtension(reportName)
		Select Case extension
			Case ".rpx"
				Dim rpt As New SectionReport()
				rpt.LoadLayout(XmlReader.Create(CurrentFileLocation + reportName))
				rpt.Document.Printer.PrinterName = String.Empty
				ReportViewer.LoadDocument(rpt)
				Exit Select
			Case ".rdlx"
				ReportViewer.LoadDocument(CurrentFileLocation + reportName)
				Exit Select
		End Select
	End Sub
	''' <summary>
	'''In the SelectionChanged event of the combo box, disable 'Add Custom Button' checkbox and 'Preview' button, when no report is selected.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub CmbListBox_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles CmbListBox.SelectionChanged
		Dim _selecteditem As ComboBoxItem = DirectCast(CmbListBox.SelectedItem, ComboBoxItem)

		If CmbListBox.SelectedIndex = 0 Then
			If chkCustomButton IsNot Nothing Then
				chkCustomButton.IsEnabled = False
			End If
			btnPreview.IsEnabled = False
		Else
			chkCustomButton.IsEnabled = True
			btnPreview.IsEnabled = True
		End If
	End Sub
End Class
