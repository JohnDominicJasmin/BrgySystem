﻿Imports System.IO
Public Class MainForm
    Private brgyInfo As BarangayInformation = New BarangayInformation


    Public Sub showPanelDisplayOf(panelDisplay As Form)

        MainPanel.Controls.Clear()
        panelDisplay.TopLevel = False
        panelDisplay.WindowState = FormWindowState.Maximized
        MainPanel.Controls.Add(panelDisplay)

        panelDisplay.Show()

    End Sub


    Private Sub Dashboard_Button_Click_1(sender As Object, e As EventArgs) Handles Dashboard_Button.Click
        Dashboard.Dispose()
        showPanelDisplayOf(Dashboard)
    End Sub

    Private Sub Residents_Button_Click_1(sender As Object, e As EventArgs) Handles Residents_Button.Click
        MyResidents.Dispose()
        showPanelDisplayOf(MyResidents)
    End Sub

    Private Sub Officials_Button_Click_1(sender As Object, e As EventArgs) Handles Officials_Button.Click
        Officials.Dispose()
        showPanelDisplayOf(Officials)
    End Sub

    Private Sub Purok_Button_Click_1(sender As Object, e As EventArgs) Handles Purok_Button.Click
        Purok.Dispose()
        showPanelDisplayOf(Purok)
    End Sub

    Private Sub Clearance_Button_Click_1(sender As Object, e As EventArgs) Handles Clearance_Button.Click
        Clearance.Dispose()

        showPanelDisplayOf(Clearance)
    End Sub



    Private Sub Archive_Button_Click_1(sender As Object, e As EventArgs) Handles Archive_Button.Click
        Archive.Dispose()
        showPanelDisplayOf(Archive)
    End Sub

    Private Sub OrganizationalChartButton_Click_1(sender As Object, e As EventArgs) Handles OrganizationalChartButton.Click
        OrganizationalChart.Dispose()
        showPanelDisplayOf(OrganizationalChart)
    End Sub

    Private Sub Settings_Button_Click_1(sender As Object, e As EventArgs) Handles Settings_Button.Click
        Settings.Dispose()
        showPanelDisplayOf(Settings)
    End Sub

    Private Sub Logout_Button_Click_1(sender As Object, e As EventArgs) Handles Logout_Button.Click
        Application.Exit()

        My.Settings.UserNotLoggedOut = False
        My.Settings.Save()
        closeConnection() 'check later


    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showPanelDisplayOf(Dashboard)

        brgyInfo.displayInformation()

        Try
            AdminNameTextBox.Text = brgyInfo.getAdminName
            MunicipalityLogo.Image = Image.FromFile(brgyInfo.getImagePath)
        Catch n As FileNotFoundException
            MessageBox.Show("Municipality Logo not found. File might have been moved or deleted.", "IMAGE NOT FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub MainForm_FormClosing(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed


        My.Settings.UserNotLoggedOut = True
        My.Settings.Save()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub
End Class
