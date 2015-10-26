@echo off
cls

.paket\paket.bootstrapper.exe
if %errorlevel% neq 0 (
  exit  %errorlevel%
)

.paket\paket.exe restore
if %errorlevel% neq 0 (
  exit  %errorlevel%
)

IF NOT EXIST build.fsx (
  .paket\paket.exe update
  packages\FAKE\tools\FAKE.exe init.fsx
)
packages\FAKE\tools\FAKE.exe build.fsx %*
if %errorlevel% neq 0 (
  exit  %errorlevel%
)