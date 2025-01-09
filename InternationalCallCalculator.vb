

Imports System.ComponentModel

Public Class frmCallCalculator
    Private Sub frmCallCalculator_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class