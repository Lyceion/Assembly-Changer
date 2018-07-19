Imports System.CodeDom.Compiler
Imports System.IO
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Display_Description(Name As String)
        Try
            Application.DoEvents()
            Dim flag As Boolean = File.Exists(Application.StartupPath + "\res.exe")
            If flag Then
                File.Delete(Application.StartupPath + "\res.exe")
            End If
            Thread.Sleep(50)
            File.WriteAllBytes(Application.StartupPath + "\res.exe", Cylops_s_Cheat_Loader.My.Resources.Res)
            Thread.Sleep(50)
            Dim text As String = Cylops_s_Cheat_Loader.My.Resources.RHDiscription
            Dim vbcodeProvider As VBCodeProvider = New VBCodeProvider(New Dictionary(Of String, String)() From {{"CompilerVersion", "v2.0"}})
            Dim compilerParameters As CompilerParameters = New CompilerParameters()
            Dim compilerParameters2 As CompilerParameters = compilerParameters
            compilerParameters2.GenerateExecutable = True
            compilerParameters2.OutputAssembly = Application.StartupPath + "\\" + Me.T1.Text + ".exe"
            compilerParameters2.CompilerOptions = "/target:winexe"
            compilerParameters2.ReferencedAssemblies.Add("System.dll")
            compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll")
            compilerParameters2.MainClass = "X"
            text = text.Replace("*Title*", Me.T2.Text)
            text = text.Replace("*Company*", Me.T3.Text)
            text = text.Replace("*Product*", Me.T4.Text)
            text = text.Replace("*Copyright*", Me.T5.Text)
            text = text.Replace("*Trademark*", Me.T1.Text)
            text = text.Replace("*version*", String.Concat(New String() {Me.N1.Value.ToString(), ".", Me.N2.Value.ToString(), ".", Me.N3.Value.ToString(), ".", Me.N4.Value.ToString()}))
            text = text.Replace("*fversion*", String.Concat(New String() {Me.N6.Value.ToString(), ".", Me.N7.Value.ToString(), ".", Me.N8.Value.ToString(), ".", Me.N9.Value.ToString()}))
            Dim compilerResults As CompilerResults = vbcodeProvider.CompileAssemblyFromSource(compilerParameters, New String() {text})
            Dim text2 As String = Application.StartupPath + "\" + Me.T1.Text + ".exe"
            Dim text3 As String = Application.StartupPath + "\" + Me.T1.Text + ".res"
            Interaction.Shell(String.Concat(New String() {"res.exe -extract ", text2, ",", text3, ",VERSIONINFO,,"}), AppWinStyle.Hide, True, -1)
            Interaction.Shell(String.Concat(New String() {"res.exe -delete ", Name, ",", AppDomain.CurrentDomain.BaseDirectory, "res.exe,VERSIONINFO,,"}), AppWinStyle.Hide, True, -1)
            Interaction.Shell(String.Concat(New String() {"res.exe -addoverwrite ", Name, ",", Name, ",", text3, ",VERSIONINFO,1,"}), AppWinStyle.Hide, True, -1)
            flag = File.Exists(Application.StartupPath + "\" + Me.T1.Text + ".exe")
            If flag Then
                File.Delete(Application.StartupPath + "\" + Me.T1.Text + ".exe")
            End If
            flag = File.Exists(Application.StartupPath + "\" + Me.T1.Text + ".res")
            If flag Then
                File.Delete(Application.StartupPath + "\" + Me.T1.Text + ".res")
            End If
            flag = File.Exists(Application.StartupPath + "\res.exe")
            If flag Then
                File.Delete(Application.StartupPath + "\res.exe")
            End If
            flag = File.Exists(Application.StartupPath + "\res.log")
            If flag Then
                File.Delete(Application.StartupPath + "\res.log")
            End If
            flag = File.Exists(Application.StartupPath + "\res.ini")
            If flag Then
                File.Delete(Application.StartupPath + "\res.ini")
            End If
            Interaction.MsgBox("Process Worked Fine. Closing Program...", MsgBoxStyle.Information, Nothing)
        Catch ex As Exception
            Interaction.MsgBox("Shomething Went Wrong! Closing Program. Error:" + ex.ToString, MsgBoxStyle.Critical, "Bilgi")
            Application.Exit()
        End Try
        Process.Start("https://memoryhackers.net/members/cylops.55350/")
    End Sub
    Public Function GENRandom(longitud As Integer, NNNNN As Integer) As String
        Dim text As String = "012345678WERTYUIQWERTYUIןPL123456789KJHGFDSAZXC123456789VBNMQWERTY9QWERTYUIQWERTYUIآغدففعتيوضعغفقكئىمزرOPLKJHGF123456789DSAZXCVBNMQWERTYUIOPLKJH123456789GFDSAZXCVBNMQWERTYUI123456789OPLKJHGFDSAYUIOPLKJHGFDSAZX123456789123456789123456789CVBNMOPLKJHGFDSAZXCVBNM"
        Dim random As Random = New Random()
        Dim stringBuilder As StringBuilder = New StringBuilder()
        For i As Integer = 1 To longitud
            Dim startIndex As Integer = random.[Next](0, NNNNN)
            stringBuilder.Append(text.Substring(startIndex, 1))
        Next
        Return stringBuilder.ToString()
    End Function
    Public Function RandomN() As Object
        VBMath.Randomize()
        Dim num As Single = Conversion.Int(9.0F * VBMath.Rnd()) + 1.0F
        Return num
    End Function
    Private Sub Processes()
        Try
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Filter = "Executable|*.exe"
            openFileDialog.Title = "Open"
            Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
            If flag Then
                TXTFileName.Text = System.IO.Path.GetFileName(openFileDialog.FileName)
            End If
            flag = (openFileDialog.FileName.Length > 0)
            If flag Then
                Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName)
                Me.T1.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName)
                Me.T2.Text = versionInfo.FileDescription
                Me.T3.Text = versionInfo.CompanyName
                Me.T4.Text = versionInfo.ProductName
                Me.T5.Text = versionInfo.LegalCopyright
                Dim array As String() = versionInfo.ProductVersion.Split(New Char() {"."c})
                Me.N1.Value = Conversions.ToDecimal(array(0))
                Me.N2.Value = Conversions.ToDecimal(array(1))
                Me.N3.Value = Conversions.ToDecimal(array(2))
                Me.N4.Value = Conversions.ToDecimal(array(3))
                Dim array2 As String() = versionInfo.FileVersion.Split(New Char() {"."c})
                Me.N6.Value = Conversions.ToDecimal(array2(0))
                Me.N7.Value = Conversions.ToDecimal(array2(1))
                Me.N8.Value = Conversions.ToDecimal(array2(2))
                Me.N9.Value = Conversions.ToDecimal(array2(3))
            End If       Catch ex As Exception
        End Try
        Thread.Sleep(10)
        Me.T1.Text = Me.GENRandom(20, 55)
        Me.T2.Text = Me.GENRandom(20, 44)
        Me.T3.Text = Me.GENRandom(20, 50)
        Me.T4.Text = Me.GENRandom(20, 88)
        Me.T5.Text = Me.GENRandom(20, 93)
        Me.N1.Value = Conversions.ToDecimal(Me.RandomN())
        Me.N2.Value = Conversions.ToDecimal(Me.RandomN())
        Me.N3.Value = Conversions.ToDecimal(Me.RandomN())
        Me.N4.Value = Conversions.ToDecimal(Me.RandomN())
        Me.N6.Value = Conversions.ToDecimal(Me.RandomN())
        Me.N7.Value = Conversions.ToDecimal(Me.RandomN())
        Me.N8.Value = Conversions.ToDecimal(Me.RandomN())
        Me.N9.Value = Conversions.ToDecimal(Me.RandomN())
        Thread.Sleep(100)
        Me.Display_Description(Me.TXTFileName.Text)
        My.Computer.FileSystem.RenameFile(Application.StartupPath + "\" + TXTFileName.Text, T1.Text + ".exe")
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Processes()
    End Sub
End Class
