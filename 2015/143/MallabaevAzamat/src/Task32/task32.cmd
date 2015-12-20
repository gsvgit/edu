@echo off
copy ..\Task15\task15.fst task15.fst
copy ..\Task30\task30.fst task30.fst
copy ..\Task31\task31.fst task31.fst
echo fstar --codegen FSharp task15.fst task30.fst task31.fst task32.fst
fstar --codegen FSharp task15.fst task30.fst task31.fst task32.fst
copy ..\common\prims.fs prims.fs
echo fsc --target:library prims.fs task15.fs task30.fs task31.fs task32.fs fspart.fs
copy ..\..\packages\FSharp.Charting\lib\net40\FSharp.Charting.dll FSharp.Charting.dll
fsc --nowarn:25 --nowarn:62 --nowarn:82 --target:exe prims.fs task15.fs task30.fs task31.fs task32.fs fspart.fs -r:System.Drawing.dll -r:System.Windows.Forms.dll -r:System.Windows.Forms.DataVisualization.dll -r:FSharp.Charting.dll
pause
