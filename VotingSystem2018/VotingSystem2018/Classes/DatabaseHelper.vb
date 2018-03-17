Imports System.Data.SqlClient
Public Class DatabaseHelper

    Private cmd As SqlCommand
    Private rdr As SqlDataReader
    Private sql As String
    Private con As SqlConnection

    Private da As SqlDataAdapter
    Private ds As DataSet
    Private dr As DataRow

    'Constructor
    Public Sub New(ByVal conString As String)
        con = New SqlConnection(conString)
    End Sub

    'Connection String Getter and Setter 
    Public Sub SetConnection(ByVal str As String)
        con = New SqlConnection(str)
    End Sub
    Public Function GetConnection()
        GetConnection = con
    End Function

    'SQL String Getter and Setter 
    Public Sub SetSql(ByVal str As String)
        sql = str
    End Sub
    Public Function GetSql()
        GetSql = sql
    End Function

    'Retrieve 1 dataset row
    Public Function GetDataSetRow(ByVal condition As String, ByVal tableName As String, ByVal index As Int16)
        'Try
        con.Open()
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@value", condition)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, tableName)
        If ds.Tables(0).Rows.Count > 0 Then
            GetDataSetRow = ds.Tables(0).Rows(0)(index).ToString()
        Else
            GetDataSetRow = Nothing
        End If
        'Catch ex As Exception
        'MsgBox("Invalid Input ", vbExclamation, "Error")
        'Finally
        con.Close()
        'End Try
    End Function

    Public Sub ExecuteNonQuery(ByVal condition As String)
        con.Open()
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@value", condition)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Sub ExecuteQuery()
        con.Open()
        cmd = New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Class
