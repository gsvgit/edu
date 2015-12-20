copy ..\Task15\task15.fst task15.fst
fstar --codegen FSharp task15.fst task30.fst
copy ..\common\prims.fs prims.fs
fsc --target:library prims.fs task15.fs task30.fs
pause
