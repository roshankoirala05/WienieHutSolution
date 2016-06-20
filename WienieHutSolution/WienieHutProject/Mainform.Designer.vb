<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nchilllabel
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
        Me.calculatebutton = New System.Windows.Forms.Button()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.nchiliabel = New System.Windows.Forms.Label()
        Me.nfrieslabel = New System.Windows.Forms.Label()
        Me.nbeerslabel = New System.Windows.Forms.Label()
        Me.nchilitextbox = New System.Windows.Forms.TextBox()
        Me.nfriestextbox = New System.Windows.Forms.TextBox()
        Me.ndrinkstextbox = New System.Windows.Forms.TextBox()
        Me.Totalcostoffood = New System.Windows.Forms.Label()
        Me.Totaltax = New System.Windows.Forms.Label()
        Me.grandtotal = New System.Windows.Forms.Label()
        Me.grandtotallabel = New System.Windows.Forms.Label()
        Me.totaltaxlabel = New System.Windows.Forms.Label()
        Me.costoffoodlabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calculatebutton
        '
        Me.calculatebutton.Location = New System.Drawing.Point(32, 194)
        Me.calculatebutton.Name = "calculatebutton"
        Me.calculatebutton.Size = New System.Drawing.Size(97, 20)
        Me.calculatebutton.TabIndex = 0
        Me.calculatebutton.Text = "Calculate "
        Me.calculatebutton.UseVisualStyleBackColor = True
        '
        'clearbutton
        '
        Me.clearbutton.Location = New System.Drawing.Point(206, 194)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(112, 20)
        Me.clearbutton.TabIndex = 1
        Me.clearbutton.Text = "Clear"
        Me.clearbutton.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(389, 194)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(112, 20)
        Me.exitbutton.TabIndex = 2
        Me.exitbutton.Text = "Exit"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'nchiliabel
        '
        Me.nchiliabel.AutoSize = True
        Me.nchiliabel.Location = New System.Drawing.Point(7, 41)
        Me.nchiliabel.Name = "nchiliabel"
        Me.nchiliabel.Size = New System.Drawing.Size(150, 13)
        Me.nchiliabel.TabIndex = 3
        Me.nchiliabel.Text = "Enter the number of Chili Dogs"
        '
        'nfrieslabel
        '
        Me.nfrieslabel.AutoSize = True
        Me.nfrieslabel.Location = New System.Drawing.Point(7, 74)
        Me.nfrieslabel.Name = "nfrieslabel"
        Me.nfrieslabel.Size = New System.Drawing.Size(122, 13)
        Me.nfrieslabel.TabIndex = 4
        Me.nfrieslabel.Text = "Enter the number of fries"
        '
        'nbeerslabel
        '
        Me.nbeerslabel.AutoSize = True
        Me.nbeerslabel.Location = New System.Drawing.Point(7, 103)
        Me.nbeerslabel.Name = "nbeerslabel"
        Me.nbeerslabel.Size = New System.Drawing.Size(134, 13)
        Me.nbeerslabel.TabIndex = 5
        Me.nbeerslabel.Text = "Enter the number of drinks "
        '
        'nchilitextbox
        '
        Me.nchilitextbox.Location = New System.Drawing.Point(163, 38)
        Me.nchilitextbox.Name = "nchilitextbox"
        Me.nchilitextbox.Size = New System.Drawing.Size(54, 20)
        Me.nchilitextbox.TabIndex = 6
        '
        'nfriestextbox
        '
        Me.nfriestextbox.Location = New System.Drawing.Point(163, 71)
        Me.nfriestextbox.Name = "nfriestextbox"
        Me.nfriestextbox.Size = New System.Drawing.Size(54, 20)
        Me.nfriestextbox.TabIndex = 7
        '
        'ndrinkstextbox
        '
        Me.ndrinkstextbox.Location = New System.Drawing.Point(163, 103)
        Me.ndrinkstextbox.Name = "ndrinkstextbox"
        Me.ndrinkstextbox.Size = New System.Drawing.Size(54, 20)
        Me.ndrinkstextbox.TabIndex = 8
        '
        'Totalcostoffood
        '
        Me.Totalcostoffood.AccessibleDescription = "totaltax"
        Me.Totalcostoffood.AutoSize = True
        Me.Totalcostoffood.Location = New System.Drawing.Point(287, 41)
        Me.Totalcostoffood.Name = "Totalcostoffood"
        Me.Totalcostoffood.Size = New System.Drawing.Size(94, 13)
        Me.Totalcostoffood.TabIndex = 9
        Me.Totalcostoffood.Text = "Total Cost of Food"
        '
        'Totaltax
        '
        Me.Totaltax.AutoSize = True
        Me.Totaltax.Location = New System.Drawing.Point(329, 71)
        Me.Totaltax.Name = "Totaltax"
        Me.Totaltax.Size = New System.Drawing.Size(52, 13)
        Me.Totaltax.TabIndex = 10
        Me.Totaltax.Text = "Total Tax"
        '
        'grandtotal
        '
        Me.grandtotal.AutoSize = True
        Me.grandtotal.Location = New System.Drawing.Point(318, 103)
        Me.grandtotal.Name = "grandtotal"
        Me.grandtotal.Size = New System.Drawing.Size(63, 13)
        Me.grandtotal.TabIndex = 11
        Me.grandtotal.Text = "Grand Total"
        '
        'grandtotallabel
        '
        Me.grandtotallabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grandtotallabel.Location = New System.Drawing.Point(414, 95)
        Me.grandtotallabel.Name = "grandtotallabel"
        Me.grandtotallabel.Size = New System.Drawing.Size(102, 21)
        Me.grandtotallabel.TabIndex = 12
        '
        'totaltaxlabel
        '
        Me.totaltaxlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totaltaxlabel.Location = New System.Drawing.Point(414, 63)
        Me.totaltaxlabel.Name = "totaltaxlabel"
        Me.totaltaxlabel.Size = New System.Drawing.Size(102, 21)
        Me.totaltaxlabel.TabIndex = 13
        '
        'costoffoodlabel
        '
        Me.costoffoodlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.costoffoodlabel.Location = New System.Drawing.Point(414, 33)
        Me.costoffoodlabel.Name = "costoffoodlabel"
        Me.costoffoodlabel.Size = New System.Drawing.Size(102, 21)
        Me.costoffoodlabel.TabIndex = 14
        '
        'nchilllabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 226)
        Me.Controls.Add(Me.costoffoodlabel)
        Me.Controls.Add(Me.totaltaxlabel)
        Me.Controls.Add(Me.grandtotallabel)
        Me.Controls.Add(Me.grandtotal)
        Me.Controls.Add(Me.Totaltax)
        Me.Controls.Add(Me.Totalcostoffood)
        Me.Controls.Add(Me.ndrinkstextbox)
        Me.Controls.Add(Me.nfriestextbox)
        Me.Controls.Add(Me.nchilitextbox)
        Me.Controls.Add(Me.nbeerslabel)
        Me.Controls.Add(Me.nfrieslabel)
        Me.Controls.Add(Me.nchiliabel)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.calculatebutton)
        Me.Name = "nchilllabel"
        Me.Text = "Wild Wienie Hut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculatebutton As System.Windows.Forms.Button
    Friend WithEvents clearbutton As System.Windows.Forms.Button
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents nchiliabel As System.Windows.Forms.Label
    Friend WithEvents nfrieslabel As System.Windows.Forms.Label
    Friend WithEvents nbeerslabel As System.Windows.Forms.Label
    Friend WithEvents nchilitextbox As System.Windows.Forms.TextBox
    Friend WithEvents nfriestextbox As System.Windows.Forms.TextBox
    Friend WithEvents ndrinkstextbox As System.Windows.Forms.TextBox
    Friend WithEvents Totalcostoffood As System.Windows.Forms.Label
    Friend WithEvents Totaltax As System.Windows.Forms.Label
    Friend WithEvents grandtotal As System.Windows.Forms.Label
    Friend WithEvents grandtotallabel As System.Windows.Forms.Label
    Friend WithEvents totaltaxlabel As System.Windows.Forms.Label
    Friend WithEvents costoffoodlabel As System.Windows.Forms.Label

End Class
