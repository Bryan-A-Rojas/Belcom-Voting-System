Imports System.Data.SqlClient
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1

    Dim con As SqlConnection = New SqlConnection("server=localhost;Initial Catalog=db1;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    Dim myExcelApp As Excel.Application
    Dim myExcelWorkbooks As Excel.Workbooks
    Dim myExcelWorkbook As Excel.Workbook
    Dim misValue As Object = System.Reflection.Missing.Value

    Dim fileName As [String] = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\Report.xls"


    Private Sub btnVotingResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVotingResults.Click

    End Sub

    Private Sub btnBusinessStudentsList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusinessStudentsList.Click

    End Sub

    Sub export_excel(ByVal sql)
        con.Open()
        cmd = New SqlCommand(sql, con)
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            myExcelApp = New Excel.ApplicationClass()
            myExcelApp.Visible = True
            myExcelWorkbooks = myExcelApp.Workbooks


            myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, _
             misValue, misValue, misValue, misValue, misValue, misValue, _
             misValue, misValue, misValue)

            Dim myExcelWorksheet As Excel.Worksheet = DirectCast(myExcelWorkbook.ActiveSheet, Excel.Worksheet)

            myExcelWorksheet.Range("A1", misValue).Formula = "From"
            myExcelWorksheet.Range("B1", misValue).Formula = txt1.Text
            myExcelWorksheet.Range("D1", misValue).Formula = "To"
            myExcelWorksheet.Range("E1", misValue).Formula = txt2.Text

            myExcelWorksheet.Range("A3", misValue).Formula = "ID"
            myExcelWorksheet.Range("B3", misValue).Formula = "Product"
            myExcelWorksheet.Range("C3", misValue).Formula = "Price"

            Dim ctr As Integer = 4
            Do While rdr.Read()

                myExcelWorksheet.Cells(ctr, 1) = rdr("ID")
                myExcelWorksheet.Cells(ctr, 2) = rdr("product")
                myExcelWorksheet.Cells(ctr, 3) = rdr("price")
                ctr = ctr + 1
            Loop
        Else
            MsgBox("No Record Found", MsgBoxStyle.Critical)
        End If
        con.Close()
    End Sub
End Class
