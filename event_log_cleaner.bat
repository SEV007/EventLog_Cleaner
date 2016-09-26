@echo off
setLocal EnableDelayedExpansion
cd ..\..\

echo IF YOU ARE NOT RUNNING THIS PROGRAM WITH //
echo ADMINISTRATOR PRIVILEGES PLEASE RESTART IT
echo WITH RUN AS ADMINISTRATOR ////////////////
echo:

:menu
echo ################ MENU ################
echo # 1) Update/Generate cleaner.bat     #
echo # 2) Clean logs                      #
echo # 3) Set CPU Limit                   #
echo # 4) Remove cleaner.bat              #
echo # 5) Exit                            #
echo ###################################### 

set /p var=Select Option: 
if "%var%"=="1" goto s1
if "%var%"=="2" goto s2
if "%var%"=="3" goto s3
if "%var%"=="4" goto s4
if "%var%"=="5" goto s5

:s1
	wevtutil el > tmp.txt

	for /f "tokens=* delims= " %%i in (tmp.txt) do (
	set /a N+=1
	echo ^wevtutil cl %%i^ >>cleaner.bat
	)

	erase tmp.txt
	echo exit >>cleaner.bat
	REM move /Y cleaner.bat C:\
	cls
	echo:
	echo:
	echo CLEANER IS UPDATED
	echo:
	goto menu

:s2
	start /wait cleaner.bat
	cls
	echo:
	echo:
	echo LOGS CLEANED SUCCESSFULLY
	echo:
	goto menu

:s3
	set /p cpu=Select CPU Limit(001-100): 
	powercfg -setacvalueindex SCHEME_BALANCED SUB_PROCESSOR PROCTHROTTLEMAX %cpu%
 	powercfg.exe -setactive SCHEME_CURRENT
 	cls
 	echo:
 	echo:
 	echo CPU Limit set to %cpu%
 	echo:
	goto menu

:s4
	erase cleaner.bat
	cls
	echo:
	echo:
	echo cleaner.bat IS DELETED
	echo:
	goto menu

:s5
	exit