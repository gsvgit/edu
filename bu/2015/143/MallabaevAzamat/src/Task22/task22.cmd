copy ..\Task15\task15.fst task15.fst
fstar --codegen FSharp task15.fst task22.fst
fsc --target:library task15.fs task22.fs
pause
