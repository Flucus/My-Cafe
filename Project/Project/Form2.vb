Public Class Form2
    'Extra/New function is implemented in the project successfully.
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblApplePricezh.Text = "HK$" & FormatNumber(Appleprice, 2)
        lblLettucePricezh.Text = "HK$" & FormatNumber(Lettuceprice, 2)
        lblTomatoPricezh.Text = "HK$" & FormatNumber(Tematoprice, 2)
        lblHamPricezh.Text = "HK$" & FormatNumber(Hamprice, 2)
        lblTunaPricezh.Text = "HK$" & FormatNumber(Tunaprice, 2)
        lblGWzh.Text = "HK$" & FormatNumber(GWprice, 2)
        lblHOzh.Text = "HK$" & FormatNumber(HOprice, 2)
        NUD1.Value = 1
    End Sub

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

    Private Sub btnEN_US_Click(sender As Object, e As EventArgs) Handles btnEN_US.Click
        'Extra/New function is implemented in the project successfully.
        FrmProject.Show()
        Me.Hide()
    End Sub

    Private Sub btnCA_Click(sender As Object, e As EventArgs) Handles btnCA.Click
        CA()
    End Sub

    Dim MOI As String = "null"
    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        Dim L, rew, result As Integer
        For L = 0 To lstHist.Items.Count - 1
            rew = L + 1
            If lstHist.Items(L) = txtNameFind.Text Then
                MsgBox(txtNameFind.Text & " 是在第 " & rew & " 行的名單中。")
                result = 1
            End If
            If result = 0 And L = lstHist.Items.Count - 1 Then
                MsgBox("未找到客戶")
            End If
        Next
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim sum As Double
        If chkApple.Checked = False And chkHam.Checked = False And chkLettuce.Checked = False And chkTomato.Checked = False And chkTuna.Checked = False Then
            MsgBox("請選擇沙拉配料")
        Else
            If radGW.Checked = False And radHO.Checked = False Then
                MsgBox("請選擇麵包")
            Else
                If NUD1.Value = 0 Then
                    MsgBox("請輸入數量。")
                Else
                    If txtName.Text = "" Then
                        MsgBox("請輸入客戶名稱。")
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
                        txtAmt.Text = "HK$" & FormatNumber(sum, 2)

                        lstHist.Items.Add(txtName.Text)
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

    Private Sub btnMPI_Click(sender As Object, e As EventArgs) Handles btnMPI.Click
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
        MsgBox("最受歡迎的成分： " & MOI)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
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