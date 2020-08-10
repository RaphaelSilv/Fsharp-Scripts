// ===================
// Description:
// Says hello.

open System

let helloWorld name =
    printfn "Hello, %s" name

match fsi.CommandLineArgs with
    | [| scriptName; name; |] ->
        printfn "running script: %s" scriptName
        helloWorld name
    | _->
        printfn "USAGE: [name]"