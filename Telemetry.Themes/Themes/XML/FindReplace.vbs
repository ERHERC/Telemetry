' Arguments :
'   -   <ARG_Input>     :   Input file path
'   -   <ARG_Output>    :   Output file path
'   -   <ARG_Find>      :   String to search for
'   -   <ARG_Replace>   :   String which will replace <ARG_Find>
Dim FileSystemObject,File,FileContent,OutputFile,ARG_Input,ARG_Output,ARG_Find,ARG_Replace
Set FileSystemObject = CreateObject("Scripting.FileSystemObject")
Set InfoLog = FileSystemObject.GetStandardStream (1)
Set ErrorLog = FileSystemObject.GetStandardStream (2)
ARG_Input = WScript.Arguments.Named("I")
If ARG_Input = "" Then ErrorLog.WriteLine("Argument not assigned : ""/I:<string>""" & vbCrLf & "Parameter name : ""Input file""") : WScript.Quit()
ARG_Output = WScript.Arguments.Named("O")
If ARG_Output = "" Then ErrorLog.WriteLine("Argument not assigned : ""/O:<string>""" & vbCrLf & "Parameter name : ""Output file""") : WScript.Quit()
ARG_Find = WScript.Arguments.Named("F")
If ARG_Find = "" Then ErrorLog.WriteLine("Argument not assigned : ""/F:<string>""" & vbCrLf & "Parameter name : ""Find string""") : WScript.Quit()
ARG_Replace = WScript.Arguments.Named("R")
If ARG_Replace = "" Then ErrorLog.WriteLine("Argument not assigned : ""/R:<string>""" & vbCrLf & "Parameter name : ""Replace string""") : WScript.Quit()
Set File = FileSystemObject.OpenTextFile(ARG_Input,1)
Content = File.ReadAll()
Content = Replace(Content,ARG_Find,ARG_Replace)
Set OutputFile = FileSystemObject.CreateTextFile(ARG_Output,True)
OutputFile.Write(Content):OutputFile.Close()