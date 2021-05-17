﻿Imports MySql.Data.MySqlClient
Public Class MyArchive
    Inherits MyPurok
    Private restore As RestoreValue = New ManageSystem

    Private purokdelete As DeleteValue = New ManageSystem

    Sub restoreData(nameToRestore As String)
        Dim query As String = "INSERT INTO Purok SELECT * from archive_purok where PurokName = '" & nameToRestore & "';
                            DELETE FROM archive_purok WHERE PurokName = '" & nameToRestore & "';"

        Try
            If (MessageBox.Show("Are you sure you want to restore '" & nameToRestore.ToUpper.Trim & "' Purok?", "Are you sure you want to archive?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
                If (restore.RestoreValueAt(query)) Then
                    MessageBox.Show("Purok '" & nameToRestore.ToUpper.Trim & "' was restored successfully! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch duplicate As MySqlException
            MessageBox.Show("Failed restoring Purok. A Purok '" & nameToRestore.ToUpper.Trim & "' already exist at the Purok list.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try



    End Sub
    Overloads Sub deletePurok(name As String)
        'WHY ENCAPSULATION IS NOT WORKING? PASSING DATA FROM CLASS A TO B NOT WORKING 
        If (MessageBox.Show("Are you sure you want to delete '" & name.ToUpper.Trim & "' Purok?", "Are you sure you want to delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
            If (purokdelete.deleteValueAt("DELETE FROM `archive_purok` WHERE PurokName = '" & name.Trim & "' ")) Then
                MessageBox.Show("Purok '" & name.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        closeConnection()
    End Sub

End Class
