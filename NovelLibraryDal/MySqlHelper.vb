Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class MySqlHelper
    Public Function GetSqlConnectionString() As String
        Return ConfigurationManager.ConnectionStrings("strConn").ConnectionString
    End Function

    Public Function ExecuteNonQuery(sqlText As String, parameters As MySqlParameter()) As Integer
        Using conn As New MySqlConnection(GetSqlConnectionString)
            Using cmd As MySqlCommand = conn.CreateCommand()
                conn.Open()
                cmd.CommandText = sqlText
                cmd.Parameters.AddRange(parameters)
                Return cmd.ExecuteNonQuery
            End Using
        End Using
    End Function

    Public Function ExecuteNewNonQuery(sqlText As String) As Integer
        Using conn As New MySqlConnection(GetSqlConnectionString)
            Using cmd As MySqlCommand = conn.CreateCommand()
                conn.Open()
                cmd.CommandText = sqlText
                Return cmd.ExecuteNonQuery
            End Using
        End Using
    End Function

    Public Function ExecuteScalar(sqlText As String, parameters As MySqlParameter()) As Object
        Using conn As New MySqlConnection(GetSqlConnectionString)
            Using cmd As MySqlCommand = conn.CreateCommand
                conn.Open()
                cmd.CommandText = sqlText
                cmd.Parameters.AddRange(parameters)
                Return cmd.ExecuteScalar
            End Using
        End Using
    End Function

    Public Function ExecuteDataTable(sqlText As String, parameters As MySqlParameter()) As DataTable
        Using adapter As New MySqlDataAdapter(sqlText, GetSqlConnectionString)
            Dim dt As New DataTable
            If parameters Is Nothing Then

            Else
                adapter.SelectCommand.Parameters.AddRange(parameters)
            End If

            adapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ExecuteReader(sqlText As String, parameters As MySqlParameter()) As MySqlDataReader
        Dim conn As New MySqlConnection(GetSqlConnectionString)
        Dim cmd As MySqlCommand = conn.CreateCommand()
        conn.Open()
        cmd.CommandText = sqlText
        cmd.Parameters.AddRange(parameters)
        'CommandBehavior.CloseConnection：代表，当SqlDataaReader释放的时候，顺便把SqlConnection对象也释放掉
        Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
    End Function
End Class
