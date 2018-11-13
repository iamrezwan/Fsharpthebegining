open System

[<EntryPoint>]
let main argv =   
        printfn "Hello what is your name"         
        let name = Console.ReadLine() 
        printfn "You said your name is %s" name
        Console.ReadLine() |> ignore
        0
   
