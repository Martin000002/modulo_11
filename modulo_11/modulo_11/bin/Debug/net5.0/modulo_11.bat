@echo off

rem A batch file for modulo_11.exe
rem which captures the app's return value

modulo_11
@if "%ERRORLEVEL% == "0" goto success

:fail
 echo This aplication has failed!
 echo return value = %ERRORLEVEL%
 goto end
:success
 echo This aplication has succeeded
 echo return = %ERRORLEVEL%
 goto end
:end
 echo All Done