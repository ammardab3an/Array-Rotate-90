Imports System.Windows.Forms

Public Class Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Byte = NumericUpDown1.Value - 1
        Dim y As Byte = NumericUpDown2.Value - 1
        Dim beforArray(x, y) As String
        For i = 0 To x
            For ii = 0 To y

                beforArray(i, ii) = (i.ToString & ":" & ii.ToString)
                Console.Write(beforArray(i, ii) & " ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()


        Dim afterArray(y, x) As String
        For i = 0 To y
            For ii = 0 To x
                afterArray(i, ii) = beforArray(ii, y - i)
                Console.Write(afterArray(i, ii) & " ")
            Next
            Console.WriteLine()
        Next



        Dim _frm As New Form2
        _frm.Text = "befor"
        For i = 0 To y
            Dim col As New DataGridViewTextBoxColumn
            col.DataPropertyName = "PropertyName" & i.ToString
            col.HeaderText = i.ToString
            col.Name = "colWhateverName" & i.ToString
            col.Width = 25
            _frm.DataGridView1.Columns.Add(col)
        Next


        For i = 0 To x
            Dim aarray As New List(Of String)
            For ii = 0 To y
                aarray.Add(beforArray(i, ii).ToString)
            Next
            _frm.DataGridView1.Rows.Add(aarray.ToArray)
        Next


        _frm.Show()

        Dim __frm As New Form2
        __frm.Text = "after"
        For i = 0 To x
            Dim col As New DataGridViewTextBoxColumn
            col.DataPropertyName = "PropertyName" & i.ToString
            col.HeaderText = i.ToString
            col.Name = "colWhateverName" & i.ToString
            col.Width = 25
            __frm.DataGridView1.Columns.Add(col)
        Next


        For i = 0 To y
            Dim aarray As New List(Of String)
            For ii = 0 To x
                aarray.Add(afterArray(i, ii).ToString)
            Next
            __frm.DataGridView1.Rows.Add(aarray.ToArray)
        Next


        __frm.Show()
    End Sub
End Class