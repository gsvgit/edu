module Task12

let mlt_matrix (matrix1:int [,]) (matrix2:int [,]) = 
    let a = matrix1.[0,0] * matrix2.[0,0] + matrix1.[0,1] * matrix2.[1,0]
    let b = matrix1.[0,0] * matrix2.[0,1] + matrix1.[0,1] * matrix2.[1,1]
    let c = matrix1.[1,0] * matrix2.[0,0] + matrix1.[1,1] * matrix2.[1,0]
    let d = matrix1.[1,0] * matrix2.[0,1] + matrix1.[1,1] * matrix2.[1,1]
    let result = array2D [|[|a;b|];[|c;d|]|]
    result

let rec fib n (matrix:int [,]) = 
    if n < 2 
    then matrix
    elif n % 2 = 0
    then  
        mlt_matrix (fib (n / 2) matrix) (fib(n / 2) matrix) 
    else
        mlt_matrix matrix (mlt_matrix (fib ((n - 1) / 2) matrix) (fib((n - 1) / 2 ) matrix))
          
let main n = 
    let matrix = array2D [|[|0;1|];[|1;1|]|]
    (fib n matrix).[0,1]