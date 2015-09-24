<<<<<<< HEAD
echo off
for /r .\2015\143 %%i in (build.cmd) do (
  if EXIST %%i (
     Pushd %%~pi
     Echo now in %%~pi
     call %%i "All"
     Popd
  ) 
=======
echo off
for /r .\2015\143 %%i in (build.cmd) do (
  if EXIST %%i (
     Pushd %%~pi
     Echo now in %%~pi
     %%i "All"
     Popd
  ) 
>>>>>>> gsvgit/master
)