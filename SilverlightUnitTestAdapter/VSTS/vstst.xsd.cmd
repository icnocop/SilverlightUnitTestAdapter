@echo off
set var="C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6 Tools\xsd.exe" vstst.xsd /classes /language:CS /namespace:SilverlightUnitTestAdapter.VSTS
echo %var%
%var%
echo You must manually perform the following:
echo 1. Replace all occurrences of "[][]" with "[]"
echo 2. Manually fix runtime errors "There was an error reflecting property 'Items'...
echo    See https://stackoverflow.com/questions/9721984/serialization-of-testruntype-throwing-an-exception/10872961#10872961