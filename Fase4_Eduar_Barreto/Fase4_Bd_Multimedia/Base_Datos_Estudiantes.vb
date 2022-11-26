Public Class Base_Datos_Estudiantes

    Private Sub Base_Datos_Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EstudiantesDataSet.datos_estudiantes' Puede moverla o quitarla según sea necesario.
        Me.Datos_estudiantesTableAdapter.Fill(Me.EstudiantesDataSet.datos_estudiantes)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Codigo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatosestudiantesBindingSource.MoveFirst()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DatosestudiantesBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DatosestudiantesBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DatosestudiantesBindingSource.MoveLast()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        DatosestudiantesBindingSource.AddNew()
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Try
            DatosestudiantesBindingSource.EndEdit()
            Datos_estudiantesTableAdapter.Update(EstudiantesDataSet)
            MsgBox("registro exitoso")
        Catch ex As Exception
            MsgBox("error")

        End Try
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        DatosestudiantesBindingSource.RemoveCurrent()
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Try
            DatosestudiantesBindingSource.EndEdit()
            Datos_estudiantesTableAdapter.Update(EstudiantesDataSet)
            MsgBox("Modificado con exito")
        Catch ex As Exception
            MsgBox("No se Modifico")

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class