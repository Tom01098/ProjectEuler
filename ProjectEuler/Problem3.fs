module Problem3

    let rec LargestPrimeFactor n div =
        if n = div then n
        elif n % div = 0L then LargestPrimeFactor (n / div) div
        else LargestPrimeFactor n (div + 1L)

    let Run = LargestPrimeFactor 600851475143L 2L