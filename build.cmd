echo off
for /r .\2015\143 %%i in (build.cmd) do (
  if EXIST %%i (
     Pushd %%~pi
     Echo now in %%~pi
     %%i "All"
     Popd
  ) 
)