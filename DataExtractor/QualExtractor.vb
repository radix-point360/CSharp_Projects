Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.IO.Directory
Imports Microsoft.Office.Interop
Imports excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail
Imports DocumentFormat.OpenXml.Spreadsheet
Imports ClosedXML.Excel
Imports System.Windows.Interop
Imports SixLabors.Fonts.Tables.General
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Microsoft.Office.Interop.Excel

Public Class QualExtractor
    Dim con As New SqlConnection()
    Dim cmd As New SqlCommand()
    Dim da As New SqlDataAdapter()
    Dim dtData As New System.Data.DataTable()
    Dim dr As DataRow = dtData.NewRow
    Dim half As Integer
    Dim quarter As Integer
    Dim str As String
    Dim conStr As String = ""
    Dim CmdStr As String = ""

    Private Sub QualExtractor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pbLoad.Visible = False
            btnExcel.Enabled = False
            btnExcel.Visible = False
            lblInfo.Text = ""
            lblInfo.Visible = False

            cboSrlType.Items.Add("Select Type")
            cboSrlType.Items.Add("Library")
            cboSrlType.Items.Add("Student Admission")
            cboSrlType.Items.Add("Student Allocation")
            cboSrlType.Items.Add("Employee")

            dgGetData.DataSource = dtData
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        Try
            GetData()
            dgGetData.Refresh()
            dgGetData.DataSource = dtData
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CreateDataTable()
        Try
            Dim columnNames() As String = {}
            pbLoad.Visible = True
            pbLoad.Enabled = True
            pbLoad.Value = 10
            dtData.Columns.Add("SrNo", GetType(Int32))
            If cboSrlType.Text = "Select Type" Then
                columnNames = {"Please Select Type"}
                txtCmd.Text = "Please Select Type To Auto Fill This Box"
            ElseIf cboSrlType.Text = "Library" Then
                columnNames = {"Media", "Accession No.", "Language Master", "Book Title", "Author1", "Author2", "Author3", "Publisher", "Publication Year", "Publisher Place", "Section", "Rack No", "Shelf No", "Volume", "Book Edition", "Book Subject", "Legacy No", "Type", "Classification No", "ISBN No", "Is Donated ?", "Donated By", "Can Issue ?", "Show In OPAC ?", "Book Category", "Book SubCategory", "Library Register", "Series Title", "Binding Type", "Class No", "Verification Type", "Verification Date", "Budget No", "Estimated Amount", "Total Page", "Source", "Barcode", "Cutter/Author Mark", "Expiry Date", "Is Reusable ?", "Is Gratis ?", "Can Download ?", "Remarks", "Vendor", "Currency", "Currency Conversion Rate", "Is Direct Purchase ?", "Bill No", "Bill Date", "Order Date", "Purchase Cost", "Actual Price", "Discount(%)", "Invoice Detail", "MedMagazine Expiry Dateia", "Magazine Month Year", "Issue No", "Abstract", "Status", "Class", "Register No.", "Accession Date", "Department"}
                txtCmd.Text = "Select  top 10 type as Media, BookNo as ""Accession No."",RecLang as ""Language Master"",Issue,BookName as ""Book Title"",Author as Author1, Author2,Author3,Publisher,Department,Status,Pages as ""Total Page"" ,BookEntryDate as ""Accession Date"",Abstract, Year as ""Publication Year"",PlaceOfPublication as ""Publisher Place"",Price as ""Actual Price"",Discount as ""Discount(%)"",Subcategory as ""Book SubCategory"",BookType as ""Binding Type"",Section,RackNo,Remark,TypeVerf as ""Verification Type"",VerificationDate as ""Verification Date"",ShellNo as ""Shelf No"",Volume,EDN as ""Book Edition"",Subject as ""Book Subject"",type,ClassNo as ""Classification No"",ISBNNo,DonatedBy as ""Donated By"" from LBRBooks"
            ElseIf cboSrlType.Text = "Student Admission" Then
                columnNames = {"Institute", "Program", "Admitted AY", "DOA", "GR No.", "Class to be Admitted", "First Name", "Middle Name", "Last Name", "Father's Full Name", "Mother Name", "Gender", "Admission Mode", "Application No.", "DOB", "Nationality", "Place of Birth", "Religion", "Mother Tongue", "Caste Category", "Blood Group", "TC Issued", "PRN Number"}
                txtCmd.Text = "select  RegNo as ""GR No."", ClassAdmitted as ""Class to be Admitted"",FirstName as ""First Name"",LastName as ""Father's Full Name"",MothersName as ""Mother's Name"",Sex as ""Gender"",DOB,Nationality,PlaceofBirth as ""Place of Birth"",Religion,Caste as ""Caste Category"",BloodGrp as ""Blood Group"",MTongue as ""Mother Tongue"",   YEAR( DateOfAddmision) as ""DOA""  from AdmittedStudents
