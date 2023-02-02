<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProject
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
        Me.lstDOO = New System.Windows.Forms.ListBox()
        Me.chkApple = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkTuna = New System.Windows.Forms.CheckBox()
        Me.grpSSI = New System.Windows.Forms.GroupBox()
        Me.lblTunaPrice = New System.Windows.Forms.Label()
        Me.lblHamPrice = New System.Windows.Forms.Label()
        Me.lblTomatoPrice = New System.Windows.Forms.Label()
        Me.lblLettucePrice = New System.Windows.Forms.Label()
        Me.lblApplePrice = New System.Windows.Forms.Label()
        Me.grpCOI = New System.Windows.Forms.GroupBox()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.NUD1 = New System.Windows.Forms.NumericUpDown()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblamt = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpSB = New System.Windows.Forms.GroupBox()
        Me.lblHO = New System.Windows.Forms.Label()
        Me.lblGW = New System.Windows.Forms.Label()
        Me.radHO = New System.Windows.Forms.RadioButton()
        Me.radGW = New System.Windows.Forms.RadioButton()
        Me.lstHist = New System.Windows.Forms.ListBox()
        Me.lblHist = New System.Windows.Forms.Label()
        Me.lblNameFind = New System.Windows.Forms.Label()
        Me.txtNameFind = New System.Windows.Forms.TextBox()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.grpAS = New System.Windows.Forms.GroupBox()
        Me.txtLargest = New System.Windows.Forms.TextBox()
        Me.txtAvg = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnCA = New System.Windows.Forms.Button()
        Me.btnMPI = New System.Windows.Forms.Button()
        Me.lblLS = New System.Windows.Forms.Label()
        Me.lblavg = New System.Windows.Forms.Label()
        Me.lblTS = New System.Windows.Forms.Label()
        Me.lblNO = New System.Windows.Forms.Label()
        Me.btnZH_HK = New System.Windows.Forms.Button()
        Me.grpSSI.SuspendLayout()
        Me.grpCOI.SuspendLayout()
        CType(Me.NUD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSB.SuspendLayout()
        Me.grpAS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstDOO
        '
        Me.lstDOO.AllowDrop = True
        Me.lstDOO.BackColor = System.Drawing.SystemColors.Info
        Me.lstDOO.FormattingEnabled = True
        'create a window application that contains all the fields/controls
        Me.lstDOO.Items.AddRange(New Object() {"Discount Offered per Order:", "10.00% discount if order amount >= $100.00"})
        Me.lstDOO.Location = New System.Drawing.Point(189, 12)
        Me.lstDOO.Name = "lstDOO"
        Me.lstDOO.Size = New System.Drawing.Size(299, 56)
        Me.lstDOO.TabIndex = 0
        '
        'chkApple
        '
        Me.chkApple.AutoSize = True
        Me.chkApple.Location = New System.Drawing.Point(0, 20)
        Me.chkApple.Name = "chkApple"
        Me.chkApple.Size = New System.Drawing.Size(62, 17)
        Me.chkApple.TabIndex = 1
        Me.chkApple.Text = "Apple --"
        Me.chkApple.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(0, 42)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(71, 17)
        Me.chkLettuce.TabIndex = 2
        Me.chkLettuce.Text = "Lettuce --"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(0, 65)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(71, 17)
        Me.chkTomato.TabIndex = 3
        Me.chkTomato.Text = "Tomato --"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(0, 88)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(57, 17)
        Me.chkHam.TabIndex = 4
        Me.chkHam.Text = "Ham --"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkTuna
        '
        Me.chkTuna.AutoSize = True
        Me.chkTuna.Location = New System.Drawing.Point(0, 111)
        Me.chkTuna.Name = "chkTuna"
        Me.chkTuna.Size = New System.Drawing.Size(60, 17)
        Me.chkTuna.TabIndex = 5
        Me.chkTuna.Text = "Tuna --"
        Me.chkTuna.UseVisualStyleBackColor = True
        '
        'grpSSI
        '
        Me.grpSSI.Controls.Add(Me.lblTunaPrice)
        Me.grpSSI.Controls.Add(Me.lblHamPrice)
        Me.grpSSI.Controls.Add(Me.lblTomatoPrice)
        Me.grpSSI.Controls.Add(Me.lblLettucePrice)
        Me.grpSSI.Controls.Add(Me.lblApplePrice)
        Me.grpSSI.Controls.Add(Me.chkApple)
        Me.grpSSI.Controls.Add(Me.chkHam)
        Me.grpSSI.Controls.Add(Me.chkTuna)
        Me.grpSSI.Controls.Add(Me.chkLettuce)
        Me.grpSSI.Controls.Add(Me.chkTomato)
        Me.grpSSI.Location = New System.Drawing.Point(6, 20)
        Me.grpSSI.Name = "grpSSI"
        Me.grpSSI.Size = New System.Drawing.Size(225, 137)
        Me.grpSSI.TabIndex = 6
        Me.grpSSI.TabStop = False
        Me.grpSSI.Text = "Selection of Salad Ingredients"
        '
        'lblTunaPrice
        '
        Me.lblTunaPrice.AutoSize = True
        Me.lblTunaPrice.Location = New System.Drawing.Point(60, 112)
        Me.lblTunaPrice.Name = "lblTunaPrice"
        Me.lblTunaPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblTunaPrice.TabIndex = 27
        '
        'lblHamPrice
        '
        Me.lblHamPrice.AutoSize = True
        Me.lblHamPrice.Location = New System.Drawing.Point(48, 89)
        Me.lblHamPrice.Name = "lblHamPrice"
        Me.lblHamPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblHamPrice.TabIndex = 26
        '
        'lblTomatoPrice
        '
        Me.lblTomatoPrice.AutoSize = True
        Me.lblTomatoPrice.Location = New System.Drawing.Point(60, 66)
        Me.lblTomatoPrice.Name = "lblTomatoPrice"
        Me.lblTomatoPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblTomatoPrice.TabIndex = 25
        '
        'lblLettucePrice
        '
        Me.lblLettucePrice.AutoSize = True
        Me.lblLettucePrice.Location = New System.Drawing.Point(60, 46)
        Me.lblLettucePrice.Name = "lblLettucePrice"
        Me.lblLettucePrice.Size = New System.Drawing.Size(0, 13)
        Me.lblLettucePrice.TabIndex = 24
        '
        'lblApplePrice
        '
        Me.lblApplePrice.AutoSize = True
        Me.lblApplePrice.Location = New System.Drawing.Point(60, 22)
        Me.lblApplePrice.Name = "lblApplePrice"
        Me.lblApplePrice.Size = New System.Drawing.Size(0, 13)
        Me.lblApplePrice.TabIndex = 23
        '
        'grpCOI
        '
        Me.grpCOI.Controls.Add(Me.txtAmt)
        Me.grpCOI.Controls.Add(Me.NUD1)
        Me.grpCOI.Controls.Add(Me.btnClear)
        Me.grpCOI.Controls.Add(Me.btnConfirm)
        Me.grpCOI.Controls.Add(Me.lblamt)
        Me.grpCOI.Controls.Add(Me.lblQty)
        Me.grpCOI.Controls.Add(Me.lblCustomer)
        Me.grpCOI.Controls.Add(Me.txtName)
        Me.grpCOI.Controls.Add(Me.grpSB)
        Me.grpCOI.Controls.Add(Me.grpSSI)
        Me.grpCOI.Location = New System.Drawing.Point(12, 74)
        Me.grpCOI.Name = "grpCOI"
        Me.grpCOI.Size = New System.Drawing.Size(600, 166)
        Me.grpCOI.TabIndex = 6
        Me.grpCOI.TabStop = False
        Me.grpCOI.Text = "Current Order Information"
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(504, 36)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.ReadOnly = True
        Me.txtAmt.Size = New System.Drawing.Size(90, 20)
        Me.txtAmt.TabIndex = 17
        '
        'NUD1
        '
        Me.NUD1.Location = New System.Drawing.Point(325, 106)
        Me.NUD1.Name = "NUD1"
        Me.NUD1.Size = New System.Drawing.Size(106, 20)
        Me.NUD1.TabIndex = 16
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(519, 131)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear order"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(440, 133)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Location = New System.Drawing.Point(437, 40)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(56, 13)
        Me.lblamt.TabIndex = 12
        Me.lblamt.Text = "Order amt:"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(240, 109)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(46, 13)
        Me.lblQty.TabIndex = 10
        Me.lblQty.Text = "Quantity"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(240, 137)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(80, 13)
        Me.lblCustomer.TabIndex = 9
        Me.lblCustomer.Text = "Customer name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(326, 134)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(105, 20)
        Me.txtName.TabIndex = 8
        '
        'grpSB
        '
        Me.grpSB.Controls.Add(Me.lblHO)
        Me.grpSB.Controls.Add(Me.lblGW)
        Me.grpSB.Controls.Add(Me.radHO)
        Me.grpSB.Controls.Add(Me.radGW)
        Me.grpSB.Location = New System.Drawing.Point(237, 25)
        Me.grpSB.Name = "grpSB"
        Me.grpSB.Size = New System.Drawing.Size(194, 77)
        Me.grpSB.TabIndex = 7
        Me.grpSB.TabStop = False
        Me.grpSB.Text = "Selection of Bread"
        '
        'lblHO
        '
        Me.lblHO.AutoSize = True
        Me.lblHO.Location = New System.Drawing.Point(86, 44)
        Me.lblHO.Name = "lblHO"
        Me.lblHO.Size = New System.Drawing.Size(0, 13)
        Me.lblHO.TabIndex = 3
        '
        'lblGW
        '
        Me.lblGW.AutoSize = True
        Me.lblGW.Location = New System.Drawing.Point(94, 21)
        Me.lblGW.Name = "lblGW"
        Me.lblGW.Size = New System.Drawing.Size(0, 13)
        Me.lblGW.TabIndex = 2
        '
        'radHO
        '
        Me.radHO.AutoSize = True
        Me.radHO.Location = New System.Drawing.Point(6, 42)
        Me.radHO.Name = "radHO"
        Me.radHO.Size = New System.Drawing.Size(85, 17)
        Me.radHO.TabIndex = 1
        Me.radHO.TabStop = True
        Me.radHO.Text = "Honey Oat --"
        Me.radHO.UseVisualStyleBackColor = True
        '
        'radGW
        '
        Me.radGW.AutoSize = True
        Me.radGW.Location = New System.Drawing.Point(6, 20)
        Me.radGW.Name = "radGW"
        Me.radGW.Size = New System.Drawing.Size(94, 17)
        Me.radGW.TabIndex = 0
        Me.radGW.TabStop = True
        Me.radGW.Text = "Grain Wheat --"
        Me.radGW.UseVisualStyleBackColor = True
        '
        'lstHist
        '
        Me.lstHist.FormattingEnabled = True
        Me.lstHist.Location = New System.Drawing.Point(618, 74)
        Me.lstHist.Name = "lstHist"
        Me.lstHist.Size = New System.Drawing.Size(159, 186)
        Me.lstHist.TabIndex = 7
        '
        'lblHist
        '
        Me.lblHist.AutoSize = True
        Me.lblHist.Location = New System.Drawing.Point(618, 55)
        Me.lblHist.Name = "lblHist"
        Me.lblHist.Size = New System.Drawing.Size(86, 13)
        Me.lblHist.TabIndex = 15
        Me.lblHist.Text = "Customer History"
        '
        'lblNameFind
        '
        Me.lblNameFind.AutoSize = True
        Me.lblNameFind.Location = New System.Drawing.Point(618, 271)
        Me.lblNameFind.Name = "lblNameFind"
        Me.lblNameFind.Size = New System.Drawing.Size(85, 13)
        Me.lblNameFind.TabIndex = 16
        Me.lblNameFind.Text = "Customer Name:"
        '
        'txtNameFind
        '
        Me.txtNameFind.Location = New System.Drawing.Point(618, 293)
        Me.txtNameFind.Name = "txtNameFind"
        Me.txtNameFind.Size = New System.Drawing.Size(82, 20)
        Me.txtNameFind.TabIndex = 15
        '
        'btnfind
        '
        Me.btnfind.Location = New System.Drawing.Point(702, 291)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(75, 23)
        Me.btnfind.TabIndex = 15
        Me.btnfind.Text = "find"
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'grpAS
        '
        Me.grpAS.Controls.Add(Me.txtLargest)
        Me.grpAS.Controls.Add(Me.txtAvg)
        Me.grpAS.Controls.Add(Me.txtTotal)
        Me.grpAS.Controls.Add(Me.txtNum)
        Me.grpAS.Controls.Add(Me.btnCA)
        Me.grpAS.Controls.Add(Me.btnMPI)
        Me.grpAS.Controls.Add(Me.lblLS)
        Me.grpAS.Controls.Add(Me.lblavg)
        Me.grpAS.Controls.Add(Me.lblTS)
        Me.grpAS.Controls.Add(Me.lblNO)
        Me.grpAS.Location = New System.Drawing.Point(12, 246)
        Me.grpAS.Name = "grpAS"
        Me.grpAS.Size = New System.Drawing.Size(600, 79)
        Me.grpAS.TabIndex = 15
        Me.grpAS.TabStop = False
        Me.grpAS.Text = "Accumulated Sales"
        '
        'txtLargest
        '
        Me.txtLargest.Location = New System.Drawing.Point(334, 47)
        Me.txtLargest.Name = "txtLargest"
        Me.txtLargest.ReadOnly = True
        Me.txtLargest.Size = New System.Drawing.Size(100, 20)
        Me.txtLargest.TabIndex = 26
        '
        'txtAvg
        '
        Me.txtAvg.Location = New System.Drawing.Point(334, 18)
        Me.txtAvg.Name = "txtAvg"
        Me.txtAvg.ReadOnly = True
        Me.txtAvg.Size = New System.Drawing.Size(100, 20)
        Me.txtAvg.TabIndex = 25
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(99, 49)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(114, 20)
        Me.txtTotal.TabIndex = 24
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(99, 18)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.ReadOnly = True
        Me.txtNum.Size = New System.Drawing.Size(114, 20)
        Me.txtNum.TabIndex = 23
        '
        'btnCA
        '
        Me.btnCA.Location = New System.Drawing.Point(440, 47)
        Me.btnCA.Name = "btnCA"
        Me.btnCA.Size = New System.Drawing.Size(154, 23)
        Me.btnCA.TabIndex = 22
        Me.btnCA.Text = "Clear Accumulation"
        Me.btnCA.UseVisualStyleBackColor = True
        '
        'btnMPI
        '
        Me.btnMPI.Location = New System.Drawing.Point(440, 15)
        Me.btnMPI.Name = "btnMPI"
        Me.btnMPI.Size = New System.Drawing.Size(154, 23)
        Me.btnMPI.TabIndex = 15
        Me.btnMPI.Text = "Most Popular Ingredient"
        Me.btnMPI.UseVisualStyleBackColor = True
        '
        'lblLS
        '
        Me.lblLS.AutoSize = True
        Me.lblLS.Location = New System.Drawing.Point(240, 54)
        Me.lblLS.Name = "lblLS"
        Me.lblLS.Size = New System.Drawing.Size(71, 13)
        Me.lblLS.TabIndex = 21
        Me.lblLS.Text = "Largest Sales"
        '
        'lblavg
        '
        Me.lblavg.AutoSize = True
        Me.lblavg.Location = New System.Drawing.Point(240, 22)
        Me.lblavg.Name = "lblavg"
        Me.lblavg.Size = New System.Drawing.Size(88, 13)
        Me.lblavg.TabIndex = 20
        Me.lblavg.Text = "Average of Sales"
        '
        'lblTS
        '
        Me.lblTS.AutoSize = True
        Me.lblTS.Location = New System.Drawing.Point(3, 54)
        Me.lblTS.Name = "lblTS"
        Me.lblTS.Size = New System.Drawing.Size(60, 13)
        Me.lblTS.TabIndex = 16
        Me.lblTS.Text = "Total Sales"
        '
        'lblNO
        '
        Me.lblNO.AutoSize = True
        Me.lblNO.Location = New System.Drawing.Point(3, 25)
        Me.lblNO.Name = "lblNO"
        Me.lblNO.Size = New System.Drawing.Size(90, 13)
        Me.lblNO.TabIndex = 15
        Me.lblNO.Text = "Number of Orders"
        '
        'btnZH_HK
        '
        Me.btnZH_HK.Location = New System.Drawing.Point(516, 26)
        Me.btnZH_HK.Name = "btnZH_HK"
        Me.btnZH_HK.Size = New System.Drawing.Size(75, 23)
        Me.btnZH_HK.TabIndex = 17
        Me.btnZH_HK.Text = "ZH_HK"
        Me.btnZH_HK.UseVisualStyleBackColor = True
        '
        'FrmProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 340)
        Me.Controls.Add(Me.btnZH_HK)
        Me.Controls.Add(Me.grpAS)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.txtNameFind)
        Me.Controls.Add(Me.lblNameFind)
        Me.Controls.Add(Me.lblHist)
        Me.Controls.Add(Me.lstHist)
        Me.Controls.Add(Me.grpCOI)
        Me.Controls.Add(Me.lstDOO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmProject"
        Me.Text = "My Cafe"
        Me.grpSSI.ResumeLayout(False)
        Me.grpSSI.PerformLayout()
        Me.grpCOI.ResumeLayout(False)
        Me.grpCOI.PerformLayout()
        CType(Me.NUD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSB.ResumeLayout(False)
        Me.grpSB.PerformLayout()
        Me.grpAS.ResumeLayout(False)
        Me.grpAS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDOO As ListBox
    Friend WithEvents chkApple As CheckBox
    Friend WithEvents chkLettuce As CheckBox
    Friend WithEvents chkTomato As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkTuna As CheckBox
    Friend WithEvents grpSSI As GroupBox
    Friend WithEvents grpCOI As GroupBox
    Friend WithEvents grpSB As GroupBox
    Friend WithEvents radHO As RadioButton
    Friend WithEvents radGW As RadioButton
    Friend WithEvents lstHist As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblamt As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblHist As Label
    Friend WithEvents lblNameFind As Label
    Friend WithEvents txtNameFind As TextBox
    Friend WithEvents btnfind As Button
    Friend WithEvents grpAS As GroupBox
    Friend WithEvents lblTS As Label
    Friend WithEvents lblNO As Label
    Friend WithEvents btnCA As Button
    Friend WithEvents btnMPI As Button
    Friend WithEvents lblLS As Label
    Friend WithEvents lblavg As Label
    Friend WithEvents lblTunaPrice As Label
    Friend WithEvents lblHamPrice As Label
    Friend WithEvents lblTomatoPrice As Label
    Friend WithEvents lblLettucePrice As Label
    Friend WithEvents lblApplePrice As Label
    Friend WithEvents lblHO As Label
    Friend WithEvents lblGW As Label
    Friend WithEvents NUD1 As NumericUpDown
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents txtLargest As TextBox
    Friend WithEvents txtAvg As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnZH_HK As Button

    'ITE3711 Project
    'Class: FS113002N/1D
    'Name: HO Cheuk Hin & LAU Chun Wing
    'Student ID: 210053749 & 210421711

    Private Sub FrmProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When your program is started, it shows the prices of all food types and the discount regulations.
        lblApplePrice.Text = "HK$" & FormatNumber(Appleprice, 2)
        lblLettucePrice.Text = "HK$" & FormatNumber(Lettuceprice, 2)
        lblTomatoPrice.Text = "HK$" & FormatNumber(Tematoprice, 2)
        lblHamPrice.Text = "HK$" & FormatNumber(Hamprice, 2)
        lblTunaPrice.Text = "HK$" & FormatNumber(Tunaprice, 2)
        lblGW.Text = "HK$" & FormatNumber(GWprice, 2)
        lblHO.Text = "HK$" & FormatNumber(HOprice, 2)
        NUD1.Value = 1
        MsgBox("Please ensure to select the language first! 請務必先選擇語言！")
    End Sub

    'When your program is started, it shows the prices of all food types and the discount regulations.
    Const Appleprice As Double = 10.0
    Const Lettuceprice As Double = 12.5
    Const Tematoprice As Double = 8.5
    Const Hamprice As Double = 20.0
    Const Tunaprice As Double = 18.5
    Const GWprice As Double = 8.0
    Const HOprice As Double = 10.5
    Const Discountrate As Double = 10
    Dim NoO As Integer
    Dim total As Double
    Dim max As Double
    Dim applenum, lettucenum, tomatonum, hamnum, tunanum, most As Integer

    Private Sub btnCA_Click(sender As Object, e As EventArgs) Handles btnCA.Click
        'When the user clicks the button "Clear Accumulation", all entries in the group-box "Accumulated Sales", “Customer History” ListBox, “Customer Name” TextBox control next to the Find button are cleared and the respective variables are set to zero or null.
        CA()
    End Sub

    Dim MOI As String = "null"

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        'When the user input the customer name and then click the button “find”, your program can search the customer history record by the customer name.
        Dim L, rew, result As Integer
        For L = 0 To lstHist.Items.Count - 1
            rew = L + 1
            If lstHist.Items(L) = txtNameFind.Text Then
                MsgBox(txtNameFind.Text & " is on line " & rew & " of the list.")
                result = 1
            End If
            If result = 0 And L = lstHist.Items.Count - 1 Then
                MsgBox("Customer not found")
            End If
        Next
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim sum As Double
        If chkApple.Checked = False And chkHam.Checked = False And chkLettuce.Checked = False And chkTomato.Checked = False And chkTuna.Checked = False Then
            'none of the items from the salad ingredients is selected. 
            MsgBox("Please select Salad Ingredients")
        Else
            If radGW.Checked = False And radHO.Checked = False Then
                'none of the items from the bread types is selected. 
                MsgBox("Please select Bread")
            Else
                If NUD1.Value = 0 Then
                    MsgBox("Please enter a Quantity.")
                Else
                    If txtName.Text = "" Then
                        'the customer name is not entered.
                        MsgBox("Please enter the Customer Name.")
                    Else
                        If chkApple.Checked = True Then
                            sum += Appleprice
                            applenum += 1
                        End If
                        If chkLettuce.Checked = True Then
                            sum += Lettuceprice
                            lettucenum += 1
                        End If
                        If chkTomato.Checked = True Then
                            sum += Tematoprice
                            tomatonum += 1
                        End If
                        If chkHam.Checked = True Then
                            sum += Hamprice
                            hamnum += 1
                        End If
                        If chkTuna.Checked = True Then
                            sum += Tunaprice
                            tunanum += 1
                        End If
                        If radGW.Checked = True Then
                            sum += GWprice
                        Else
                            sum += HOprice
                        End If
                        sum = sum * CInt(NUD1.Value)
                        If sum >= 100 Then
                            sum = sum * (1 - Discountrate / 100)
                        End If

                        'display of the order amount and discount offered of the current order
                        txtAmt.Text = "HK$" & FormatNumber(sum, 2)

                        'display the customer name into customer history record
                        lstHist.Items.Add(txtName.Text)

                        'display of the total sales, average of sales, total number of orders, and largest sales in the group-box named "Accumulated Sales".
                        txtNum.Text = lstHist.Items.Count

                        total += sum
                        txtTotal.Text = "HK$" & FormatNumber(total, 2)

                        txtAvg.Text = "HK$" & FormatNumber(total / lstHist.Items.Count, 2)

                        If max < sum Then
                            txtLargest.Text = "HK$" & FormatNumber(sum, 2)
                            max = sum
                            txtLargest.Text = "HK$" & FormatNumber(max, 2)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnZH_HK_Click(sender As Object, e As EventArgs) Handles btnZH_HK.Click
        'Extra/New function is implemented in the project successfully.
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnMPI_Click(sender As Object, e As EventArgs) Handles btnMPI.Click
        'When the user clicks the button "Most Popular Ingredient", your program displays a Message-Box showing the name of the ingredient with largest quantity sold among all ingredients.
        If most = 0 And applenum = 0 And lettucenum = 0 And tomatonum = 0 And hamnum And tunanum = 0 Then
            MsgBox("Please enter data to the Current Order Information Form First ")
        Else
            If most < applenum Then
                most = applenum
                MOI = "Apple"
            End If
            If most < lettucenum Then
                most = lettucenum
                MOI = "Lettuce"
            End If
            If most < tomatonum Then
                most = tomatonum
                MOI = "Tomato"
            End If
            If most < hamnum Then
                most = hamnum
                MOI = "Ham"
            End If
            If most < tunanum Then
                most = tunanum
                MOI = "Tuna"
            End If
            MsgBox("Most Popual Ingredient: " & MOI)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'When the user clicks the button "Clear Order", all entries (including RadioButton, CheckBox, TextBox, and numericUpDown) in the group-box "Current Order Information" are cleared or reset to 1. 
        ClearOrder()
    End Sub
    Sub ClearOrder()
        Me.txtName.Clear()
        Me.txtAmt.Clear()
        chkApple.Checked = False
        chkLettuce.Checked = False
        chkTomato.Checked = False
        chkHam.Checked = False
        chkTuna.Checked = False
        radGW.Checked = False
        radHO.Checked = False
        NUD1.Value = 1
    End Sub
    Sub CA()
        lstHist.Items.Clear()
        txtName.Text = ""
        txtAvg.Text = ""
        txtLargest.Text = ""
        txtNum.Text = ""
        txtTotal.Text = ""
        total = 0
        NoO = 0
        max = 0
    End Sub
End Class
