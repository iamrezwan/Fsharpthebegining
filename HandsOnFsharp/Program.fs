open System

type whether =
|   hot = 0
|   cold = 1
|   normal = 2

[<EntryPoint>]
let main argv =   
        let mutable myValue = 100
        printfn "Value of myValue  is %i" myValue
        myValue <- 200
        printfn "Value of myValue  is %i" myValue
        let myRefValue = ref 10
        myRefValue := 20
        printfn "Value of myValue  is %i" ! myRefValue
        let myFunction(x: int, y:int): int = x + y
        printfn "The result of myFunction is %i" (myFunction(5,5))
        let rec DoFactorial(x:int) : int = 
            if x < 1 then 1
            else x * DoFactorial(x-1)
        printfn "Result after calling DoFactorial %i" (DoFactorial 10)
        let randomList = [1;2;3;4;5]
        let newRandomList = List.map (fun x -> x + 10) randomList
        printfn "The new random list is %A" newRandomList
        [1;2;3;4;5]
        |> List.filter (fun x -> x % 2 = 0)
        |> List.map (fun x -> x * 10)
        |> printfn "My wanted numbers %A"
        
        let multiply x = x * x
        let add x = x + 1
        let addThenMulti = multiply << add
        let multiThenAdd = multiply >> add
        printfn "Calling addThenMulti %i" (addThenMulti 5)
        printfn "Calling multiThenadd %i" (multiThenAdd 5)

        let number1 = 1
        let mutable number2 = 10
        while not (number1.Equals(number2)) do
            printfn " Loop Executing"
            number2 <- number2 - 1
        for i = 10 downto 1 do 
             printfn " For Loop Executing"
        for i in [1..5] do
             printfn "Value of i is %i" i

        [1..5] |> List.iter (printfn "Piped Value %i")

        let sum = List.reduce(+) [1..5]
        printfn "Reduced Value %i" sum

        let todayWhether = whether.cold
        match todayWhether with 
        |   cold ->  printfn("Whether is Cold")
        |   hot ->  printfn("Whether is Hot")
        |   normal ->  printfn("Whether is Normal")


        Console.ReadLine() |> ignore
       
        0
  
