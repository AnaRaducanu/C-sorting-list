@echo off

set "relativePath=%~1"

start "" "%~dp0bin\Debug\net5.0\NameSortingAlgorithm.exe" "%relativePath%"