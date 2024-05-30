Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports OfficeOpenXml
Imports Xceed.Words.NET

Public Class Form1
    ' Propiedades privadas
    Private _nombre As String
    Private _edad As Integer
    Private _direccion As String

    ' Propiedad solo lectora
    Public ReadOnly Property Nombre As String
        Get
            Return _nombre
        End Get
    End Property

    ' Propiedad solo escritura
    Public WriteOnly Property Edad As Integer
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    ' Propiedad de lectura y escritura
    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    ' Constructor sin parámetros
    Public Sub New()
        InitializeComponent()

        ' Inicializar propiedades
        _nombre = "Desconocido"
        _edad = 0
        _direccion = "Desconocida"

        ' Inicializar componentes
        InicializarComponentes()
    End Sub

    ' Constructor con parámetros
    Public Sub New(nombre As String, edad As Integer, direccion As String)
        InitializeComponent()

        ' Inicializar propiedades
        _nombre = nombre
        _edad = edad
        _direccion = direccion

        ' Inicializar componentes
        InicializarComponentes()
    End Sub

    ' Método estático
    Public Shared Sub Saludar()
        Console.WriteLine("Hola!")
    End Sub

    ' Método que no recibe parámetros ni regresa nada
    Public Sub MostrarInformacion()
        Console.WriteLine($"Nombre: {_nombre}, Edad: {_edad}, Dirección: {_direccion}")
    End Sub

    ' Método que recibe parámetros pero no regresa nada
    Public Sub ActualizarEdad(nuevaEdad As Integer)
        _edad = nuevaEdad
    End Sub

    ' Método que no recibe parámetros pero regresa algo
    Public Function ObtenerNombre() As String
        Return _nombre
    End Function

    ' Método que recibe parámetros y regresa algo
    Public Function ObtenerDetalle(completo As Boolean) As String
        If completo Then
            Return $"Nombre: {_nombre}, Edad: {_edad}, Dirección: {_direccion}"
        Else
            Return _nombre
        End If
    End Function

    ' Control de excepciones en tiempo de ejecución
    Public Sub LeerArchivo(path As String)
        Try
            Dim contenido As String = File.ReadAllText(path)
            Console.WriteLine(contenido)
        Catch ex As Exception
            Console.WriteLine($"Error leyendo el archivo: {ex.Message}")
        End Try
    End Sub

    ' Archivos usando diálogos - Lectura de un TXT
    Public Sub LeerTXT()
        Dim openFileDialog As New OpenFileDialog
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim contenido As String = File.ReadAllText(openFileDialog.FileName)
                Console.WriteLine(contenido)
            Catch ex As Exception
                Console.WriteLine($"Error leyendo el archivo: {ex.Message}")
            End Try
        End If
    End Sub

    ' Archivos usando diálogos - Escritura de un TXT
    Public Sub EscribirTXT()
        Dim saveFileDialog As New SaveFileDialog
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                File.WriteAllText(saveFileDialog.FileName, "Contenido de ejemplo")
                Console.WriteLine("Archivo guardado exitosamente.")
            Catch ex As Exception
                Console.WriteLine($"Error escribiendo el archivo: {ex.Message}")
            End Try
        End If
    End Sub

    ' Exportar DOCX
    Public Sub ExportarDOCX()
        Dim saveFileDialog As New SaveFileDialog
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim doc As DocX = DocX.Create(saveFileDialog.FileName)
            doc.InsertParagraph("Contenido de ejemplo para DOCX.")
            doc.Save()
            Console.WriteLine("Archivo DOCX guardado exitosamente.")
        End If
    End Sub

    ' Exportar XLSX
    Public Sub ExportarXLSX()
        Dim saveFileDialog As New SaveFileDialog
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Using package As New ExcelPackage(New FileInfo(saveFileDialog.FileName))
                Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Hoja1")
                worksheet.Cells(1, 1).Value = "Contenido de ejemplo para XLSX."
                package.Save()
                Console.WriteLine("Archivo XLSX guardado exitosamente.")
            End Using
        End If
    End Sub

    ' Exportar XML
    Public Sub ExportarXML()
        Dim saveFileDialog As New SaveFileDialog
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim xmlSerializer As New XmlSerializer(GetType(Form1))
            Using stream As New FileStream(saveFileDialog.FileName, FileMode.Create)
                xmlSerializer.Serialize(stream, Me)
                Console.WriteLine("Archivo XML guardado exitosamente.")
            End Using
        End If
    End Sub

    ' Exportar JSON
    Public Sub ExportarJSON()
        Dim saveFileDialog As New SaveFileDialog
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim json As String = JsonConvert.SerializeObject(Me)
            File.WriteAllText(saveFileDialog.FileName, json)
            Console.WriteLine("Archivo JSON guardado exitosamente.")
        End If
    End Sub

    Private Sub btnLeerTXT_Click(sender As Object, e As EventArgs) Handles btnLeerTXT.Click
        LeerTXT()
    End Sub
    Private Sub btnEscribirTXT_Click_1(sender As Object, e As EventArgs) Handles btnEscribirTXT.Click
        EscribirTXT()
    End Sub

    Private Sub btnExportarDOCX_Click(sender As Object, e As EventArgs) Handles btnExportarDOCX.Click
        ExportarDOCX()
    End Sub

    Private Sub btnExportarXLSX_Click(sender As Object, e As EventArgs) Handles btnExportarXLSX.Click
        ExportarXLSX()
    End Sub

    Private Sub btnExportarXML_Click(sender As Object, e As EventArgs) Handles btnExportarXML.Click
        ExportarXML()
    End Sub

    Private Sub btnExportarJSON_Click(sender As Object, e As EventArgs) Handles btnExportarJSON.Click
        ExportarJSON()
    End Sub

    ' Método para inicializar los componentes del formulario
    Private Sub InicializarComponentes()
        Me.btnLeerTXT = New Button() With {.Text = "Leer TXT"}
        Me.btnEscribirTXT = New Button() With {.Text = "Escribir TXT"}
        Me.btnExportarDOCX = New Button() With {.Text = "Exportar DOCX"}
        Me.btnExportarXLSX = New Button() With {.Text = "Exportar XLSX"}
        Me.btnExportarXML = New Button() With {.Text = "Exportar XML"}
        Me.btnExportarJSON = New Button() With {.Text = "Exportar JSON"}

        ' Agregar los botones al formulario
        Me.Controls.Add(btnLeerTXT)
        Me.Controls.Add(btnEscribirTXT)
        Me.Controls.Add(btnExportarDOCX)
        Me.Controls.Add(btnExportarXLSX)
        Me.Controls.Add(btnExportarXML)
        Me.Controls.Add(btnExportarJSON)



        ' Posicionar los botones en el formulario
        Dim buttons = New Button() {btnLeerTXT, btnEscribirTXT, btnExportarDOCX, btnExportarXLSX, btnExportarXML, btnExportarJSON}
        Dim yPosition As Integer = 20
        For Each btn As Button In buttons
            btn.Top = yPosition
            btn.Left = 20
            yPosition += 40
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLeerTXT.Click

    End Sub


End Class