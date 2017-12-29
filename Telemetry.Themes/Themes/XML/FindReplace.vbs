'Arguments :
'   -   <ARG_Input>     :   Input file path
'   -   <ARG_Output>    :   Output file path
'   -   <ARG_Find>      :   String to search for
'   -   <ARG_Replace>   :   String which will replace <ARG_Find>

Dim ARG_Input
ARG_Input = WScript.Arguments.Named("I")
If ARG_Input = "" Then MsgBox("Argument not assigned : ""/I:<string>""" & vbCrLf & "Parameter name : ""Input file""") : WScript.Quit()

Dim ARG_Output
ARG_Output = WScript.Arguments.Named("O")
If ARG_Output = "" Then MsgBox("Argument not assigned : ""/O:<string>""" & vbCrLf & "Parameter name : ""Output file""") : WScript.Quit()

Dim ARG_Find
ARG_Find = WScript.Arguments.Named("F")
If ARG_Find = "" Then MsgBox("Argument not assigned : ""/F:<string>""" & vbCrLf & "Parameter name : ""Find string""") : WScript.Quit()

Dim ARG_Replace
ARG_Replace = WScript.Arguments.Named("R")
If ARG_Replace = "" Then MsgBox("Argument not assigned : ""/R:<string>""" & vbCrLf & "Parameter name : ""Replace string""") : WScript.Quit()



Dim FileSystemObject
Dim File
Dim FileContent
Dim OutputFile

Set FileSystemObject = CreateObject("Scripting.FileSystemObject")
Set File = FileSystemObject.OpenTextFile(ARG_Input,1)
Content = File.ReadAll()
Content = Replace(Content,ARG_Find,ARG_Replace)
Set OutputFile = FileSystemObject.CreateTextFile(ARG_Output,True)
OutputFile.Write(Content)
OutputFile.Close()
