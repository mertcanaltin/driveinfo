Imports System.IO
Public Class SurucuBılgıleriFormu
    Private Structure BoyutBilgi
        Public Boyut As Decimal
        Public Birim As String

    End Structure
    Private Function BirimDonustur(Buyukluk As Decimal) As BoyutBilgi
        Dim Bilgi As BoyutBilgi
        Dim sayac As SByte = 0
        Dim Simge As String() = {"Byte", "KB", "MB", "GB", "TB", "PB", "EB", "YB", "ZB"}
        Do Until Buyukluk < 512
            Buyukluk = Buyukluk / 1024
            sayac += 1
        Loop
        Buyukluk = Math.Round(Buyukluk, 2)
        Bilgi.Boyut = Buyukluk
        Bilgi.Birim = Simge(sayac)
        Return Bilgi
    End Function
    Private Sub SurucuBılgıleriFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuruculeriGetir()

    End Sub
    Private Sub SuruculeriGetir()
        SurucuComboBox1.Items.Clear()
        SurucuComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        For Each Surucu As DriveInfo In My.Computer.FileSystem.Drives
            SurucuComboBox1.Items.Add(Surucu.Name)
        Next 'döngüden çıktım

        If SurucuComboBox1.Items.Count > 0 Then SurucuComboBox1.SelectedIndex = 0






    End Sub

    Private Sub SurucuComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SurucuComboBox1.SelectedIndexChanged
        If SurucuComboBox1.SelectedIndex > -1 Then
            BilgiTextBox1.Clear()
            Dim Surucu As New DriveInfo(SurucuComboBox1.SelectedItem)
            BilgiTextBox1.Text &= "Sürücü adı:" & Surucu.Name & vbCrLf
            BilgiTextBox1.Text &= "Sürücü Tipi:" & Surucu.DriveType.ToString & vbCrLf
            If Surucu.IsReady Then
                BilgiTextBox1.Text &= "Sürücü Etiketi:" & Surucu.VolumeLabel & vbCrLf
                BilgiTextBox1.Text &= "Sürücü Formatı:" & Surucu.DriveFormat & vbCrLf
                BilgiTextBox1.Text &= "Sürücü Ana Dizin:" & Surucu.RootDirectory.Name & vbCrLf
                Dim Bilgi As BoyutBilgi = BirimDonustur(Surucu.TotalSize)
                BilgiTextBox1.Text &= "Sürücü Toplam Boyut:" & Bilgi.Boyut & Bilgi.Birim & vbCrLf
                BirimDonustur(Surucu.TotalFreeSpace)
                BilgiTextBox1.Text &= "Sürücü Toplam Boş Alan:" & Bilgi.Boyut & Bilgi.Birim & vbCrLf
            End If

        End If

    End Sub

    Private Sub yenile(sender As Object, e As EventArgs) Handles YenilePictureBox1.Click
        SuruculeriGetir()
    End Sub
End Class
