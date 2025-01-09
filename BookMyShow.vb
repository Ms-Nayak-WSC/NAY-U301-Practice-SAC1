


Public Class frmBookMyShow
    Private Sub frmBookMyShow_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class