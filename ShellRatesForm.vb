Imports System.ComponentModel

Public Class ShellRatesForm
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            System.Diagnostics.Process.Start("https://vt.shell.com/vtexchangerates/default.aspx")
        Catch

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillComboBoxWithCurrencies(cmbBaseCurrency)
        FillComboBoxWithCurrencies(cmbQueryCurrency)

        DTPickerFrom.Value = New Date(Today.Year, Today.Month, 1)
        DTPickerTo.Value = DateAdd("d", -1, New Date(Today.Year, Today.AddMonths(1).Month, 1))

        ProgressBar1.Visible = False

        OptionButtonNewWorkbook.Checked = True
        OptionButtonDaily.Checked = True
        OptionButtonSheet.Checked = True
        OptionButtonDaily.Select()
        cmbBaseCurrency.Select()

    End Sub

    Private Sub FillComboBoxWithCurrencies(oComboBox As ComboBox)
        Dim sCur As String

        For Each sCur In My.Settings.AllCurrencies
            oComboBox.Items.Add(sCur)
        Next

        oComboBox.SelectedIndex = 0

    End Sub

    Private Function validateFields() As Boolean
        Dim vFlag As Boolean = True

        If cmbBaseCurrency.SelectedValue = cmbQueryCurrency.SelectedValue Then
            MsgBox("Base and Query Currency cannot be the same")
            vFlag = False
        ElseIf DTPickerFrom.Value > DTPickerTo.Value Then
            MsgBox("Date from cannot be higher than date to")
            vFlag = False
        End If

        Return vFlag

    End Function

    Private Sub OptionButtonDaily_CheckedChanged(sender As Object, e As EventArgs) Handles OptionButtonDaily.CheckedChanged
        If OptionButtonDaily.Checked Then
            ButtonTable.Enabled = True
        Else
            ButtonTable.Enabled = False
        End If
    End Sub

    Private Sub ButtonExcel_Click(sender As Object, e As EventArgs) Handles ButtonExcel.Click
        Dim FileDownloaded As Boolean = False

        If validateFields() Then
            FileDownloaded = 

        End If
    End Sub
End Class
