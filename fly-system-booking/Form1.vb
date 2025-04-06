Imports System.Windows.Forms.VisualStyles
Imports System.DirectoryServices
Imports System.IO

Public Class LogIn
    Public Sub New()
        InitializeComponent()
    End Sub

    Private isPasswordVisible As Boolean = False

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If checkBoxSave.Checked Then
            ' حفظ الاسم والباسورد في ملف
            Dim credentials As String() = {nameBox.Text, passBox.Text}
            File.WriteAllLines("credentials.txt", credentials)
        End If

        ' هنا يمكنك إضافة كود تسجيل الدخول كتحقق من البيانات المدخلة
        MessageBox.Show("تم تسجيل الدخول!")


        '
        ' العمليات التالية بعد تسجيل الدخول (على سبيل المثال، فتح الصفحة الرئيسية)
        MessageBox.Show("Login successful!")

    End Sub


    Private Sub log_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("credentials.txt") Then
            Dim lines() As String = File.ReadAllLines("credentials.txt")
            If lines.Length >= 2 Then
                nameBox.Text = lines(0) ' أول سطر هو الاسم
                passBox.Text = lines(1) ' ثاني سطر هو الباسورد
                passBox.PasswordChar = "*" ' إخفاء كلمة المرور
                isPasswordVisible = False
                checkBoxSave.Checked = True
            End If
        End If
    End Sub

    Private Sub checkBoxsave_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxSave.CheckedChanged

    End Sub

    Private Sub passBox_TextChanged(sender As Object, e As EventArgs) Handles passBox.TextChanged

    End Sub

    Private Sub btPasswordVisible_Click(sender As Object, e As EventArgs) Handles btPasswordVisible.Click
        If isPasswordVisible Then
            passBox.PasswordChar = "*" ' إخفاء كلمة المرور
            isPasswordVisible = False
        Else
            passBox.PasswordChar = "" ' عرض كلمة المرور
            isPasswordVisible = True
        End If
    End Sub

    Private Sub nameBox_TextChanged(sender As Object, e As EventArgs) Handles nameBox.TextChanged

    End Sub
End Class






