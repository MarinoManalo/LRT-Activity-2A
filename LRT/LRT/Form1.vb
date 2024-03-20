Public Class Form1

    Dim DarkModeEnabled As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.FromArgb(237, 233, 232)
        Panel1.BackColor = Color.FromArgb(248, 248, 255)

        extBtn.BackColor = Color.FromArgb(237, 233, 232)
        extBtn.ForeColor = Color.Black

        procBtn.BackColor = Color.White
        procBtn.ForeColor = Color.Black

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DarkModeEnabled Then
            ChangeToLightMode()
        Else
            ChangeToDarkMode()
        End If

    End Sub

    Private Sub ChangeToLightMode()

        Me.BackColor = Color.FromArgb(237, 233, 232)

        extBtn.BackColor = Color.FromArgb(237, 233, 232)
        extBtn.ForeColor = Color.Black

        procBtn.BackColor = Color.White
        procBtn.ForeColor = Color.Black

        Button1.BackColor = Color.FromArgb(248, 248, 255)
        Button1.ForeColor = Color.FromArgb(248, 248, 255)

        desti1CB.BackColor = Color.White
        desti1CB.ForeColor = Color.Black

        desti2CB.BackColor = Color.White
        desti2CB.ForeColor = Color.Black

        discCB.BackColor = Color.White
        discCB.ForeColor = Color.Black

        Panel1.BackColor = Color.White

        TextBox1.ForeColor = Color.Black
        TextBox5.ForeColor = Color.Black
        TextBox4.ForeColor = Color.Black
        TextBox3.ForeColor = Color.Black
        TextBox6.ForeColor = Color.Black

        TextBox1.BackColor = Color.White
        TextBox5.BackColor = Color.White
        TextBox4.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox6.BackColor = Color.White

        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        destiLbl.ForeColor = Color.Black
        dicLbl.ForeColor = Color.Black
        Label5.ForeColor = Color.Black

        fromlbl.ForeColor = Color.Black
        Label8.ForeColor = Color.Black
        grosslbl.ForeColor = Color.Black
        disclbl.ForeColor = Color.Black
        netlbl.ForeColor = Color.Black

        DarkModeEnabled = False

    End Sub

    Private Sub ChangeToDarkMode()

        Me.BackColor = Color.FromArgb(32, 32, 32)

        desti1CB.BackColor = Color.FromArgb(24, 24, 24)
        desti1CB.ForeColor = Color.FromArgb(248, 248, 255)

        desti2CB.BackColor = Color.FromArgb(24, 24, 24)
        desti2CB.ForeColor = Color.FromArgb(248, 248, 255)

        discCB.BackColor = Color.FromArgb(24, 24, 24)
        discCB.ForeColor = Color.FromArgb(248, 248, 255)

        Panel1.BackColor = Color.FromArgb(48, 48, 48)

        extBtn.BackColor = Color.FromArgb(24, 24, 24)
        extBtn.ForeColor = Color.WhiteSmoke

        Label1.ForeColor = Color.WhiteSmoke
        Label2.ForeColor = Color.WhiteSmoke
        destiLbl.ForeColor = Color.WhiteSmoke
        dicLbl.ForeColor = Color.WhiteSmoke
        Label5.ForeColor = Color.WhiteSmoke

        fromlbl.ForeColor = Color.WhiteSmoke
        Label8.ForeColor = Color.WhiteSmoke
        grosslbl.ForeColor = Color.WhiteSmoke
        disclbl.ForeColor = Color.WhiteSmoke
        netlbl.ForeColor = Color.WhiteSmoke

        TextBox1.ForeColor = Color.WhiteSmoke
        TextBox5.ForeColor = Color.WhiteSmoke
        TextBox4.ForeColor = Color.WhiteSmoke
        TextBox3.ForeColor = Color.WhiteSmoke
        TextBox6.ForeColor = Color.WhiteSmoke

        TextBox1.BackColor = Color.FromArgb(48, 48, 48)
        TextBox5.BackColor = Color.FromArgb(48, 48, 48)
        TextBox4.BackColor = Color.FromArgb(48, 48, 48)
        TextBox3.BackColor = Color.FromArgb(48, 48, 48)
        TextBox6.BackColor = Color.FromArgb(48, 48, 48)

        procBtn.BackColor = Color.FromArgb(48, 48, 48)
        procBtn.ForeColor = Color.WhiteSmoke

        Button1.BackColor = Color.FromArgb(32, 32, 32)
        Button1.ForeColor = Color.FromArgb(32, 32, 32)

        DarkModeEnabled = True

    End Sub

    Private Sub procBtn_Click(sender As Object, e As EventArgs) Handles procBtn.Click

        Dim selectedIndex As Integer = desti1CB.SelectedIndex
        Dim selectedIndex2 As Integer = desti2CB.SelectedIndex
        Dim discount As Integer = desti2CB.SelectedIndex
        Dim discounted As Double

        Dim res As Integer = Math.Abs(selectedIndex - selectedIndex2) * 20

        If discount = 1 Then
            discounted = res * 0.1

        ElseIf discount = 2 Then
            discounted = res * 0.15

        ElseIf discount = 3 Then
            discounted = res * 0.2

        ElseIf discount = 4 Then
            discounted = res * 0.5
        End If

        TextBox1.Text = desti1CB.SelectedItem
        TextBox5.Text = desti2CB.SelectedItem
        TextBox4.Text = res.ToString("0.00")
        TextBox3.Text = discounted.ToString("0.00")
        TextBox6.Text = (res - discounted).ToString("0.00")


    End Sub


    Private Sub desti1CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles desti1CB.SelectedIndexChanged
        If desti1CB.SelectedIndex = desti2CB.SelectedIndex Then
            MessageBox.Show("Destination Identical to Pickup Station",
          "Error")

            desti1CB.SelectedIndex = -1

        End If

    End Sub

    Private Sub desti2CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles desti2CB.SelectedIndexChanged
        If desti2CB.SelectedIndex = desti1CB.SelectedIndex Then
            MessageBox.Show("Destination Identical to Pickup Station",
          "Error")

            desti2CB.SelectedIndex = -1

        End If


    End Sub

    Private Sub extBtn_Click(sender As Object, e As EventArgs) Handles extBtn.Click
        Dim ans As DialogResult

        ans = MessageBox.Show("Are you sure you want to exit?",
                        "Exit Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            Application.Exit()

        End If

    End Sub


End Class
