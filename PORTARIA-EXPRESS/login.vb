Imports System.Data.OleDb
Imports System.Data




Public Class login
    Dim conexao As New OleDbConnection
    Dim comandos As New OleDbCommand
    Dim consulta As OleDbDataReader

    Public Sub Conectar()
        conexao.Close()
        conexao.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source= C:\Users\inacio.HOSPITAL\Documents\Visual Studio 2010\Projects\PORTARIA-EXPRESS\PORTARIA-EXPRESS\bin\Debug\bdExemplo.mdb")
        conexao.Open()
        comandos.Connection = conexao
    End Sub

    Public Function Desconectar()
        conexao.Close()
        Return True
    End Function

    Public Sub testaConexao()
        Try
            Conectar()
            MsgBox("Conexao Realizada com sucesso")
        Catch ex As Exception
            Desconectar()
            MsgBox("desconexao Realizada com sucesso")
        End Try

    End Sub


   
    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnentarlogin.Enabled = False
        btncancelar.Enabled = False

    End Sub




    Private Sub btnentarlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnentarlogin.Click
        Conectar()
        comandos = New OleDbCommand("select senha_fun, usuario_fun, adm_fun from tabFuncionario where usuario_fun='" & _
                                   txtusuario.Text + "' and senha_fun='" + txtsenha.Text + "'", conexao)
        consulta = comandos.ExecuteReader
        Dim usuariobd As String = Nothing
        Dim senhabd As String = Nothing

        While consulta.Read
            If consulta.Item("adm_fun") = "True" Then

            End If
            senhabd = consulta.Item("senha_fun").Trim
            usuariobd = consulta.Item("usuario_fun").Trim
        End While
        If usuariobd = txtusuario.Text And senhabd = txtsenha.Text Then
            cadastro.ShowDialog()
            Me.Close()


        ElseIf usuariobd = Nothing Or senhabd = Nothing Then
            MsgBox("Usuário ou Senha incorreto!", MsgBoxStyle.Information, "Erro")
            txtusuario.Text = ""
            txtsenha.Text = ""
            txtusuario.Focus()
        End If

        consulta.Close()
        ''Desconectar()
    End Sub

    Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
        Me.Close()



    End Sub

    Private Sub txtusuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtusuario.TextChanged
        If txtusuario.Text <> Nothing Or txtsenha.Text <> Nothing Then
            btnentarlogin.Enabled = True
            btncancelar.Enabled = True
        Else
            btnentarlogin.Enabled = False
            btncancelar.Enabled = False
        End If
    End Sub

    Private Sub txtsenha_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsenha.TextChanged
        If txtusuario.Text <> Nothing Or txtsenha.Text <> Nothing Then
            btnentarlogin.Enabled = True
            btncancelar.Enabled = True
        Else
            btnentarlogin.Enabled = False
            btncancelar.Enabled = False
        End If
    End Sub
End Class