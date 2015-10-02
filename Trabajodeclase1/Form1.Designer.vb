<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SumaBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RestaBtn = New System.Windows.Forms.Button()
        Me.MultiplicaBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SumaBtn
        '
        Me.SumaBtn.Location = New System.Drawing.Point(25, 99)
        Me.SumaBtn.Name = "SumaBtn"
        Me.SumaBtn.Size = New System.Drawing.Size(75, 23)
        Me.SumaBtn.TabIndex = 0
        Me.SumaBtn.Text = "Suma"
        Me.SumaBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(25, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(184, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "="
        '
        'RestaBtn
        '
        Me.RestaBtn.Location = New System.Drawing.Point(130, 99)
        Me.RestaBtn.Name = "RestaBtn"
        Me.RestaBtn.Size = New System.Drawing.Size(75, 23)
        Me.RestaBtn.TabIndex = 5
        Me.RestaBtn.Text = "Resta"
        Me.RestaBtn.UseVisualStyleBackColor = True
        '
        'MultiplicaBtn
        '
        Me.MultiplicaBtn.Location = New System.Drawing.Point(25, 128)
        Me.MultiplicaBtn.Name = "MultiplicaBtn"
        Me.MultiplicaBtn.Size = New System.Drawing.Size(75, 23)
        Me.MultiplicaBtn.TabIndex = 6
        Me.MultiplicaBtn.Text = "Multiplica"
        Me.MultiplicaBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 262)
        Me.Controls.Add(Me.MultiplicaBtn)
        Me.Controls.Add(Me.RestaBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SumaBtn)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SumaBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RestaBtn As Button
    Friend WithEvents MultiplicaBtn As Button
End Class
