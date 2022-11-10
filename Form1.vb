Imports System.IO
Imports System.Security.AccessControl
Imports System.Security.Cryptography
Imports System.Security.Principal
Imports System.Text

Public Class Form1

    Dim ultimoArchivoEscrito As String
    Dim ultimoTextoEscrito As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RBTexto.Checked = True
    End Sub

    Private Sub RadioBoton_CheckedChanged(sender As Object, e As EventArgs) Handles RBTexto.CheckedChanged
        If RBTexto.Checked = True Then
            BtnSeleccionar.Visible = False
            BtnCalcular.Location = New Point(190, 12)
            BtnCalcular.Size = New Size(1100, 60)
            TBEntrada.Multiline = True
            TBEntrada.Size = New Size(1230, 160)
            ultimoArchivoEscrito = TBEntrada.Text
            TBEntrada.Text = ultimoTextoEscrito
            LblEntrada.Text = "Texto :"
            PnlRespuestas.Location = New Point(0, 254)
            Me.Size = New Size(1338, 554)
        Else
            BtnSeleccionar.Visible = True
            BtnCalcular.Location = New Point(320, 12)
            BtnCalcular.Size = New Size(970, 60)
            TBEntrada.Multiline = False
            TBEntrada.Size = New Size(1230, 27)
            ultimoTextoEscrito = TBEntrada.Text
            TBEntrada.Text = ultimoArchivoEscrito
            LblEntrada.Text = "Archivo :"
            PnlRespuestas.Location = New Point(0, 124)
            Me.Size = New Size(1338, 424)

        End If
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click

        Dim Ofichero As New OpenFileDialog
        Dim OResultado As DialogResult
        Dim infofile As FileInfo
        Dim fs As FileStream
        Dim permisoLectura As Boolean

        Ofichero.Multiselect = False
        Ofichero.Title = "Selección fichero"

        OResultado = Ofichero.ShowDialog()

        infofile = New System.IO.FileInfo(Ofichero.FileName)

        fs = New FileStream(Ofichero.FileName, FileMode.Open)
        permisoLectura = fs.CanRead()
        fs.Close()

        If permisoLectura = False Then
            MsgBox("No se puede acceder al archivo elegido.")
            Return
        End If

        If OResultado = DialogResult.OK Then
            TBEntrada.Text = Ofichero.FileName
        End If

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim Codigo As New UnicodeEncoding()
        Dim bHash() As Byte

        Dim Md5 As New MD5CryptoServiceProvider()
        Dim SHA1 As New SHA1Managed()
        Dim SHA256 As New SHA256Managed()
        Dim SHA384 As New SHA384Managed()
        Dim SHA512 As New SHA512Managed()

        Dim archivoStream As FileStream
        Dim OArchivo As FileInfo

        If TBEntrada.Text = "" Then
            If RBTexto.Checked = True Then
                MsgBox("No se ha introducido texto que codificar.")
            Else
                MsgBox("No se ha seleccionado ningún archivo.")
            End If
            Exit Sub
        End If

        If RBTexto.Checked = True Then
            bHash = Md5.ComputeHash(Codigo.GetBytes(TBEntrada.Text))
            TextBox1.Text = Convert.ToBase64String(bHash)
            bHash = SHA1.ComputeHash(Codigo.GetBytes(TBEntrada.Text))
            TextBox2.Text = Convert.ToBase64String(bHash)
            bHash = SHA256.ComputeHash(Codigo.GetBytes(TBEntrada.Text))
            TextBox3.Text = Convert.ToBase64String(bHash)
            bHash = SHA384.ComputeHash(Codigo.GetBytes(TBEntrada.Text))
            TextBox4.Text = Convert.ToBase64String(bHash)
            bHash = SHA512.ComputeHash(Codigo.GetBytes(TBEntrada.Text))
            TextBox5.Text = Convert.ToBase64String(bHash)
        Else
            If File.Exists(TBEntrada.Text) = False Then
                MsgBox("El archivo seleccionado no exite.")
                Exit Sub
            End If

            OArchivo = New FileInfo(TBEntrada.Text)
            archivoStream = OArchivo.Open(FileMode.Open)
            archivoStream.Position = 0
            bHash = Md5.ComputeHash(archivoStream)
            TextBox1.Text = Convert.ToBase64String(bHash)
            bHash = SHA1.ComputeHash(archivoStream)
            TextBox2.Text = Convert.ToBase64String(bHash)
            bHash = SHA256.ComputeHash(archivoStream)
            TextBox3.Text = Convert.ToBase64String(bHash)
            bHash = SHA384.ComputeHash(archivoStream)
            TextBox4.Text = Convert.ToBase64String(bHash)
            bHash = SHA512.ComputeHash(archivoStream)
            TextBox5.Text = Convert.ToBase64String(bHash)
            archivoStream.Close()

        End If
    End Sub
End Class
