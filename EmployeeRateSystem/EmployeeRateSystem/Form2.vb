Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form2
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadSqlConnection()
        Dim SQLStatement As String = "INSERT INTO employee(name, position, unit_department) VALUES ('" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
        SaveEmployee(SQLStatement)
    End Sub
    Public Sub SaveEmployee(ByRef SqlStatement As String)

        Dim cmd As MySqlCommand = New MySqlCommand

        With cmd
            .CommandText = SqlStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()

        End With

        SQLConnection.Close()
        MsgBox("Successfully added!")
        SQLConnection.Dispose()
        ListView1.Items.Clear()
        LoadListView()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

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
    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        Dim LItem As New ListViewItem
        Dim LItems As ListView.SelectedListViewItemCollection
        LItems = ListView1.SelectedItems
        For Each LItem In LItems
            TextBox1.Text = LItem.SubItems(0).Text
            TextBox2.Text = LItem.SubItems(1).Text
            TextBox3.Text = LItem.SubItems(2).Text
            TextBox4.Text = LItem.SubItems(3).Text

        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        TextBox2.AutoCompleteCustomSource.Clear()


        For i = 0 To myData.Rows.Count - 1
            TextBox2.AutoCompleteCustomSource.Add(myData.Rows(i)("name"))
        Next

        SQLConnection.Close()
        SQLConnection.Dispose()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        autoComplete()

        loadSqlConnection()
        Dim SQLStatement As String = "update employee set name = '" & TextBox2.Text & "', position = '" & TextBox3.Text & "', unit_department = '" & TextBox4.Text & "'  where id = " + TextBox1.Text + " "
        UpdateEmployee(SQLStatement)
    End Sub
    Public Sub UpdateEmployee(ByRef SqlStatement As String)
        Dim cmd As MySqlCommand = New MySqlCommand

        With cmd
            .CommandText = SqlStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()

        End With

        SQLConnection.Close()
        MsgBox("Successfully updated!")
        SQLConnection.Dispose()
        ListView1.Items.Clear()
        LoadListView()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        autoComplete()

        loadSqlConnection()
        Dim SQLStatement As String = "delete from employee where id = " + TextBox1.Text + " "
        DeleteEmployee(SQLStatement)
    End Sub
    Public Sub DeleteEmployee(ByRef SqlStatement As String)
        Dim cmd As MySqlCommand = New MySqlCommand

        With cmd
            .CommandText = SqlStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()

        End With

        SQLConnection.Close()
        MsgBox("Successfully deleted!")
        SQLConnection.Dispose()
        ListView1.Items.Clear()
        LoadListView()

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class