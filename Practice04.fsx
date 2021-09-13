let sumOf (f: 'a -> float) = List.map f >> List.sum

let isAlmostInt (x: float) (atol: float): bool =
    let rounded = System.Math.Round x
    abs (x - rounded) < atol

let roundToInt: float -> int = System.Math.Round >> int

let input1 = [1; 3; 11; 3]
let input2 = [10; 12; 8; 4; 7]
let input3 = [2; 3; 4; 9; 5; 1; 3; 10; 4; 2]

let ans =
    [input1; input2; input3] |>
        sumOf (List.map float >> List.average)

if isAlmostInt ans 1.0e-5
then printfn "平均の合計は %d です" (roundToInt ans)
else printfn "平均の合計は %.3f です" ans
