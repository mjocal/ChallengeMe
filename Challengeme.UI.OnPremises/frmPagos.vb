Imports System.Globalization
Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmPagos
    Dim pagoManager As New PagoManagement
    Private Sub OnFormPagosLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPagosTable()
    End Sub

    Private Sub LoadPagosTable()

        DataGridViewPagos.Rows.Clear()

        Dim pagoList

        Dim numFormatInfo = NumberFormatInfo.CurrentInfo.Clone()
        numFormatInfo.CurrencySymbol = "₡"

        Try

            pagoList = pagoManager.RetrieveAllPagos(Of Ruta)()

            For Each pago As Ruta In pagoList

                Dim pagoRow =
                {
                    pago.IdPago,
                    pago.IdUsuario,
                    pago.MetodoDePago,
                    String.Format(numFormatInfo, "{0:C}", pago.MontoDePago),
                    String.Format(numFormatInfo, "{0:C}", pago.DescuentoDePago),
                    String.Format(numFormatInfo, "{0:C}", pago.ImpuestoDePago),
                    String.Format(numFormatInfo, "{0:C}", pago.TotalPago),
                    pago.DetalleDePago,
                    pago.FechaPago,
                    pago.EstadoDePago
                }

                DataGridViewPagos.Rows.Add(pagoRow)

            Next


        Catch ex As Exception

        End Try

    End Sub

    Private Sub OnCellClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewPagos.CellMouseClick
        Dim selectedRow As Integer

        selectedRow = DataGridViewPagos.CurrentRow.Index

        txtIdPago.Text = DataGridViewPagos.Item(0, selectedRow).Value
        txtIdUsuario.Text = DataGridViewPagos.Item(1, selectedRow).Value
        txtMetodo.Text = DataGridViewPagos.Item(2, selectedRow).Value
        txtMontoPago.Text = DataGridViewPagos.Item(3, selectedRow).Value
        txtDescuento.Text = DataGridViewPagos.Item(4, selectedRow).Value
        txtImpuestoPago.Text = DataGridViewPagos.Item(5, selectedRow).Value
        txtTotalPago.Text = DataGridViewPagos.Item(6, selectedRow).Value
        txtDetallePago.Text = DataGridViewPagos.Item(7, selectedRow).Value
        DateTimePickerFechaPago.Value = DataGridViewPagos.Item(8, selectedRow).Value
        txtEstadoPago.Text = DataGridViewPagos.Item(9, selectedRow).Value

    End Sub
End Class