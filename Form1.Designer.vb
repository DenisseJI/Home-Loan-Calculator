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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HomeValue = New System.Windows.Forms.TextBox()
        Me.Interest = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MonthlyAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DownPayment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LoanTerm = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tax = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.YearlyAmount = New System.Windows.Forms.TextBox()
        Me.DownPaymentAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PropertyTaxAmount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Down Payment:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Interest Rate:"
        '
        'HomeValue
        '
        Me.HomeValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeValue.Location = New System.Drawing.Point(257, 59)
        Me.HomeValue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HomeValue.Name = "HomeValue"
        Me.HomeValue.Size = New System.Drawing.Size(100, 26)
        Me.HomeValue.TabIndex = 3
        '
        'Interest
        '
        Me.Interest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Interest.Location = New System.Drawing.Point(257, 182)
        Me.Interest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Interest.Name = "Interest"
        Me.Interest.Size = New System.Drawing.Size(100, 26)
        Me.Interest.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(177, 385)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 63)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Compute"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 501)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Monthly Payment:"
        '
        'MonthlyAmount
        '
        Me.MonthlyAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyAmount.Location = New System.Drawing.Point(328, 501)
        Me.MonthlyAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MonthlyAmount.Name = "MonthlyAmount"
        Me.MonthlyAmount.ReadOnly = True
        Me.MonthlyAmount.Size = New System.Drawing.Size(100, 26)
        Me.MonthlyAmount.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(357, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "$"
        '
        'DownPayment
        '
        Me.DownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownPayment.Location = New System.Drawing.Point(257, 121)
        Me.DownPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DownPayment.Name = "DownPayment"
        Me.DownPayment.Size = New System.Drawing.Size(100, 26)
        Me.DownPayment.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(357, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(357, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(113, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Loan Term:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(131, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "(yearly)"
        '
        'LoanTerm
        '
        Me.LoanTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanTerm.Location = New System.Drawing.Point(257, 306)
        Me.LoanTerm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LoanTerm.Name = "LoanTerm"
        Me.LoanTerm.Size = New System.Drawing.Size(100, 26)
        Me.LoanTerm.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(364, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "years"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(93, 241)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 20)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Property Tax:"
        '
        'Tax
        '
        Me.Tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tax.Location = New System.Drawing.Point(257, 241)
        Me.Tax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(100, 26)
        Me.Tax.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(357, 245)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "%"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(71, 575)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 20)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Total Yearly Payment:"
        '
        'YearlyAmount
        '
        Me.YearlyAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearlyAmount.Location = New System.Drawing.Point(328, 571)
        Me.YearlyAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.YearlyAmount.Name = "YearlyAmount"
        Me.YearlyAmount.ReadOnly = True
        Me.YearlyAmount.Size = New System.Drawing.Size(100, 26)
        Me.YearlyAmount.TabIndex = 23
        '
        'DownPaymentAmount
        '
        Me.DownPaymentAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownPaymentAmount.Location = New System.Drawing.Point(395, 121)
        Me.DownPaymentAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DownPaymentAmount.Name = "DownPaymentAmount"
        Me.DownPaymentAmount.ReadOnly = True
        Me.DownPaymentAmount.Size = New System.Drawing.Size(100, 26)
        Me.DownPaymentAmount.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(501, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(435, 505)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(435, 578)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 20)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "$"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(112, 11)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(285, 29)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Home Loan Calculator"
        '
        'PropertyTaxAmount
        '
        Me.PropertyTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertyTaxAmount.Location = New System.Drawing.Point(387, 242)
        Me.PropertyTaxAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PropertyTaxAmount.Name = "PropertyTaxAmount"
        Me.PropertyTaxAmount.ReadOnly = True
        Me.PropertyTaxAmount.Size = New System.Drawing.Size(100, 26)
        Me.PropertyTaxAmount.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(493, 245)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 20)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 714)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PropertyTaxAmount)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DownPaymentAmount)
        Me.Controls.Add(Me.YearlyAmount)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Tax)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LoanTerm)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DownPayment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MonthlyAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Interest)
        Me.Controls.Add(Me.HomeValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HomeValue As TextBox
    Friend WithEvents Interest As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents MonthlyAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DownPayment As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LoanTerm As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Tax As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents YearlyAmount As TextBox
    Friend WithEvents DownPaymentAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PropertyTaxAmount As TextBox
    Friend WithEvents Label18 As Label
End Class
