﻿module Task23

let swap i j (arr: int array) =
    let tmp = arr.[i]
    arr.[i] <- arr.[j]
    arr.[j] <- tmp

let pivotDance(arr: int array, left, right, pivotNumber) = 
    let pivot = arr.[pivotNumber]
    swap pivotNumber right arr

    let mutable tempNumber = left
    for i = left to right - 1 do
        if arr.[i] <= pivot then 
            swap i tempNumber arr
            tempNumber <- tempNumber + 1
    swap tempNumber right arr
    tempNumber

let main (arr: int array) =
    let rec sort (arr, left, right) =
        if left < right then
            let pivotNumber = (left + right) / 2
            let pivotNumber2 = pivotDance(arr, left, right, pivotNumber)
            sort(arr, left, pivotNumber2 - 1) 
            sort(arr, pivotNumber2 + 1, right)

    sort(arr, 0, arr.Length - 1)
    arr