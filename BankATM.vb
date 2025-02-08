Imports System.ComponentModel

Public Class BankATM

    Private Sub BankATM_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainMenu.Show()
    End Sub
End Class