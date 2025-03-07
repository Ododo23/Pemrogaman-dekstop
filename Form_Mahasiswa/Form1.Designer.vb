<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cmbFakultas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.btnProcces = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fakultas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jurusan"
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(210, 75)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(155, 22)
        Me.txtNIP.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(210, 107)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(155, 22)
        Me.txtNama.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.ComboBox1.Location = New System.Drawing.Point(210, 140)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.cmbJurusan.Location = New System.Drawing.Point(210, 170)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(155, 24)
        Me.cmbJurusan.TabIndex = 7
        '
        'btnProcces
        '
        Me.btnProcces.Location = New System.Drawing.Point(52, 236)
        Me.btnProcces.Name = "btnProcces"
        Me.btnProcces.Size = New System.Drawing.Size(75, 23)
        Me.btnProcces.TabIndex = 8
        Me.btnProcces.Text = "Procces"
        Me.btnProcces.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmbFakultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 344)
        Me.Controls.Add(Me.btnProcces)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cmbFakultas"
        Me.Text = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents btnProcces As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

    Private Sub btnProcces_Click(sender As Object, e As EventArgs) Handles btnProcces.Click

        Dim nip As String = txtNIP.Text
        Dim nama As String = txtNama.Text
        Dim fakultas As String = ComboBox1.SelectedItem.ToString()
        Dim jurusan As String = cmbJurusan.SelectedItem.ToString()


        MessageBox.Show("Hai : " & nip & vbCrLf &
                        "Nip : " & nama & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
