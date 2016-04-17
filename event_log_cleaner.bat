@echo off
setLocal EnableDelayedExpansion

wevtutil el > tmp.txt

for /f "tokens=* delims= " %%i in (tmp.txt) do (
set /a N+=1
echo ^wevtutil cl %%i^ >>cleaner.bat
)

erase tmp.txt
move /Y cleaner.bat C:\
