﻿Imports MySql.Data.MySqlClient
Public Class PurokChildForm
    Private var As MyPurok = New MyPurok
    Public changesInPurokText As Boolean
    Private manage As loadGridViewValue = New ManageSystem
    Private searchVal As Search = New SearchingFeature_Implementation
    Private Sub AddPurokBttn_Click_1(sender As Object, e As EventArgs) Handles AddPurokBttn.Click

        var.addNewPurok(PurokTextBox.Text)
        manage.loadGridViewValueOf(var.getAllPurokQuery, Purok.PurokGridView)

        Me.Close()



    End Sub

    Private Sub PurokChildForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateBttn_Click(sender As Object, e As EventArgs) Handles UpdateBttn.Click
        var.updatePurokTo(PurokTextBox.Text)
        manage.loadGridViewValueOf(var.getAllPurokQuery, Purok.PurokGridView)

        Me.Close()

    End Sub

    Private Sub FormIsClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        UpdateBttn.Enabled = True
        AddPurokBttn.Enabled = True
        PurokTextBox.Clear()
        searchVal.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "Purok", Purok.SearchBarField)
    End Sub

    Private Sub PuroktextChange(sender As Object, e As EventArgs) Handles PurokTextBox.TextChange
        If (changesInPurokText) Then
            UpdateBttn.Enabled = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class