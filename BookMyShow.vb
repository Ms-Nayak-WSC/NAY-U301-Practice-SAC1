


Public Class frmBookMyShow
    Private Sub frmBookMyShow_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainMenu.Show()
        Me.Close()
    End Sub
End Class