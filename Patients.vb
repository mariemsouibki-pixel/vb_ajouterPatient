Module Patients
    Public Structure Patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
    End Structure
    Public ListePatients As New List(Of Patient)
    Public Sub AjouterPatient(p As Patient)
        p.code = ListePatients.Count
        ListePatients.Add(p)
    End Sub

End Module
