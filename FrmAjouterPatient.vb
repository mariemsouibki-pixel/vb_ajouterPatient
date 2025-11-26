Public Class FrmAjouterPatient
    Private Sub FrmAjouterPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbldate.Text = Date.Today.ToString()
    End Sub
    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        Dim P As Patient
        Dim age As Integer
        If String.IsNullOrWhiteSpace(Txtnom.Text) Then
            ErrorProvider1.SetError(Txtnom, "Nom invalide")
            Return
        End If
        ErrorProvider1.Clear()
        If String.IsNullOrWhiteSpace(Txtprenom.Text) Then
            ErrorProvider1.SetError(Txtprenom, "Prenom invalide")
            Return
        End If
        ErrorProvider1.Clear()
        age = CInt(Numage.Value)
        P.nom = Txtnom.Text
        P.prenom = Txtprenom.Text
        P.age = age
        AjouterPatient(P)
        MAJ_DGV()
        Init()
    End Sub
    Private Sub Init()
        Numage.Value = 0
        Txtnom.Clear()
        Txtprenom.Clear()
    End Sub
    Private Sub MAJ_DGV()
        DgvListePatients.Rows.Clear()
        For Each p As Patient In ListePatients
            DgvListePatients.Rows.Add(p.code, p.nom, p.prenom, p.age)
        Next
    End Sub

    Private Sub Btnannuler_Click(sender As Object, e As EventArgs) Handles Btnannuler.Click
        Init()
        DgvListePatients.Rows.Clear()
        ErrorProvider1.Clear()
    End Sub
End Class
