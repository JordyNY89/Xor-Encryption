'=========================================================================
'This program is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.

'    This program is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.

'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <http://www.gnu.org/licenses/>.
'    Also add information on how to contact you by electronic and paper mail.
'=========================================================================

'*VERY IMPORTANT*  
'This  program is using the lowest form of encryption and  should not be used with sensetive  information 
'The program was created  in hopes to get out of a Final Exam :)

'February 12, 2015

'Jordan Lassiter
'Jordan@Lassiter.eu 
'www.jordanlassiter.com

'Summary: This program is used as a  means to create a very basic encyption  that uses  XOR Encryption method   encrypt  
'your text as a file which will use a key based on the input for a password that is inputed from the end user
'and which can be used to decrypt the file contents by the user of this program



'Tools Used
' Textbox For Instructions read only
' Label Addressed as Length
' Label Addressed as Width
' Label Addressed as Results
' Textbox Corosponding with lenght label
' Textbox Corosponding with width label
' Textbox Corosponding with results label this label will be read only 
' Textbox Result button
' Textbox Close button

'Algorithm: convert to ascii then xor


Imports System.Text
Imports System.Security.Cryptography ' We need some Imports  for this to work  this will be explained later on 
Imports System.Security.Cryptography.HashAlgorithm ' We need this as well 
Public Class SimpleCrypt

    Private _createEncryptor As Byte
    Dim fout As Object
    Private _createEncryptor1 As Byte
    Private _keySizes As Byte()
    Private _random As Byte

    Private Property m_key As TripleDESCryptoServiceProvider

    Private Property CreateEncryptor(p1 As Object, iCryptoTransform As ICryptoTransform, cryptoStreamMode As CryptoStreamMode) As Byte
        Get
            Return _createEncryptor
        End Get
        Set(value As Byte)
            _createEncryptor = value
        End Set
    End Property

    Private Property tdesIV As Byte()

    Private Property tdesKey As Byte()

    Private Property CreateEncryptor(fout As Object, iCryptoTransform As ICryptoTransform) As Byte
        Get
            Return _createEncryptor1
        End Get
        Set(value As Byte)
            _createEncryptor1 = value
        End Set
    End Property

    Private Property KeySizes(p1 As Integer) As Byte()
        Get
            Return _keySizes
        End Get
        Set(value As Byte())
            _keySizes = value
        End Set
    End Property

    Private Property Random(p1 As Object) As Byte
        Get
            Return _random
        End Get
        Set(value As Byte)
            _random = value
        End Set
    End Property

   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage1.Show()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        floc.Text = OpenFileDialog1.FileName
    End Sub



    Private Sub Greetz_Click(sender As Object, e As EventArgs) Handles Greetz.Click

    End Sub
    

    Private Sub DtxB_TextChanged(sender As Object, e As EventArgs) Handles DtxB.TextChanged

    End Sub

    Private Sub EncTextB_TextChanged(sender As Object, e As EventArgs) Handles EncTextB.TextChanged



      
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tdes As New TripleDESCryptoServiceProvider()
        Dim key As String
        Dim letter As String
        Dim i, charinfile, code As Double
        Dim swrite = Nothing
        SaveFileDialog1.Filter = "Text Files (*.txt)|txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Try
                key = InputBox("Please Enter a Number Password")
                key = CLng(code)
                If key = "" Then Exit Sub

                charinfile = EncTextB.Text.Length
                swrite = My.Computer.FileSystem.OpenTextFileWriter(_SaveFileDialog1.FileName, False)
                For i = 0 To charinfile - 1
                    letter = EncTextB.Text.Substring(i, 1)
                    swrite.write(Asc(letter) Xor code)
                    swrite.write("")
                    Dim tmpSource As Byte() = ASCIIEncoding.ASCII.GetBytes(EncTextB.Text)
                    Dim Hash As Byte() = New SHA1CryptoServiceProvider().ComputeHash(tmpSource)

                    Dim result As String = ComputeHash(tmpSource)

                    ToolStripStatusLabel1.Text = result

                Next

            Catch ex As Exception
            Finally
                If swrite IsNot Nothing Then
                    swrite.close()
                End If
            End Try


        End If




    End Sub


    Private Sub XORImg_Click(sender As Object, e As EventArgs) Handles XORImg.Click




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

   
    Private Sub FileSystemWatcher1_Changed(sender As Object, e As IO.FileSystemEventArgs)

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub
End Class




