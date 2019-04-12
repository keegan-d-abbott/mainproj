Public Class Order
    Private Sub OrderLineBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrderLineBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrderLineBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group29DataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group29DataSet.OrderLine' table. You can move, or remove it, as needed.
        Me.OrderLineTableAdapter.Fill(Me.Group29DataSet.OrderLine)

    End Sub
End Class