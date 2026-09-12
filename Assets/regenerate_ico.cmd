@echo off
:: Icon Regenerator - Batch file
:: Regenerates all icon files from JPG source

:: Determine the script directory (where this batch file resides)
set SCRIPT_DIR=%~dp0
cd /d "%SCRIPT_DIR%"

:: Run the Python script
python regenerate_ico.py

echo.
echo Icon regeneration complete.
pause