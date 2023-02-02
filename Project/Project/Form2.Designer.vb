<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.lstDOO = New System.Windows.Forms.ListBox()
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
        Me.lblHOzh = New System.Windows.Forms.Label()
        Me.lblGWzh = New System.Windows.Forms.Label()
        Me.lblHO = New System.Windows.Forms.Label()
        Me.lblGW = New System.Windows.Forms.Label()
        Me.radHO = New System.Windows.Forms.RadioButton()
        Me.radGW = New System.Windows.Forms.RadioButton()
        Me.grpSSI = New System.Windows.Forms.GroupBox()
        Me.lblTunaPricezh = New System.Windows.Forms.Label()
        Me.lblHamPricezh = New System.Windows.Forms.Label()
        Me.lblTomatoPricezh = New System.Windows.Forms.Label()
        Me.lblApplePricezh = New System.Windows.Forms.Label()
        Me.lblLettucePricezh = New System.Windows.Forms.Label()
        Me.lblTunaPrice = New System.Windows.Forms.Label()
        Me.lblHamPrice = New System.Windows.Forms.Label()
        Me.lblTomatoPrice = New System.Windows.Forms.Label()
        Me.lblLettucePrice = New System.Windows.Forms.Label()
        Me.lblApplePrice = New System.Windows.Forms.Label()
        Me.chkApple = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkTuna = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.lblHist = New System.Windows.Forms.Label()
        Me.lstHist = New System.Windows.Forms.ListBox()
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
        Me.lblNameFind = New System.Windows.Forms.Label()
        Me.txtNameFind = New System.Windows.Forms.TextBox()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.btnEN_US = New System.Windows.Forms.Button()
        Me.grpCOI.SuspendLayout()
        CType(Me.NUD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSB.SuspendLayout()
        Me.grpSSI.SuspendLayout()
        Me.grpAS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstDOO
        '
        Me.lstDOO.BackColor = System.Drawing.SystemColors.Info
        Me.lstDOO.FormattingEnabled = True
        Me.lstDOO.Items.AddRange(New Object() {"每個訂單提供的折扣：", "如果訂單金額 >= 100.00 元，可享受 10.00% 的折扣"})
        Me.lstDOO.Location = New System.Drawing.Point(181, 12)
        Me.lstDOO.Name = "lstDOO"
        Me.lstDOO.Size = New System.Drawing.Size(299, 56)
        Me.lstDOO.TabIndex = 1
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
        Me.grpCOI.Location = New System.Drawing.Point(12, 85)
        Me.grpCOI.Name = "grpCOI"
        Me.grpCOI.Size = New System.Drawing.Size(600, 166)
        Me.grpCOI.TabIndex = 7
        Me.grpCOI.TabStop = False
        Me.grpCOI.Text = "當前訂單信息"
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
        Me.btnClear.Location = New System.Drawing.Point(519, 134)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "清除訂單"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(440, 133)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "確認"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Location = New System.Drawing.Point(437, 40)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(61, 13)
        Me.lblamt.TabIndex = 12
        Me.lblamt.Text = "訂購金額："
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(240, 109)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(31, 13)
        Me.lblQty.TabIndex = 10
        Me.lblQty.Text = "數量"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(240, 137)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 13)
        Me.lblCustomer.TabIndex = 9
        Me.lblCustomer.Text = "顧客姓名"
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
        Me.grpSB.Controls.Add(Me.lblHOzh)
        Me.grpSB.Controls.Add(Me.lblGWzh)
        Me.grpSB.Controls.Add(Me.lblHO)
        Me.grpSB.Controls.Add(Me.lblGW)
        Me.grpSB.Controls.Add(Me.radHO)
        Me.grpSB.Controls.Add(Me.radGW)
        Me.grpSB.Location = New System.Drawing.Point(237, 25)
        Me.grpSB.Name = "grpSB"
        Me.grpSB.Size = New System.Drawing.Size(194, 77)
        Me.grpSB.TabIndex = 7
        Me.grpSB.TabStop = False
        Me.grpSB.Text = "麵包的選擇"
        '
        'lblHOzh
        '
        Me.lblHOzh.AutoSize = True
        Me.lblHOzh.Location = New System.Drawing.Point(86, 46)
        Me.lblHOzh.Name = "lblHOzh"
        Me.lblHOzh.Size = New System.Drawing.Size(0, 13)
        Me.lblHOzh.TabIndex = 33
        '
        'lblGWzh
        '
        Me.lblGWzh.AutoSize = True
        Me.lblGWzh.Location = New System.Drawing.Point(86, 22)
        Me.lblGWzh.Name = "lblGWzh"
        Me.lblGWzh.Size = New System.Drawing.Size(0, 13)
        Me.lblGWzh.TabIndex = 32
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
        Me.radHO.Size = New System.Drawing.Size(82, 17)
        Me.radHO.TabIndex = 1
        Me.radHO.TabStop = True
        Me.radHO.Text = "蜂蜜燕麥 --"
        Me.radHO.UseVisualStyleBackColor = True
        '
        'radGW
        '
        Me.radGW.AutoSize = True
        Me.radGW.Location = New System.Drawing.Point(6, 20)
        Me.radGW.Name = "radGW"
        Me.radGW.Size = New System.Drawing.Size(82, 17)
        Me.radGW.TabIndex = 0
        Me.radGW.TabStop = True
        Me.radGW.Text = "穀物小麥 --"
        Me.radGW.UseVisualStyleBackColor = True
        '
        'grpSSI
        '
        Me.grpSSI.Controls.Add(Me.lblTunaPricezh)
        Me.grpSSI.Controls.Add(Me.lblHamPricezh)
        Me.grpSSI.Controls.Add(Me.lblTomatoPricezh)
        Me.grpSSI.Controls.Add(Me.lblApplePricezh)
        Me.grpSSI.Controls.Add(Me.lblLettucePricezh)
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
        Me.grpSSI.Text = "沙拉配料的選擇"
        '
        'lblTunaPricezh
        '
        Me.lblTunaPricezh.AutoSize = True
        Me.lblTunaPricezh.Location = New System.Drawing.Point(65, 114)
        Me.lblTunaPricezh.Name = "lblTunaPricezh"
        Me.lblTunaPricezh.Size = New System.Drawing.Size(0, 13)
        Me.lblTunaPricezh.TabIndex = 31
        '
        'lblHamPricezh
        '
        Me.lblHamPricezh.AutoSize = True
        Me.lblHamPricezh.Location = New System.Drawing.Point(60, 89)
        Me.lblHamPricezh.Name = "lblHamPricezh"
        Me.lblHamPricezh.Size = New System.Drawing.Size(0, 13)
        Me.lblHamPricezh.TabIndex = 30
        '
        'lblTomatoPricezh
        '
        Me.lblTomatoPricezh.AutoSize = True
        Me.lblTomatoPricezh.Location = New System.Drawing.Point(60, 66)
        Me.lblTomatoPricezh.Name = "lblTomatoPricezh"
        Me.lblTomatoPricezh.Size = New System.Drawing.Size(0, 13)
        Me.lblTomatoPricezh.TabIndex = 29
        '
        'lblApplePricezh
        '
        Me.lblApplePricezh.AutoSize = True
        Me.lblApplePricezh.Location = New System.Drawing.Point(60, 21)
        Me.lblApplePricezh.Name = "lblApplePricezh"
        Me.lblApplePricezh.Size = New System.Drawing.Size(0, 13)
        Me.lblApplePricezh.TabIndex = 28
        '
        'lblLettucePricezh
        '
        Me.lblLettucePricezh.AutoSize = True
        Me.lblLettucePricezh.Location = New System.Drawing.Point(60, 43)
        Me.lblLettucePricezh.Name = "lblLettucePricezh"
        Me.lblLettucePricezh.Size = New System.Drawing.Size(0, 13)
        Me.lblLettucePricezh.TabIndex = 28
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
        'chkApple
        '
        Me.chkApple.AutoSize = True
        Me.chkApple.Location = New System.Drawing.Point(0, 20)
        Me.chkApple.Name = "chkApple"
        Me.chkApple.Size = New System.Drawing.Size(62, 17)
        Me.chkApple.TabIndex = 1
        Me.chkApple.Text = "蘋果  --"
        Me.chkApple.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(0, 88)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(59, 17)
        Me.chkHam.TabIndex = 4
        Me.chkHam.Text = "火腿 --"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkTuna
        '
        Me.chkTuna.AutoSize = True
        Me.chkTuna.Location = New System.Drawing.Point(0, 111)
        Me.chkTuna.Name = "chkTuna"
        Me.chkTuna.Size = New System.Drawing.Size(71, 17)
        Me.chkTuna.TabIndex = 5
        Me.chkTuna.Text = "金槍魚 --"
        Me.chkTuna.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(0, 42)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 2
        Me.chkLettuce.Text = "生菜  --"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(0, 65)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(59, 17)
        Me.chkTomato.TabIndex = 3
        Me.chkTomato.Text = "番茄 --"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'lblHist
        '
        Me.lblHist.AutoSize = True
        Me.lblHist.Location = New System.Drawing.Point(615, 66)
        Me.lblHist.Name = "lblHist"
        Me.lblHist.Size = New System.Drawing.Size(55, 13)
        Me.lblHist.TabIndex = 18
        Me.lblHist.Text = "顧客歷史"
        '
        'lstHist
        '
        Me.lstHist.FormattingEnabled = True
        Me.lstHist.Location = New System.Drawing.Point(618, 82)
        Me.lstHist.Name = "lstHist"
        Me.lstHist.Size = New System.Drawing.Size(159, 186)
        Me.lstHist.TabIndex = 19
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
        Me.grpAS.Location = New System.Drawing.Point(12, 257)
        Me.grpAS.Name = "grpAS"
        Me.grpAS.Size = New System.Drawing.Size(600, 79)
        Me.grpAS.TabIndex = 20
        Me.grpAS.TabStop = False
        Me.grpAS.Text = "累計銷售額"
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
        Me.btnCA.Text = "清除累積"
        Me.btnCA.UseVisualStyleBackColor = True
        '
        'btnMPI
        '
        Me.btnMPI.Location = New System.Drawing.Point(440, 15)
        Me.btnMPI.Name = "btnMPI"
        Me.btnMPI.Size = New System.Drawing.Size(154, 23)
        Me.btnMPI.TabIndex = 15
        Me.btnMPI.Text = "最受歡迎的成分"
        Me.btnMPI.UseVisualStyleBackColor = True
        '
        'lblLS
        '
        Me.lblLS.AutoSize = True
        Me.lblLS.Location = New System.Drawing.Point(240, 54)
        Me.lblLS.Name = "lblLS"
        Me.lblLS.Size = New System.Drawing.Size(79, 13)
        Me.lblLS.TabIndex = 21
        Me.lblLS.Text = "最大的銷售額"
        '
        'lblavg
        '
        Me.lblavg.AutoSize = True
        Me.lblavg.Location = New System.Drawing.Point(240, 22)
        Me.lblavg.Name = "lblavg"
        Me.lblavg.Size = New System.Drawing.Size(67, 13)
        Me.lblavg.TabIndex = 20
        Me.lblavg.Text = "平均銷售額"
        '
        'lblTS
        '
        Me.lblTS.AutoSize = True
        Me.lblTS.Location = New System.Drawing.Point(3, 54)
        Me.lblTS.Name = "lblTS"
        Me.lblTS.Size = New System.Drawing.Size(55, 13)
        Me.lblTS.TabIndex = 16
        Me.lblTS.Text = "總銷售額"
        '
        'lblNO
        '
        Me.lblNO.AutoSize = True
        Me.lblNO.Location = New System.Drawing.Point(3, 25)
        Me.lblNO.Name = "lblNO"
        Me.lblNO.Size = New System.Drawing.Size(55, 13)
        Me.lblNO.TabIndex = 15
        Me.lblNO.Text = "訂單數量"
        '
        'lblNameFind
        '
        Me.lblNameFind.AutoSize = True
        Me.lblNameFind.Location = New System.Drawing.Point(618, 291)
        Me.lblNameFind.Name = "lblNameFind"
        Me.lblNameFind.Size = New System.Drawing.Size(61, 13)
        Me.lblNameFind.TabIndex = 21
        Me.lblNameFind.Text = "顧客姓名："
        '
        'txtNameFind
        '
        Me.txtNameFind.Location = New System.Drawing.Point(618, 307)
        Me.txtNameFind.Name = "txtNameFind"
        Me.txtNameFind.Size = New System.Drawing.Size(82, 20)
        Me.txtNameFind.TabIndex = 22
        '
        'btnfind
        '
        Me.btnfind.Location = New System.Drawing.Point(706, 304)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(75, 23)
        Me.btnfind.TabIndex = 23
        Me.btnfind.Text = "尋找"
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btnEN_US
        '
        Me.btnEN_US.Location = New System.Drawing.Point(516, 28)
        Me.btnEN_US.Name = "btnEN_US"
        Me.btnEN_US.Size = New System.Drawing.Size(75, 23)
        Me.btnEN_US.TabIndex = 24
        Me.btnEN_US.Text = "EN_US"
        Me.btnEN_US.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 365)
        Me.Controls.Add(Me.btnEN_US)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.txtNameFind)
        Me.Controls.Add(Me.lblNameFind)
        Me.Controls.Add(Me.grpAS)
        Me.Controls.Add(Me.lstHist)
        Me.Controls.Add(Me.lblHist)
        Me.Controls.Add(Me.grpCOI)
        Me.Controls.Add(Me.lstDOO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "我的咖啡館"
        Me.grpCOI.ResumeLayout(False)
        Me.grpCOI.PerformLayout()
        CType(Me.NUD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSB.ResumeLayout(False)
        Me.grpSB.PerformLayout()
        Me.grpSSI.ResumeLayout(False)
        Me.grpSSI.PerformLayout()
        Me.grpAS.ResumeLayout(False)
        Me.grpAS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDOO As ListBox
    Friend WithEvents grpCOI As GroupBox
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents NUD1 As NumericUpDown
    Friend WithEvents btnClear As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblamt As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpSB As GroupBox
    Friend WithEvents lblHO As Label
    Friend WithEvents lblGW As Label
    Friend WithEvents radHO As RadioButton
    Friend WithEvents radGW As RadioButton
    Friend WithEvents grpSSI As GroupBox
    Friend WithEvents lblTunaPrice As Label
    Friend WithEvents lblHamPrice As Label
    Friend WithEvents lblTomatoPrice As Label
    Friend WithEvents lblLettucePrice As Label
    Friend WithEvents lblApplePrice As Label
    Friend WithEvents chkApple As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkTuna As CheckBox
    Friend WithEvents chkLettuce As CheckBox
    Friend WithEvents chkTomato As CheckBox
    Friend WithEvents lblHist As Label
    Friend WithEvents lstHist As ListBox
    Friend WithEvents grpAS As GroupBox
    Friend WithEvents txtLargest As TextBox
    Friend WithEvents txtAvg As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnCA As Button
    Friend WithEvents btnMPI As Button
    Friend WithEvents lblLS As Label
    Friend WithEvents lblavg As Label
    Friend WithEvents lblTS As Label
    Friend WithEvents lblNO As Label
    Friend WithEvents lblNameFind As Label
    Friend WithEvents txtNameFind As TextBox
    Friend WithEvents btnfind As Button
    Friend WithEvents lblHOzh As Label
    Friend WithEvents lblGWzh As Label
    Friend WithEvents lblTunaPricezh As Label
    Friend WithEvents lblHamPricezh As Label
    Friend WithEvents lblTomatoPricezh As Label
    Friend WithEvents lblApplePricezh As Label
    Friend WithEvents lblLettucePricezh As Label
    Friend WithEvents btnEN_US As Button
End Class
