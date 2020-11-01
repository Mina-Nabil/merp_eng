cd /d "C:\Program Files\MySQL\MySQL Server 5.7\bin " 
 set bkupfilename= DB_24_8_2017.sql
 mysqldump  --routines -u root -p0000  merp > C:\Users\Morie\Desktop\trial\"MERP%bkupfilename%" 
 forfiles /p D:\mysql_daily_backups /s /m *.* /d -3 /c "cmd /c del @file : date >= 3days" 
 timeout /t -1 