"
            ElseIf cboSrlType.Text = "Student Allocation" Then
                columnNames = {"Institute", "Program", "Academic Year", "Class", "Division", "Specialization", "Class-Division", "GR. No.", "Roll No."}
                txtCmd.Text = "Query Under Constructions"

            ElseIf cboSrlType.Text = "Employee" Then
                columnNames = {"Institute", "Program", "Type", "Department", "Employee Code", "Enrollment No.", "Salutation", "First Name", "Middle Name", "Last Name", "Short Name", "Gender", "Designation", "Current Address", "State", "City", "Pin Code", "Permanent Address", "Mobile No.", "Phone No.", "Joining Date", "DOB", "Marital Status", "Place of Birth", "Nationality", "Religion", "Mother Tongue", "Wedding Date", "Blood Group", "ID Card No.", "PAN Card No.", "Faculty/Admin"}
                txtCmd.Text = "Query Under Constructions"
            End If

            pbLoad.Value = 50
            For Each columnName As String In columnNames
                dtData.Columns.Add(columnName, GetType(String))
            Next
            pbLoad.Value = 80
            pbLoad.Value = 100
            Dim SrNo As DataColumn = dtData.Columns("SrNo")
            SrNo.AutoIncrement = True
            SrNo.AutoIncrementSeed = 1
            SrNo.AutoIncrementStep = 1
            pbLoad.Value = 0
            pbLoad.Enabled = False
            pbLoad.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetData()
        Try
            pbLoad.Visible = True
            pbLoad.Enabled = True
            Dim dtMyData As New System.Data.DataTable()
            pbLoad.Value = 10
            con.Open()
            da = New SqlDataAdapter(cmd)
            da.Fill(dtMyData)
            Dim drMyData As DataRow

            pbLoad.Value = 30
            half = dtMyData.Rows.Count / 2
            quarter = dtMyData.Rows.Count / 4
            For i As Integer = 0 To dtMyData.Rows.Count - 1
                drMyData = dtMyData.Rows(i)

                dr = dtData.NewRow
                For Each col As DataColumn In dtData.Columns
                    For Each MyDataCol As DataColumn In dtMyData.Columns
                        If col.ColumnName = MyDataCol.ColumnName Then
                            'Skip SrNo Because it is Primary Key
                            If col.ColumnName = "SrNo" Then
                                Continue For
                            End If
                            If IsDBNull(drMyData(MyDataCol).ToString()) Or IsNothing(drMyData(MyDataCol).ToString()) Or drMyData(MyDataCol).ToString() = "" Then dr(col) = "" Else dr(col) = drMyData(MyDataCol)
                        End If
                    Next
                Next

                If i = quarter Then
                    pbLoad.Value = 42
                ElseIf i = half Then
                    pbLoad.Value = 55
                End If
                dtData.Rows.Add(dr)
            Next

            btnExcel.Enabled = True
            btnExcel.Visible = True
            pbLoad.Value = 99
            MsgBox("Data Loaded Successfuly!!!!!!!!!!!")
            pbLoad.Value = 0
            pbLoad.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            pbLoad.Visible = True
            pbLoad.Enabled = True

            pbLoad.Value = 10

            Dim sfd As SaveFileDialog = New SaveFileDialog()
            sfd.Filter = "Excel Workbbok|*.xlsx"
            pbLoad.Value = 20
            If sfd.ShowDialog = DialogResult.OK Then
                pbLoad.Value = 30
                Using Workbook As XLWorkbook = New XLWorkbook
                    Workbook.Worksheets.Add(dtData, "MySheet")
                    pbLoad.Value = 40
                    Workbook.SaveAs(sfd.FileName)
                    pbLoad.Value = 50
                End Using
                pbLoad.Value = 80
                pbLoad.Value = 95
                pbLoad.Value = 100

                MsgBox("Please Fime Your sheet at " & sfd.FileName & " location", MessageBoxIcon.Information, MessageBoxButtons.OK)

            End If

            pbLoad.Value = 0
            pbLoad.Enabled = False
            pbLoad.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtCon_TextChanged(sender As Object, e As EventArgs) Handles txtCon.TextChanged
        Try
            conStr = txtCon.Text.Trim()
            If conStr.Trim() <> "" Then
                con = New SqlConnection(conStr)

            Else
                MsgBox("Please enter Connection String!!!", MessageBoxIcon.Error, MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCmd_TextChanged(sender As Object, e As EventArgs) Handles txtCmd.TextChanged
        Try
            CmdStr = txtCmd.Text.Trim()
            If CmdStr.Trim() <> "" Then
                cmd = New SqlCommand(CmdStr, con)
                lblInfo.Visible = True
                lblInfo.Text = "Please use 'ALIES' exactly as shown in the GridView table.!!! "
            Else
                MsgBox("Please enter SQL Query!!!", MessageBoxIcon.Error, MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            MsgBox("PLEASE USE ALIES SAME AS IN THE GRID COLUM FOR EXAMPLE REFER THIS ---> Select top 10 type as Media,BookNo as ""Accession No."",RecLang as ""Language Master"",BookName as ""Book Title"" from LBRBooks" & vbNewLine & "in case if records are not shown after data successful loaded please click on column headers", MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboSrlType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSrlType.SelectedIndexChanged
        Try
            Dim count As Integer = 0
            dtData.Clear()
            dtData.Dispose()
            dtData.Reset()
            cboColName.Items.Clear()
            txtDefaulVal.Text = ""
            CreateDataTable()
            'Set Default Value Column Name
            For Each col As DataColumn In dtData.Columns
                cboColName.Items.Add(col.ColumnName)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDefaultVal_Click(sender As Object, e As EventArgs) Handles btnDefaultVal.Click
        Try
            'To Fill the Default Value
            For Each r As DataRow In dtData.Rows
                If cboColName.Text = "Institute" Then
                    r(cboColName.Text) = cboSelInstitue.Text
                Else
                    r(cboColName.Text) = txtDefaulVal.Text
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboColName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboColName.SelectedIndexChanged
        Try
            txtDefaulVal.Enabled = False
            cboSelInstitue.Enabled = False
            Dim dtInst As New System.Data.DataTable()

            If cboColName.Text = "Institute" Then
                cboSelInstitue.Enabled = True
                str = ""
                str = "Select SchoolName from school"
                con.Open()
                cmd = New SqlCommand(str, con)
                da = New SqlDataAdapter(cmd)
                da.Fill(dtInst)
                cboSelInstitue.DisplayMember = "SchoolName"
                'cboSelInstitue.ValueMember = ""
                cboSelInstitue.DataSource = dtInst
                txtDefaulVal.Text = ""
            Else
                txtDefaulVal.Text = ""
                txtDefaulVal.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    'Private Sub ReleaseObject(ByVal o As Object)
    '    Try
    '        While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
    '        End While
    '    Catch
    '    Finally
    '        o = Nothing
    '    End Try
    'End Sub
End Class