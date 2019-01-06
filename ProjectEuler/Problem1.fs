module Problem1
    
    let IsDivisibleBy3Or5 n = n % 3 = 0 || n % 5 = 0

    let SumOfMultiplesTo n =
        [1..n-1]
        |> List.filter IsDivisibleBy3Or5
        |> List.sum

    let Run = SumOfMultiplesTo 1000