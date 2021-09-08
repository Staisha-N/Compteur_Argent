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
        Me.lblMonnaie = New System.Windows.Forms.Label()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.btnAdditionner = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.txtNickels = New System.Windows.Forms.TextBox()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMonnaie
        '
        Me.lblMonnaie.AutoSize = True
        Me.lblMonnaie.Location = New System.Drawing.Point(22, 288)
        Me.lblMonnaie.Name = "lblMonnaie"
        Me.lblMonnaie.Size = New System.Drawing.Size(27, 20)
        Me.lblMonnaie.TabIndex = 0
        Me.lblMonnaie.Text = "---"
        '
        'txtQuarters
        '
        Me.txtQuarters.Location = New System.Drawing.Point(106, 45)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.Size = New System.Drawing.Size(76, 27)
        Me.txtQuarters.TabIndex = 1
        '
        'btnAdditionner
        '
        Me.btnAdditionner.Location = New System.Drawing.Point(314, 84)
        Me.btnAdditionner.Name = "btnAdditionner"
        Me.btnAdditionner.Size = New System.Drawing.Size(143, 105)
        Me.btnAdditionner.TabIndex = 2
        Me.btnAdditionner.Text = "Additionner la monnaie"
        Me.btnAdditionner.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPennies)
        Me.GroupBox1.Controls.Add(Me.lblNickels)
        Me.GroupBox1.Controls.Add(Me.lblDimes)
        Me.GroupBox1.Controls.Add(Me.lblQuarters)
        Me.GroupBox1.Controls.Add(Me.txtPennies)
        Me.GroupBox1.Controls.Add(Me.txtNickels)
        Me.GroupBox1.Controls.Add(Me.txtDimes)
        Me.GroupBox1.Controls.Add(Me.txtQuarters)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 219)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quantité de pièces de monnaie"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(21, 174)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(62, 20)
        Me.lblPennies.TabIndex = 8
        Me.lblPennies.Text = "1 cents :"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(21, 133)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(62, 20)
        Me.lblNickels.TabIndex = 7
        Me.lblNickels.Text = "5 cents :"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(13, 91)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(70, 20)
        Me.lblDimes.TabIndex = 6
        Me.lblDimes.Text = "10 cents :"
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(13, 52)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(70, 20)
        Me.lblQuarters.TabIndex = 5
        Me.lblQuarters.Text = "25 cents :"
        '
        'txtPennies
        '
        Me.txtPennies.Location = New System.Drawing.Point(106, 174)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(76, 27)
        Me.txtPennies.TabIndex = 4
        '
        'txtNickels
        '
        Me.txtNickels.Location = New System.Drawing.Point(106, 130)
        Me.txtNickels.Name = "txtNickels"
        Me.txtNickels.Size = New System.Drawing.Size(76, 27)
        Me.txtNickels.TabIndex = 3
        '
        'txtDimes
        '
        Me.txtDimes.Location = New System.Drawing.Point(106, 91)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.Size = New System.Drawing.Size(76, 27)
        Me.txtDimes.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 346)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdditionner)
        Me.Controls.Add(Me.lblMonnaie)
        Me.Name = "Form1"
        Me.Text = "Compteur de monnaie (S. Neville)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMonnaie As Label
    Friend WithEvents txtQuarters As TextBox
    Friend WithEvents btnAdditionner As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPennies As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents txtPennies As TextBox
    Friend WithEvents txtNickels As TextBox
    Friend WithEvents txtDimes As TextBox
End Class
