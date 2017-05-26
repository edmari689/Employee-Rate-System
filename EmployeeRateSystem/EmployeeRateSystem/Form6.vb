Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Form6
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

    Public Sub TextBox1_Load(ByRef ListView1)
        loadSqlConnection()

        Dim SQLStatement As String = "select * from employee"
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable


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


        Dim LItem As New ListViewItem
        Dim LItems As ListView.SelectedListViewItemCollection
        LItems = ListView1.SelectedItems
        For Each LItem In LItems
            TextBox1.Text = LItem.SubItems(1).Text
        Next

        SQLConnection.Close()
        SQLConnection.Dispose()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub loadcombo()
        loadSqlConnection()

        Dim SQLStatement As String = "select id, name from rater"

        Dim cmd As MySqlCommand = New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable


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

        If myData.Rows.Count > 0 Then
            ComboBox1.DataSource = myData
            ComboBox1.DisplayMember = "Name"
            ComboBox1.ValueMember = "Id"
        End If
        SQLConnection.Close()
        SQLConnection.Dispose()
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeRateSystemDataSet1.rater' table. You can move, or remove it, as needed.
        Me.RaterTableAdapter.Fill(Me.EmployeeRateSystemDataSet1.rater)

    End Sub

    Private WithEvents frm6 As Form6


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click

        Dim qtyTarget1, qtyActual1, test1
        Dim qtyTarget2, qtyActual2, test2
        Dim qtyTarget3, qtyActual3, test3, t1, t2
        Dim qtyTarget4, qtyActual4, test4

        Dim qlyTarget1, qlyActual1
        Dim qlyTarget2, qlyActual2
        Dim qlyTarget3, qlyActual3
        Dim qlyTarget4, qlyActual4

        Dim timeTarget1, timeActual1, test5
        Dim timeTarget2, timeActual2, test6
        Dim timeTarget3, timeActual3, test7
        Dim timeTarget4, timeActual4

        qtyTarget1 = Val(TextBox2.Text)
        qtyActual1 = Val(TextBox5.Text)
        test1 = qtyTarget1 + 20 'just for dummy testing, we forgot to get to know what exact value it is instead of 20 ok'

        qtyTarget2 = Val(TextBox3.Text)
        qtyActual2 = Val(TextBox6.Text)
        test2 = qtyTarget2 + 20

        qtyTarget3 = Val(TextBox4.Text)
        qtyActual3 = Val(TextBox7.Text)
        test3 = qtyTarget3 + 2
        t1 = qtyTarget3 - 1
        t2 = qtyTarget3 - 2

        qtyTarget4 = Val(textBox24.Text)
        qtyActual4 = Val(textBox26.Text)
        test4 = qtyTarget4 + 20

        qlyTarget1 = textBox11.Text
        qlyActual1 = textBox10.Text

        qlyTarget2 = textBox8.Text
        qlyActual2 = TextBox9.Text

        qlyTarget3 = textBox12.Text
        qlyActual3 = textBox13.Text

        qlyTarget4 = textBox27.Text
        qlyActual4 = textBox28.Text

        timeTarget1 = Val(TextBox14.Text)
        timeActual1 = Val(textBox20.Text)
        test6 = timeTarget1 + 2

        timeTarget2 = Val(textBox17.Text)
        timeActual2 = Val(textBox19.Text)
        test7 = timeTarget2 + 2

        timeTarget3 = Val(textBox16.Text)
        timeActual3 = Val(textBox21.Text)
        test5 = timeTarget3 + 2

        timeTarget4 = textBox25.Text
        timeActual4 = TextBox15.Text

        If Not IsNumeric(TextBox2.Text) Or Val(TextBox2.Text) < 0 And Not IsNumeric(TextBox5.Text) Or Val(TextBox5.Text) < 0 And Not IsNumeric(TextBox3.Text) Or Val(TextBox3.Text) < 0 And Not IsNumeric(TextBox6.Text) Or Val(TextBox6.Text) < 0 And Not IsNumeric(TextBox4.Text) Or Val(TextBox4.Text) < 0 And Not IsNumeric(TextBox7.Text) Or Val(TextBox7.Text) < 0 And Not IsNumeric(textBox24.Text) Or Val(textBox24.Text) < 0 And Not IsNumeric(textBox26.Text) Or Val(textBox26.Text) < 0 And Not IsNumeric(TextBox14.Text) Or Val(TextBox14.Text) < 0 And Not IsNumeric(textBox20.Text) Or Val(textBox20.Text) < 0 And Not IsNumeric(textBox17.Text) Or Val(textBox17.Text) < 0 And Not IsNumeric(textBox19.Text) Or Val(textBox19.Text) < 0 And Not IsNumeric(textBox16.Text) Or Val(textBox16.Text) < 0 And Not IsNumeric(textBox21.Text) Or Val(textBox21.Text) < 0 And Not IsNumeric(textBox25.Text) Or Val(textBox25.Text) < 0 And Not IsNumeric(TextBox15.Text) Or Val(TextBox15.Text) < 0 Then
            MessageBox.Show("Please input a value")
        Else

            Form4.Show()
        End If

        'first row'

        If qtyActual1 >= test1 Then
            Form4.TextBox1.Text = 10
        ElseIf qtyActual1 > qtyTarget1 Or qtyActual1 = qtyTarget1 Then
            Form4.TextBox1.Text = 8
        ElseIf qtyActual1 < qtyTarget1 And qtyActual1 >= 80 Then
            Form4.TextBox1.Text = 6
        ElseIf qtyActual1 < 80 And qtyActual1 >= 40 Then
            Form4.TextBox1.Text = 4
        Else
            Form4.TextBox1.Text = 2
        End If

        'second row'
        If Val(qtyActual2) < 0 Or Val(qtyTarget2) < 0 Then
            Form4.TextBox1.Text = 0
        ElseIf qtyActual2 >= test2 Then
            Form4.TextBox6.Text = 10
        ElseIf qtyActual2 > qtyTarget2 Or qtyActual2 = qtyTarget2 Then
            Form4.TextBox6.Text = 8
        ElseIf qtyActual2 < qtyTarget2 And qtyActual2 >= 80 Then
            Form4.TextBox6.Text = 6
        ElseIf qtyActual2 < 80 And qtyActual2 >= 40 Then
            Form4.TextBox6.Text = 4
        Else
            Form4.TextBox6.Text = 2
        End If

        'third row'
        If Val(qtyActual3) < 0 Or Val(qtyTarget3) < 0 Then
            Form4.TextBox1.Text = 0
        ElseIf qtyActual3 >= test3 Then
            Form4.TextBox11.Text = 10
        ElseIf qtyActual3 > qtyTarget3 Or qtyActual3 = qtyTarget3 Then
            Form4.TextBox11.Text = 8
        ElseIf qtyActual3 < qtyTarget3 And qtyActual3 = t1 Then
            Form4.TextBox11.Text = 6
        ElseIf qtyActual3 < qtyTarget3 And qtyActual3 = t2 Then
            Form4.TextBox11.Text = 4
        Else
            Form4.TextBox11.Text = 2
        End If

        'fourth row'
        If Val(qtyActual4) < 0 Or Val(qtyTarget4) < 0 Then
            Form4.TextBox1.Text = 0
        ElseIf qtyActual4 >= test4 Then
            Form4.TextBox16.Text = 10
        ElseIf qtyActual4 > qtyTarget4 Or qtyActual4 = qtyTarget4 Then
            Form4.TextBox16.Text = 8
        ElseIf qtyActual4 < qtyTarget4 And qtyActual4 >= 80 Then
            Form4.TextBox16.Text = 6
        ElseIf qtyActual4 < 80 And qtyActual4 >= 40 Then
            Form4.TextBox16.Text = 4
        Else
            Form4.TextBox16.Text = 2
        End If

        If qlyTarget1 = qlyActual1 Then
            Form4.TextBox7.Text = 8
        ElseIf qlyTarget1 = "" Or qlyActual1 = "" Then
            Form4.TextBox7.Text = 0
        Else
            Form4.TextBox7.Text = 2
        End If

        If qlyTarget2 = qlyActual2 Then
            Form4.TextBox2.Text = 8
        ElseIf qlyTarget2 = "" Or qlyActual2 = "" Then
            Form4.TextBox2.Text = 0
        Else
            Form4.TextBox2.Text = 2
        End If

        If qlyTarget3 = qlyActual3 Then
            Form4.TextBox12.Text = 8
        ElseIf qlyTarget3 = "" Or qlyActual3 = "" Then
            Form4.TextBox12.Text = 2
        Else
            Form4.TextBox12.Text = 2
        End If

        If qlyTarget4 = qlyActual4 Then
            Form4.TextBox17.Text = 8
        ElseIf qlyTarget4 = "" Or qlyActual4 = "" Then
            Form4.TextBox17.Text = 0
        Else
            Form4.TextBox17.Text = 2
        End If

        'first row'
        If timeActual1 >= test5 Then
            Form4.TextBox3.Text = 10
        ElseIf timeActual1 >= timeTarget1 And timeActual1 >= (timeTarget1 - 0.5) Then
            Form4.TextBox3.Text = 8
        ElseIf timeActual1 < timeTarget1 And timeActual1 >= (timeTarget1 - 0.6) Then
            Form4.TextBox3.Text = 6
        ElseIf timeActual1 < (timeTarget1 - 0.5) And timeActual1 >= (timeTarget1 - 1.5) Then
            Form4.TextBox3.Text = 4
        Else
            Form4.TextBox3.Text = 2
        End If

        'second row'
        If timeActual2 >= test6 Then
            Form4.TextBox8.Text = 10
        ElseIf timeActual2 >= timeTarget2 And timeActual2 < test6 Then
            Form4.TextBox8.Text = 8
        ElseIf timeActual2 < timeTarget2 And timeActual2 >= (timeTarget2 - 0.5) Then
            Form4.TextBox8.Text = 6
        ElseIf timeActual2 < (timeTarget2 - 0.5) And timeActual2 >= (timeTarget2 - 1.5) Then
            Form4.TextBox8.Text = 4
        Else
            Form4.TextBox8.Text = 2
        End If

        'third row'
        If timeActual3 >= test7 Then
            Form4.TextBox13.Text = 10
        ElseIf timeActual3 >= timeTarget3 And timeActual3 < test7 Then
            Form4.TextBox13.Text = 8
        ElseIf timeActual3 < timeTarget3 And timeActual3 >= (timeTarget3 - 0.5) Then
            Form4.TextBox13.Text = 6
        ElseIf timeActual3 < (timeTarget3 - 0.5) And timeActual3 >= (timeTarget3 - 1.5) Then
            Form4.TextBox13.Text = 4
        Else
            Form4.TextBox13.Text = 2
        End If

        'fourth row'
        If timeTarget4 = timeActual4 Then
            Form4.TextBox18.Text = 8
        ElseIf timeTarget4 = "" Or timeActual4 = "" Then
            Form4.TextBox18.Text = 0
        Else
            Form4.TextBox18.Text = 2
        End If


        Dim sum1, APS1, EPS1
        Dim sum2, APS2, EPS2
        Dim sum3, APS3, EPS3
        Dim sum4, APS4, EPS4
        Dim totalEPS, WAS


        sum1 = Val(Form4.TextBox1.Text) + Val(Form4.TextBox2.Text) + Val(Form4.TextBox3.Text)
        APS1 = sum1 / 3
        Form4.TextBox4.Text = APS1
        EPS1 = APS1 * 0.25
        Form4.TextBox5.Text = EPS1

        sum2 = Val(Form4.TextBox6.Text) + Val(Form4.TextBox7.Text) + Val(Form4.TextBox8.Text)
        APS2 = sum2 / 3
        Form4.TextBox9.Text = APS2
        EPS2 = APS2 * 0.25
        Form4.TextBox10.Text = EPS2

        sum3 = Val(Form4.TextBox11.Text) + Val(Form4.TextBox12.Text) + Val(Form4.TextBox13.Text)
        APS3 = sum3 / 3
        Form4.TextBox14.Text = APS3
        EPS3 = APS3 * 0.25
        Form4.TextBox15.Text = EPS3

        sum4 = Val(Form4.TextBox16.Text) + Val(Form4.TextBox17.Text) + Val(Form4.TextBox18.Text)
        APS4 = sum4 / 3
        Form4.TextBox19.Text = APS4
        EPS4 = APS4 * 0.25
        Form4.TextBox20.Text = EPS4

        totalEPS = Val(Form4.TextBox5.Text) + Val(Form4.TextBox10.Text) + Val(Form4.TextBox15.Text) + Val(Form4.TextBox20.Text)
        Form4.TextBox21.Text = totalEPS
        WAS = totalEPS * 0.6
        Form4.TextBox22.Text = WAS

    End Sub
    

    Private Sub Process1_Exited(sender As Object, e As EventArgs) Handles Process1.Exited

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        OperationMaintenance()
        Facility()
        OperationMaintenanceSarp()
        Restoration()
        MsgBox("Successfully added!")
    End Sub

    Private Sub Facility()
        loadSqlConnection()
        Dim SQLStatement As String = "INSERT INTO facility(qtytarget, qtyactual, qlytarget, qlyactual, timetarget, timeactual, employee_id) VALUES ('" & textBox24.Text & "', '" & textBox26.Text & "', '" & textBox27.Text & "', '" & textBox28.Text & "', '" & textBox25.Text & "', '" & TextBox15.Text & "', '" & TextBox18.Text & "')"
        SaveEvaluation(SQLStatement)
    End Sub


    Private Sub OperationMaintenance()
        loadSqlConnection()
        Dim SQLStatement As String = "INSERT INTO operation_maintenance(qtytarget, qtyactual, qlytarget, qlyactual, timetarget, timeactual, employee_id) VALUES ('" & TextBox2.Text & "', '" & TextBox5.Text & "', '" & textBox8.Text & "', '" & TextBox9.Text & "', '" & TextBox14.Text & "', '" & textBox20.Text & "', '" & TextBox18.Text & "')"
        SaveEvaluation(SQLStatement)
    End Sub

    Private Sub Restoration()
        loadSqlConnection()
        Dim SQLStatement As String = "INSERT INTO restoration(qtytarget, qtyactual, qlytarget, qlyactual, timetarget, timeactual, employee_id) VALUES ('" & TextBox4.Text & "', '" & TextBox7.Text & "', '" & textBox12.Text & "', '" & textBox13.Text & "', '" & textBox16.Text & "', '" & textBox21.Text & "', '" & TextBox18.Text & "')"
        SaveEvaluation(SQLStatement)
    End Sub

    Private Sub OperationMaintenanceSarp()
        loadSqlConnection()
        Dim SQLStatement As String = "INSERT INTO operation_maintenance_sarp(qtytarget, qtyactual, qlytarget, qlyactual, timetarget, timeactual, employee_id) VALUES ('" & TextBox3.Text & "', '" & TextBox6.Text & "', '" & textBox11.Text & "', '" & textBox10.Text & "', '" & textBox17.Text & "', '" & textBox19.Text & "', '" & TextBox18.Text & "')"
        SaveEvaluation(SQLStatement)
    End Sub



    Public Sub SaveEvaluation(ByRef SqlStatement As String)

        Dim cmd As MySqlCommand = New MySqlCommand

        With cmd
            .CommandText = SqlStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()

           
          

        End With

        SQLConnection.Close()

        SQLConnection.Dispose()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'loadSqlConnection()'
        'Dim SQLStatement As String = "select * from operation_maintenance"'
        Form7.Show()
    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class