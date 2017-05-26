Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form4
    Dim ServerAsString As String = "Server=localhost;Username=root;Password=root;Database=EmployeeRateSystem"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Private Sub loadSqlConnection()
        SQLConnection.ConnectionString = ServerAsString

        Try
            If SQLConnection.State = ConnectionState.Closed Then
                SQLConnection.Open()

            Else
                SQLConnection.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub
End Class
