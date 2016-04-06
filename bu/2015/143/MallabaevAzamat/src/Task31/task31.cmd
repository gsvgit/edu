copy ..\Task15\task15.fst task15.fst
copy ..\Task30\task30.fst task30.fst
fstar --codegen FSharp task15.fst task30.fst task31.fst
copy ..\common\prims.fs prims.fs
fsc --target:library prims.fs task15.fs task30.fs task31.fs
pause
