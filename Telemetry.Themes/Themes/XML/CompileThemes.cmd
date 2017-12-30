@ECHO OFF
PUSHD %~dp0
ECHO:
ECHO Compiling themes ...
CALL :CompileTheme "RoyalBlue" "RoyalBlue"
CALL :CompileTheme "OliveDrab" "OliveDrab"
CALL :CompileTheme "Gold" "Gold"
CALL :CompileTheme "Crimson" "Crimson"
CALL :CompileTheme "Black" "96, 96, 96"
GOTO :EOF
:CompileTheme
ECHO ------------------------------------------------------------
ECHO Compiling theme "%~1.xml" ...
CSCRIPT /NOLOGO FindReplace.vbs /I:"%CD%\BaseTheme.xml" /O:"%CD%\%~1.xml" /F:"RoyalBlue" /R:"%~2"
ECHO Theme "%~1.xml" compiled successfully !
EXIT /B
:EOF
