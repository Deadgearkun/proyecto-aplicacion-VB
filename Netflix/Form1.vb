Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Useresq.Text = user


    End Sub

    Private Sub ListarPeliculaaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarPeliculaaToolStripMenuItem.Click

    End Sub

    Private Sub CerrarAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicacionToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgregarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPeliculaToolStripMenuItem.Click
        addmovie.ShowDialog()
    End Sub
End Class
