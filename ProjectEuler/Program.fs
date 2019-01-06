// Learn more about F# at http://fsharp.org

open System

let RunProblem f n =
    printfn "Problem %i: %i" n f

[<EntryPoint>]
let main argv =
    RunProblem Problem1.Run 1
    RunProblem Problem2.Run 2
    Console.ReadKey() |> ignore
    0
