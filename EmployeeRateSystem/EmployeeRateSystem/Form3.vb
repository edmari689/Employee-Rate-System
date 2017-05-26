Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form3
    Dim ServerAsString As String = "Server=localhost;Username=root;Password=root;Database=employeeRateSystem"
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
    Public Sub LoadListView()
        loadSqlConnection()

        Dim SQLStatement As String = "select * from employee"
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()

        End With

        With myAdapter
            .SelectCommand = cmd
            .Fill(myData)
        End With

        For i = 0 To myData.Rows.Count - 1

            With ListView1

                .Items.Add(myData.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(myData.Rows(i)("name"))

                    .Add(myData.Rows(i)("position"))

                    .Add(myData.Rows(i)("unit_department"))

                End With

            End With

        Next
        SQLConnection.Close()
        SQLConnection.Dispose()
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListView()
        autoComplete()
    End Sub

    Private Sub autoComplete()
        loadSqlConnection()
        Dim SQLStatement As String = "select name from employee"
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim i As Integer


        With cmd
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()

        End With

        With myAdapter
            .SelectCommand = cmd
            .Fill(myData)
        End With

        TextBox1.AutoCompleteCustomSource.Clear()


        For i = 0 To myData.Rows.Count - 1
            TextBox1.AutoCompleteCustomSource.Add(myData.Rows(i)("name"))
        Next

        SQLConnection.Close()
        SQLConnection.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        loadSqlConnection()

        Dim SQLStatement As String = "select * from employee where name = '" & TextBox1.Text.Trim.ToString & "'"
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()

        End With

        With myAdapter
            .SelectCommand = cmd
            .Fill(myData)
        End With

        ListView1.Items.Clear()

        For i = 0 To myData.Rows.Count - 1

            With ListView1

                .Items.Add(myData.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(myData.Rows(i)("name"))

                    .Add(myData.Rows(i)("position"))

                    .Add(myData.Rows(i)("unit_department"))
                End With

            End With

        Next
        SQLConnection.Close()
        SQLConnection.Dispose()
    End Sub

    Private WithEvents frm3 As Form3


    Public Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

        Dim LItem As New ListViewItem
        Dim LItems As ListView.SelectedListViewItemCollection
        LItems = ListView1.SelectedItems

        Form6.Show()
        For Each LItem In LItems

            Form6.TextBox18.Text = LItem.SubItems(0).Text
            Form6.TextBox1.Text = LItem.SubItems(1).Text

        Next

        Me.Close()
    End Sub
    Private Sub GetDetail(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
End Class