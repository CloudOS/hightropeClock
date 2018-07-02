Public Class Form1
    Dim newTimerHourCount As Integer = 0
    Dim newTimerMinuteCount As Integer = 0
    Dim newTimerSecondCount As Integer = 0
    Dim newTimerMillisecondCount As Integer = 0
    Dim newTimerSlotSelection As Integer = timerSlotSelection.timerSlotSelectionOfRadio
    Dim newTimerName As String = " Timer"
    Dim timerPage As Integer = 1

    'numbered timer time variables
    Dim timer1Hours As Integer = 0
    Dim timer1Minutes As Integer = 0
    Dim timer1Seconds As Integer = 0
    Dim timer1Milliseconds As Integer = 0
    Dim timer1Active As Boolean = False

    Dim timer2Hours As Integer = 0
    Dim timer2Minutes As Integer = 0
    Dim timer2Seconds As Integer = 0
    Dim timer2Active As Boolean = False

    Dim timer3Hours As Integer = 0
    Dim timer3Minutes As Integer = 0
    Dim timer3Seconds As Integer = 0
    Dim timer3Active As Boolean = False

    Dim timer4Hours As Integer = 0
    Dim timer4Minutes As Integer = 0
    Dim timer4Seconds As Integer = 0
    Dim timer4Active As Boolean = False

    Dim timer5Hours As Integer = 0
    Dim timer5Minutes As Integer = 0
    Dim timer5Seconds As Integer = 0
    Dim timer5Active As Boolean = False

    Dim timer6Hours As Integer = 0
    Dim timer6Minutes As Integer = 0
    Dim timer6Seconds As Integer = 0
    Dim timer6Active As Boolean = False

    Dim timer7Hours As Integer = 0
    Dim timer7Minutes As Integer = 0
    Dim timer7Seconds As Integer = 0
    Dim timer7Active As Boolean = False

    Dim timer8Hours As Integer = 0
    Dim timer8Minutes As Integer = 0
    Dim timer8Seconds As Integer = 0
    Dim timer8Active As Boolean = False

    Dim timer9Hours As Integer = 0
    Dim timer9Minutes As Integer = 0
    Dim timer9Seconds As Integer = 0
    Dim timer9Active As Boolean = False

    Dim timer10Hours As Integer = 0
    Dim timer10Minutes As Integer = 0
    Dim timer10Seconds As Integer = 0
    Dim timer10Active As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub newTimerButton1_Click(sender As Object, e As EventArgs) Handles newTimerButton1.Click
        If newTimerHourCount < 23 Then
            newTimerHourCount = newTimerHourCount + 1
        Else
            newTimerHourCount = 0
        End If
    End Sub

    Private Sub newTimerButton2_Click(sender As Object, e As EventArgs) Handles newTimerButton2.Click
        If newTimerMinuteCount < 59 Then
            newTimerMinuteCount = newTimerMinuteCount + 1
        Else
            newTimerMinuteCount = 0
        End If
    End Sub

    Private Sub newTimerButton3_Click(sender As Object, e As EventArgs) Handles newTimerButton3.Click
        If newTimerSecondCount < 59 Then
            newTimerSecondCount = newTimerSecondCount + 1
        Else
            newTimerSecondCount = 0
        End If
    End Sub

    Private Sub newTimerUpdateHMS_Tick(sender As Object, e As EventArgs) Handles newTimerUpdateHMS.Tick
        If TabControl1.SelectedTab Is newTimerTab Then
            newTimerHoursButton.Text = newTimerHourCount
            newTimerMinutesButton.Text = newTimerMinuteCount
            newTimerSecondsButton.Text = newTimerSecondCount
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        newTimerRichTextBox1.Text = ""
    End Sub

    Private Sub newTimerButton4_Click(sender As Object, e As EventArgs) Handles newTimerButton4.Click
        If newTimerHourCount >= 1 Then
            newTimerHourCount = newTimerHourCount - 1
        Else
            newTimerHourCount = 23
        End If
    End Sub

    Private Sub newTimerButton5_Click(sender As Object, e As EventArgs) Handles newTimerButton5.Click
        If newTimerMinuteCount >= 1 Then
            newTimerMinuteCount = newTimerMinuteCount - 1
        Else
            newTimerMinuteCount = 59
        End If
    End Sub

    Private Sub newTimerButton6_Click(sender As Object, e As EventArgs) Handles newTimerButton6.Click
        If newTimerSecondCount >= 1 Then
            newTimerSecondCount = newTimerSecondCount - 1
        Else
            newTimerSecondCount = 59
        End If
    End Sub

    Private Sub newTimerAccept_Click(sender As Object, e As EventArgs) Handles newTimerAccept.Click
        newTimerMillisecondCount = newTimerHourCount * 3600000
        newTimerMillisecondCount = newTimerMillisecondCount + newTimerMinuteCount * 60000
        newTimerMillisecondCount = newTimerMillisecondCount + newTimerSecondCount * 1000
        If timerSlotSelection.timerSlotSelectionOfRadio >= 10 Then
            If timerSlotSelection.timerSlotSelectionOfRadio = 1 Then
                Timer1.Interval = newTimerMillisecondCount
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        timerSlotSelection.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
    End Sub

    Private Sub timerRight_Click(sender As Object, e As EventArgs) Handles timerRight.Click
        If timerPage < 10 Then
            If timerPage = 1 Then
                timerTimerLabel1.Text = "TIMER 1"

            End If
        Else
            timerPage = 1
        End If
    End Sub
End Class
