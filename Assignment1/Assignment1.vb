Public Class Assignment1
    Private Sub textBtn_Click(sender As Object, e As EventArgs) Handles TextBtn.Click
        Dim Btn As Boolean = True

        Dim name As String = NameTextBox.Text
        Dim age As String = AgeTextBox.Text
        Dim add As String = AddTextBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("TXTfile.txt", True)
        Txt.WriteLine("Name : " + name)
        Txt.WriteLine("Age : " + age)
        Txt.WriteLine("Address : " + add)
        Txt.Close()

        If Btn Then
            MessageBox.Show("Text file is created at '\Assignment1\bin\Debug'")
        End If
    End Sub

    Private Sub xmlBtn_Click(sender As Object, e As EventArgs) Handles XmlBtn.Click
        Dim Btn As Boolean = True

        Dim name As String = NameTextBox.Text
        Dim age As String = AgeTextBox.Text
        Dim add As String = AddTextBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("XMLfile.xml", True)
        Txt.WriteLine("<Name>" + name + "</Name>")
        Txt.WriteLine("<Age>" + age + "</Age>")
        Txt.WriteLine("<Address>" + add + "</Address>")
        Txt.Close()

        If Btn Then
            MessageBox.Show("XML file is created at '\Assignment1\bin\Debug'")
        End If
    End Sub

    Private Sub jsonBtn_Click(sender As Object, e As EventArgs) Handles JsonBtn.Click
        Dim Btn As Boolean = True

        Dim name As String = NameTextBox.Text
        Dim age As String = AgeTextBox.Text
        Dim add As String = AddTextBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("JSONfile.json", True)
        Txt.WriteLine("{")
        Txt.WriteLine("  ""Name:"" " + name + ",")
        Txt.WriteLine("  ""Age:"" " + age + ",")
        Txt.WriteLine("  ""Address:"" " + add)
        Txt.WriteLine("}")
        Txt.Close()

        If Btn Then
            MessageBox.Show("JSON file is created at '\Assignment1\bin\Debug'")
        End If
    End Sub

    Private Sub NameTextBox_Proper(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        Dim n As Integer = NameTextBox.SelectionStart
        NameTextBox.Text = StrConv(sender.Text, VbStrConv.ProperCase)
        NameTextBox.SelectionStart = n
    End Sub

    Private Sub AddTextBox_Proper(sender As Object, e As EventArgs) Handles AddTextBox.TextChanged
        Dim n As Integer = AddTextBox.SelectionStart
        AddTextBox.Text = StrConv(sender.Text, VbStrConv.ProperCase)
        AddTextBox.SelectionStart = n
    End Sub
End Class
