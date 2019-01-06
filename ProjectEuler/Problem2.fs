module Problem2

    let rec fib x y max =
        let sum = x + y

        if sum > max then 0
        elif sum % 2 = 1 then fib y sum max
        else sum + fib y sum max

    let Run = fib 0 1 4000000