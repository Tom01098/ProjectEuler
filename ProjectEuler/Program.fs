// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Problem #1: %i" Problem1.Run
    printfn "Problem #2: %i" Problem2.Run
    printfn "Problem #3: %i" Problem3.Run 
    Console.ReadKey() |> ignore
    0
