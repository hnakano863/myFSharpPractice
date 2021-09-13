let fizzBuzz i =
    let fizz x = x % 3 = 0
    let buzz x = (string x).Contains "5"
    match (fizz i, buzz i) with
    | (true, true) -> "FizzBuzz"
    | (true, _) -> "Fizz"
    | (_, true) -> "Buzz"
    | _ -> string i


for i = 1 to 200 do
    printfn $"{i}: {fizzBuzz i}"
