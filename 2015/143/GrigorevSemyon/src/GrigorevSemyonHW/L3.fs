// add references to System.Drawing, System.Windows.Forms, System.Windows.Forms.DataVisualization
// https://msdn.microsoft.com/en-us/library/vstudio/hh297101(v=vs.100).aspx
// http://fslab.org/FSharp.Charting/PointAndLineCharts.html
module L3

open FSharp.Charting

let gch = Chart.Line [for x in 1.0 .. 100.0 -> x * x * sin x]
do System.Windows.Forms.Application.Run(gch.ShowChart())

