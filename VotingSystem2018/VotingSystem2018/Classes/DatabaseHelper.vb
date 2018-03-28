Imports System.Data.SqlClient
Public Class DatabaseHelper

    'Database Properties/Fields
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

    'Retrieve 1 dataset row using an array of conditions
    '(Usually used with a WHERE clause with 2 or more conditions.)
    'Ex: WHERE id = 1 AND email = foo@gmail.com
    Public Overloads Function GetDataSetRow(ByVal conditions() As String, ByVal tableName As String, ByVal index As Integer)
        con.Open()
        cmd = New SqlCommand(sql, con)

        For i As Integer = 0 To conditions.Length - 1
            cmd.Parameters.AddWithValue("@value" & i, conditions(i))
        Next

        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, tableName)
        If ds.Tables(0).Rows.Count > 0 Then
            GetDataSetRow = ds.Tables(0).Rows(0)(index).ToString()
        Else
            GetDataSetRow = Nothing
        End If
        con.Close()
    End Function

    'Retrieve 1 dataset row using 1 condition
    '(Usually used with a WHERE clause with one condition)
    'Ex: WHERE id = 1
    Public Overloads Function GetDataSetRow(ByVal condition As String, ByVal tableName As String, ByVal index As Integer)
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
        con.Close()
    End Function

    'Executes a non-query such as INSERT, UPDATE, or DELETE using an array of conditions
    'Ex: INSERT INTO tablename (columnname1, columnname2) VALUES (@value0, @value1)
    Public Overloads Sub ExecuteNonQuery(ByVal ParamArray conditions() As String)
        con.Open()
        cmd = New SqlCommand(sql, con)
        For i As Integer = 0 To conditions.Length - 1
            cmd.Parameters.AddWithValue("@value" & i, conditions(i))
        Next
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    'Executes a non-query such as INSERT, UPDATE, or DELETE using an array of conditions
    'Ex: UPDATE tablename SET column = 1 WHERE id = @value
    Public Overloads Sub ExecuteNonQuery(ByVal condition As String)
        con.Open()
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@value", condition)
        cmd.ExecuteNonQuery()
        con.Close()
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

End Class
