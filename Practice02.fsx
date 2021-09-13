open System.Text.RegularExpressions

let input =
    "<h2>注文明細</h2><div>金額: <div>5000</div>円</div>"

let maybeMatch pat s =
    let m = Regex(pat).Match(s)
    if m.Success then Some m else None

let maybeGetGroup (m: Match) (g: string): string option =
    let item = m.Groups.Item g
    if item.Success then Some item.Value else None

let getAmount input =
    let pat = @"^.*?<div>.*?(?<amount><div>.*?</div>.*?)</div>.*?$"
    match maybeMatch pat input with
    | Some m ->
        match maybeGetGroup m "amount" with
        | Some item -> item
        | None -> "no amount"
    | None -> "input string is invalid"

printfn "%s" (getAmount input)
