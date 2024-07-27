Public Class mainfrm
    Private Sub mainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Dashboardfrm
            .TopLevel = False
            Panel1.Controls.Add(Dashboardfrm)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Dispose()
        Form1.usercomboload()
        Form1.Show()
    End Sub

    Private Sub btn_manageuser_Click(sender As Object, e As EventArgs) Handles btn_manageuser.Click
        manageuserfrm.ShowDialog()
    End Sub

    Private Sub btn_customerMaster_Click(sender As Object, e As EventArgs) Handles btn_customerMaster.Click
        With managecustomer
            .TopLevel = False
            Panel1.Controls.Add(managecustomer)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_ProductMaster_Click(sender As Object, e As EventArgs) Handles btn_ProductMaster.Click
        With manageProduct
            .TopLevel = False
            Panel1.Controls.Add(manageProduct)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_stockmaster_Click(sender As Object, e As EventArgs) Handles btn_stockmaster.Click
        With managestock
            .TopLevel = False
            Panel1.Controls.Add(managestock)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_inbound_Click(sender As Object, e As EventArgs) Handles btn_inbound.Click
        With inboundfm
            .TopLevel = False
            Panel1.Controls.Add(inboundfm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_outbound_Click(sender As Object, e As EventArgs) Handles btn_outbound.Click
        With outboundfrm
            .TopLevel = False
            Panel1.Controls.Add(outboundfrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        With Dashboardfrm
            .TopLevel = False
            Panel1.Controls.Add(Dashboardfrm)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class