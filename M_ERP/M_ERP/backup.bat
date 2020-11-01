@echo off

echo Starting Backup of Mysql Database on server 

cd C:\Program Files\MySQL\MySQL Server 5.7\bin

For /f "tokens=2-4 delims=/ " %%a in ('date /t') do (set dt=%%c-%%a-%%b)

For /f "tokens=1-4 delims=:." %%a in ('echo %time%') do (set tm=%%a%%b%%c%%d)

set bkupfilename=%1 %dt% %tm%.sql

echo Backing up to file: %bkupfilename%

mysqldump  --routines -u root -p0000  transport > D:\mysql_daily_backups\"transport%bkupfilename%"





echo on


echo delete old backup

forfiles /p D:\mysql_daily_backups /s /m *.* /d -3 /c "cmd /c del @file : date >= 3days"



echo Backup Complete! Have A Nice Day
