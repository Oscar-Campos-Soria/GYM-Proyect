<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLeerTXT = New System.Windows.Forms.Button()
        Me.btnEscribirTXT = New System.Windows.Forms.Button()
        Me.btnExportarDOCX = New System.Windows.Forms.Button()
        Me.btnExportarXLSX = New System.Windows.Forms.Button()
        Me.btnExportarXML = New System.Windows.Forms.Button()
        Me.btnExportarJSON = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLeerTXT
        '
        Me.btnLeerTXT.Location = New System.Drawing.Point(157, 55)
        Me.btnLeerTXT.Name = "btnLeerTXT"
        Me.btnLeerTXT.Size = New System.Drawing.Size(146, 29)
        Me.btnLeerTXT.TabIndex = 0
        Me.btnLeerTXT.Text = "btnLeerTXT"
        Me.btnLeerTXT.UseVisualStyleBackColor = True
        '
        'btnEscribirTXT
        '
        Me.btnEscribirTXT.Location = New System.Drawing.Point(157, 20)
        Me.btnEscribirTXT.Name = "btnEscribirTXT"
        Me.btnEscribirTXT.Size = New System.Drawing.Size(146, 29)
        Me.btnEscribirTXT.TabIndex = 1
        Me.btnEscribirTXT.Text = "btnEscribirTXT"
        Me.btnEscribirTXT.UseVisualStyleBackColor = True
        '
        'btnExportarDOCX
        '
        Me.btnExportarDOCX.Location = New System.Drawing.Point(157, 125)
        Me.btnExportarDOCX.Name = "btnExportarDOCX"
        Me.btnExportarDOCX.Size = New System.Drawing.Size(146, 29)
        Me.btnExportarDOCX.TabIndex = 2
        Me.btnExportarDOCX.Text = "btnExportarDOCX"
        Me.btnExportarDOCX.UseVisualStyleBackColor = True
        '
        'btnExportarXLSX
        '
        Me.btnExportarXLSX.Location = New System.Drawing.Point(157, 160)
        Me.btnExportarXLSX.Name = "btnExportarXLSX"
        Me.btnExportarXLSX.Size = New System.Drawing.Size(146, 29)
        Me.btnExportarXLSX.TabIndex = 3
        Me.btnExportarXLSX.Text = "btnExportarXLSX"
        Me.btnExportarXLSX.UseVisualStyleBackColor = True
        '
        'btnExportarXML
        '
        Me.btnExportarXML.Location = New System.Drawing.Point(157, 195)
        Me.btnExportarXML.Name = "btnExportarXML"
        Me.btnExportarXML.Size = New System.Drawing.Size(146, 29)
        Me.btnExportarXML.TabIndex = 4
        Me.btnExportarXML.Text = "btnExportarXML"
        Me.btnExportarXML.UseVisualStyleBackColor = True
        '
        'btnExportarJSON
        '
        Me.btnExportarJSON.Location = New System.Drawing.Point(157, 90)
        Me.btnExportarJSON.Name = "btnExportarJSON"
        Me.btnExportarJSON.Size = New System.Drawing.Size(146, 29)
        Me.btnExportarJSON.TabIndex = 5
        Me.btnExportarJSON.Text = "btnExportarJSON"
        Me.btnExportarJSON.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(343, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 205)
        Me.DataGridView1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExportarJSON)
        Me.Controls.Add(Me.btnExportarXML)
        Me.Controls.Add(Me.btnExportarXLSX)
        Me.Controls.Add(Me.btnExportarDOCX)
        Me.Controls.Add(Me.btnEscribirTXT)
        Me.Controls.Add(Me.btnLeerTXT)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLeerTXT As Button
    Friend WithEvents btnEscribirTXT As Button
    Friend WithEvents btnExportarDOCX As Button
    Friend WithEvents btnExportarXLSX As Button
    Friend WithEvents btnExportarXML As Button
    Friend WithEvents btnExportarJSON As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
