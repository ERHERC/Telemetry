@ECHO OFF
PUSHD %~dp0
COLOR F0
TITLE Themes compiler
CLS
ECHO:
ECHO Compiling scripts ...
WSCRIPT FindReplace.vbs /I:"%CD%\BaseTheme.xml" /O:"%CD%\RoyalBlue.xml" /F:"RoyalBlue" /R:"RoyalBlue"
WSCRIPT FindReplace.vbs /I:"%CD%\BaseTheme.xml" /O:"%CD%\Crimson.xml" /F:"RoyalBlue" /R:"Crimson"
WSCRIPT FindReplace.vbs /I:"%CD%\BaseTheme.xml" /O:"%CD%\Gold.xml" /F:"RoyalBlue" /R:"Gold"
WSCRIPT FindReplace.vbs /I:"%CD%\BaseTheme.xml" /O:"%CD%\OliveDrab.xml" /F:"RoyalBlue" /R:"OliveDrab"
WSCRIPT FindReplace.vbs /I:"%CD%\BaseTheme.xml" /O:"%CD%\Black.xml" /F:"RoyalBlue" /R:"96, 96, 96"
ECHO Done !