Imports System.Diagnostics

Public Class Form1
    Private stopwatch As Stopwatch

    Public Sub New()
        InitializeComponent()
        stopwatch = New Stopwatch()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        stopwatch.Start()
        timer.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        stopwatch.Stop()
        timer.Stop()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        stopwatch.Reset()
        lblTime.Text = "00:00:00"
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Dim elapsedTime As TimeSpan = stopwatch.Elapsed
        lblTime.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub
End Class
