module Problem6

    let square x = x * x

    let SumOfSquares n = 
        [1..n]
        |> List.map square
        |> List.sum

    let SquareOfSum n = 
        [1..n]
        |> List.sum
        |> square

    let Run = SquareOfSum 100 - SumOfSquares 100