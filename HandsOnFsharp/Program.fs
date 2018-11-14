open System
[<EntryPoint>]
let main argv =   
        let mutable myValue = 100
        printfn "Value of myValue  is %i" myValue
        myValue <- 200
        printfn "Value of myValue  is %i" myValue
        let myRefValue = ref 10
        myRefValue := 20
        printfn "Value of myValue  is %i" ! myRefValue
        Console.ReadLine() |> ignore       
        0
  