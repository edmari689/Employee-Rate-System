<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RaterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeRateSystemDataSet1 = New EmployeeRateSystem.employeeRateSystemDataSet1()
        Me.RaterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeRateSystemDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textBox28 = New System.Windows.Forms.TextBox()
        Me.textBox27 = New System.Windows.Forms.TextBox()
        Me.textBox26 = New System.Windows.Forms.TextBox()
        Me.textBox25 = New System.Windows.Forms.TextBox()
        Me.textBox24 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.textBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.textBox11 = New System.Windows.Forms.TextBox()
        Me.textBox10 = New System.Windows.Forms.TextBox()
        Me.textBox12 = New System.Windows.Forms.TextBox()
        Me.textBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.textBox17 = New System.Windows.Forms.TextBox()
        Me.textBox16 = New System.Windows.Forms.TextBox()
        Me.textBox20 = New System.Windows.Forms.TextBox()
        Me.textBox19 = New System.Windows.Forms.TextBox()
        Me.textBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.button3 = New System.Windows.Forms.Button()
        Me.RaterTableAdapter = New EmployeeRateSystem.employeeRateSystemDataSet1TableAdapters.raterTableAdapter()
        Me.Process1 = New System.Diagnostics.Process()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        CType(Me.RaterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeRateSystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RaterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeRateSystemDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(101, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(215, 25)
        Me.TextBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RaterBindingSource, "name", True))
        Me.ComboBox1.DataSource = Me.RaterBindingSource1
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(394, 8)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "name"
        '
        'RaterBindingSource
        '
        Me.RaterBindingSource.DataMember = "rater"
        Me.RaterBindingSource.DataSource = Me.EmployeeRateSystemDataSet1
        '
        'EmployeeRateSystemDataSet1
        '
        Me.EmployeeRateSystemDataSet1.DataSetName = "employeeRateSystemDataSet1"
        Me.EmployeeRateSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RaterBindingSource1
        '
        Me.RaterBindingSource1.DataMember = "rater"
        Me.RaterBindingSource1.DataSource = Me.EmployeeRateSystemDataSet1BindingSource
        '
        'EmployeeRateSystemDataSet1BindingSource
        '
        Me.EmployeeRateSystemDataSet1BindingSource.DataSource = Me.EmployeeRateSystemDataSet1
        Me.EmployeeRateSystemDataSet1BindingSource.Position = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rater"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(694, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(215, 25)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(570, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Completed"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(32, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.tableLayoutPanel1)
        Me.groupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(14, 59)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.groupBox1.Size = New System.Drawing.Size(393, 444)
        Me.groupBox1.TabIndex = 7
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "WORK OUTPUTS"
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.02655!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.97345!))
        Me.tableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.Label8, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.Label9, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.Label10, 1, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.Label11, 1, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.Label12, 0, 0)
        Me.tableLayoutPanel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(10, 26)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 5
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(377, 406)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 61)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "% 25"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "% 25"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 241)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "% 25"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 326)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "% 25"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 61)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(240, 32)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "1. Supervision of Operation and Maintenance of ANF"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 147)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(293, 32)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "2. Supervision of Operation and maintenance of ANF within ICAO SARPS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(76, 241)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(289, 64)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "3. Restoration of equipment /systems to operating condition (includes modificatio" & _
    "n/improvement of ckts/systems)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(76, 326)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(239, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "4. Safety and Security of facility"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "% WT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label18)
        Me.groupBox2.Controls.Add(Me.label17)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Controls.Add(Me.tableLayoutPanel2)
        Me.groupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(429, 59)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.groupBox2.Size = New System.Drawing.Size(473, 446)
        Me.groupBox2.TabIndex = 8
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "TARGETS AND ACCOMPLISHMENTS"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.Location = New System.Drawing.Point(330, 37)
        Me.label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(94, 16)
        Me.label18.TabIndex = 5
        Me.label18.Text = "TIMELINESS"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.Location = New System.Drawing.Point(198, 37)
        Me.label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(71, 16)
        Me.label17.TabIndex = 5
        Me.label17.Text = "QUALITY"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(35, 37)
        Me.label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(81, 16)
        Me.label16.TabIndex = 1
        Me.label16.Text = "QUANTITY"
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 6
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.60241!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39759!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.Label13, 2, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox28, 0, 5)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox27, 0, 5)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox26, 0, 5)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox25, 0, 5)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox24, 0, 5)
        Me.tableLayoutPanel2.Controls.Add(Me.Label14, 0, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.Label15, 1, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.TextBox2, 0, 2)
        Me.tableLayoutPanel2.Controls.Add(Me.TextBox3, 0, 3)
        Me.tableLayoutPanel2.Controls.Add(Me.TextBox4, 0, 4)
        Me.tableLayoutPanel2.Controls.Add(Me.TextBox6, 1, 3)
        Me.tableLayoutPanel2.Controls.Add(Me.TextBox7, 1, 4)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox8, 2, 2)
        Me.tableLayoutPanel2.Controls.Add(Me.TextBox9, 3, 2)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox11, 2, 3)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox10, 3, 3)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox12, 2, 4)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox13, 3, 4)
        Me.tableLayoutPanel2.Controls.Add(Me.TextBox14, 4, 2)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox17, 4, 3)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox16, 4, 4)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox20, 5, 2)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox19, 5, 3)
        Me.tableLayoutPanel2.Controls.Add(Me.textBox21, 5, 4)
        Me.tableLayoutPanel2.Controls.Add(Me.TextBox15, 5, 5)
        Me.tableLayoutPanel2.Controls.Add(Me.Label19, 4, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.Label20, 3, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.Label21, 5, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.TextBox5, 1, 2)
        Me.tableLayoutPanel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(10, 60)
        Me.tableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 6
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(448, 378)
        Me.tableLayoutPanel2.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(148, 2)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Target"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textBox28
        '
        Me.textBox28.Location = New System.Drawing.Point(223, 294)
        Me.textBox28.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox28.Multiline = True
        Me.textBox28.Name = "textBox28"
        Me.textBox28.Size = New System.Drawing.Size(61, 79)
        Me.textBox28.TabIndex = 30
        '
        'textBox27
        '
        Me.textBox27.Location = New System.Drawing.Point(148, 294)
        Me.textBox27.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox27.Multiline = True
        Me.textBox27.Name = "textBox27"
        Me.textBox27.Size = New System.Drawing.Size(63, 79)
        Me.textBox27.TabIndex = 29
        '
        'textBox26
        '
        Me.textBox26.Location = New System.Drawing.Point(77, 294)
        Me.textBox26.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox26.Multiline = True
        Me.textBox26.Name = "textBox26"
        Me.textBox26.Size = New System.Drawing.Size(61, 79)
        Me.textBox26.TabIndex = 28
        '
        'textBox25
        '
        Me.textBox25.Location = New System.Drawing.Point(296, 294)
        Me.textBox25.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox25.Multiline = True
        Me.textBox25.Name = "textBox25"
        Me.textBox25.Size = New System.Drawing.Size(61, 79)
        Me.textBox25.TabIndex = 27
        '
        'textBox24
        '
        Me.textBox24.Location = New System.Drawing.Point(5, 294)
        Me.textBox24.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox24.Multiline = True
        Me.textBox24.Name = "textBox24"
        Me.textBox24.Size = New System.Drawing.Size(62, 79)
        Me.textBox24.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 2)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Target"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(77, 2)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Actual"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(5, 28)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 79)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(5, 117)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(62, 83)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(5, 210)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(62, 75)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(77, 117)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(61, 83)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(77, 210)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(61, 75)
        Me.TextBox7.TabIndex = 8
        '
        'textBox8
        '
        Me.textBox8.Location = New System.Drawing.Point(148, 28)
        Me.textBox8.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox8.Multiline = True
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New System.Drawing.Size(62, 79)
        Me.textBox8.TabIndex = 10
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(223, 28)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(61, 79)
        Me.TextBox9.TabIndex = 9
        '
        'textBox11
        '
        Me.textBox11.Location = New System.Drawing.Point(148, 117)
        Me.textBox11.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox11.Multiline = True
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New System.Drawing.Size(62, 83)
        Me.textBox11.TabIndex = 13
        '
        'textBox10
        '
        Me.textBox10.Location = New System.Drawing.Point(223, 117)
        Me.textBox10.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox10.Multiline = True
        Me.textBox10.Name = "textBox10"
        Me.textBox10.Size = New System.Drawing.Size(61, 83)
        Me.textBox10.TabIndex = 12
        '
        'textBox12
        '
        Me.textBox12.Location = New System.Drawing.Point(148, 210)
        Me.textBox12.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox12.Multiline = True
        Me.textBox12.Name = "textBox12"
        Me.textBox12.Size = New System.Drawing.Size(62, 75)
        Me.textBox12.TabIndex = 14
        '
        'textBox13
        '
        Me.textBox13.Location = New System.Drawing.Point(223, 210)
        Me.textBox13.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox13.Multiline = True
        Me.textBox13.Name = "textBox13"
        Me.textBox13.Size = New System.Drawing.Size(61, 75)
        Me.textBox13.TabIndex = 15
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(296, 28)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(61, 79)
        Me.TextBox14.TabIndex = 11
        '
        'textBox17
        '
        Me.textBox17.Location = New System.Drawing.Point(296, 117)
        Me.textBox17.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox17.Multiline = True
        Me.textBox17.Name = "textBox17"
        Me.textBox17.Size = New System.Drawing.Size(61, 83)
        Me.textBox17.TabIndex = 19
        '
        'textBox16
        '
        Me.textBox16.Location = New System.Drawing.Point(296, 210)
        Me.textBox16.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox16.Multiline = True
        Me.textBox16.Name = "textBox16"
        Me.textBox16.Size = New System.Drawing.Size(61, 75)
        Me.textBox16.TabIndex = 18
        '
        'textBox20
        '
        Me.textBox20.Location = New System.Drawing.Point(369, 28)
        Me.textBox20.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox20.Multiline = True
        Me.textBox20.Name = "textBox20"
        Me.textBox20.Size = New System.Drawing.Size(62, 79)
        Me.textBox20.TabIndex = 22
        '
        'textBox19
        '
        Me.textBox19.Location = New System.Drawing.Point(369, 117)
        Me.textBox19.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox19.Multiline = True
        Me.textBox19.Name = "textBox19"
        Me.textBox19.Size = New System.Drawing.Size(62, 83)
        Me.textBox19.TabIndex = 21
        '
        'textBox21
        '
        Me.textBox21.Location = New System.Drawing.Point(369, 210)
        Me.textBox21.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox21.Multiline = True
        Me.textBox21.Name = "textBox21"
        Me.textBox21.Size = New System.Drawing.Size(62, 75)
        Me.textBox21.TabIndex = 23
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(369, 294)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(62, 79)
        Me.TextBox15.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(296, 2)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 16)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Target"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(223, 2)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 16)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Actual"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(369, 2)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 16)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Actual"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(77, 28)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(61, 79)
        Me.TextBox5.TabIndex = 6
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.Maroon
        Me.button3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.button3.Location = New System.Drawing.Point(677, 531)
        Me.button3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(160, 32)
        Me.button3.TabIndex = 9
        Me.button3.Text = "EVALUATE"
        Me.button3.UseVisualStyleBackColor = False
        Me.button3.UseWaitCursor = True
        '
        'RaterTableAdapter
        '
        Me.RaterTableAdapter.ClearBeforeFill = True
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(467, 531)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.UseWaitCursor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Orange
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button4.Location = New System.Drawing.Point(247, 531)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 32)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Load"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.UseWaitCursor = True
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox18.Location = New System.Drawing.Point(103, 39)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 12
        Me.TextBox18.Visible = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 584)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form6"
        Me.Text = "Evaluation"
        CType(Me.RaterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeRateSystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RaterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeRateSystemDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents EmployeeRateSystemDataSet1 As EmployeeRateSystem.employeeRateSystemDataSet1
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents textBox28 As System.Windows.Forms.TextBox
    Private WithEvents textBox27 As System.Windows.Forms.TextBox
    Private WithEvents textBox26 As System.Windows.Forms.TextBox
    Private WithEvents textBox25 As System.Windows.Forms.TextBox
    Private WithEvents textBox24 As System.Windows.Forms.TextBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents TextBox2 As System.Windows.Forms.TextBox
    Private WithEvents TextBox3 As System.Windows.Forms.TextBox
    Private WithEvents TextBox4 As System.Windows.Forms.TextBox
    Private WithEvents TextBox5 As System.Windows.Forms.TextBox
    Private WithEvents TextBox6 As System.Windows.Forms.TextBox
    Private WithEvents TextBox7 As System.Windows.Forms.TextBox
    Private WithEvents textBox8 As System.Windows.Forms.TextBox
    Private WithEvents TextBox9 As System.Windows.Forms.TextBox
    Private WithEvents textBox11 As System.Windows.Forms.TextBox
    Private WithEvents textBox10 As System.Windows.Forms.TextBox
    Private WithEvents textBox12 As System.Windows.Forms.TextBox
    Private WithEvents textBox13 As System.Windows.Forms.TextBox
    Private WithEvents TextBox14 As System.Windows.Forms.TextBox
    Private WithEvents textBox17 As System.Windows.Forms.TextBox
    Private WithEvents textBox16 As System.Windows.Forms.TextBox
    Private WithEvents textBox20 As System.Windows.Forms.TextBox
    Private WithEvents textBox19 As System.Windows.Forms.TextBox
    Private WithEvents textBox21 As System.Windows.Forms.TextBox
    Private WithEvents TextBox15 As System.Windows.Forms.TextBox
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents EmployeeRateSystemDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RaterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RaterTableAdapter As EmployeeRateSystem.employeeRateSystemDataSet1TableAdapters.raterTableAdapter
    Friend WithEvents RaterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Process1 As System.Diagnostics.Process
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
End Class
