<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataView1 = New DataGridView()
        LabelEstado = New TextBox()
        CType(DataView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataView1
        ' 
        DataView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataView1.Location = New Point(354, 51)
        DataView1.Name = "DataView1"
        DataView1.RowTemplate.Height = 25
        DataView1.Size = New Size(240, 150)
        DataView1.TabIndex = 0
        ' 
        ' LabelEstado
        ' 
        LabelEstado.Location = New Point(12, 236)
        LabelEstado.Name = "LabelEstado"
        LabelEstado.Size = New Size(857, 23)
        LabelEstado.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(897, 280)
        Controls.Add(LabelEstado)
        Controls.Add(DataView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataView1 As DataGridView
    Friend WithEvents LabelEstado As TextBox
End Class
