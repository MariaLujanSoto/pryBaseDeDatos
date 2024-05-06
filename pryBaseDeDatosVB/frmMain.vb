Imports System.Data.OleDb

Public Class frmMain

    Dim objConexion As OleDbConnection
    Dim objComando As OleDbCommand
    Dim objAdaptador As OleDbDataAdapter
    Dim objReader As OleDbDataReader

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim Ruta As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\NEPTUNO.accdb"

        objConexion = New OleDbConnection()
        objComando = New OleDbCommand()

        Try
            objConexion.ConnectionString = Ruta

            objConexion.Open()

            objComando.Connection = objConexion
            objComando.CommandType = CommandType.TableDirect
            objComando.CommandText = "Pedidos"

            objReader = objComando.ExecuteReader

            If objReader.HasRows Then
                While objReader.Read
                    lblResultado.Text = lblResultado.Text & " - " & objReader(0) & objReader(1)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
