Public Class Form1

    Private m_Listener As UDP.TraceListener = New UDP.TraceListener

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Trace.Write(TextBox1.Text)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Trace.Listeners.Remove(m_Listener)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Trace.Listeners.Add(m_Listener)

        Try
            Err.Raise(1111)
        Catch ex As Exception
            Trace.Write(ex)
        End Try

    End Sub
End Class
