@ECHO OFF
REM https://superuser.com/questions/323775/how-can-i-loop-through-all-sub-folder-of-foldera-and-execute-o-bat-in-each-when

PUSHD %~dp0 > NUL
FOR /F %%F IN ('DIR "%CD%\Telemetry.*" /AD /B') DO (
    PUSHD %%F > NUL
    RMDIR /S /Q "%CD%\%%F\bin" > NUL
    RMDIR /S /Q "%CD%\%%F\obj" > NUL
    POPD > NUL
) > NUL
EXIT