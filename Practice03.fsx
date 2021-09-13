let secondMaximum (l: int list): int option =
    match l with
    | [] | [_] -> None
    | _ ->
        let max = List.max l
        l |> List.filter ((<>) max) |> List.max |> Some

let input = [1; 5; 4; 7; 7; 6; 3]

match secondMaximum input with
| Some i -> printfn "%i" i
| None -> printfn "Can't find the second maximum!"
