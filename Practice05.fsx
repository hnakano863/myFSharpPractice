let fuzzyStartsWith (pat: string) (s: string): bool =
    s.ToLower().StartsWith(pat.ToLower())

let fuzzySearch pat = List.filter (fuzzyStartsWith pat)

let input = [
    "TLV"
    "tlv様"
    "ミヤワキ様"
    "テイエルブイ様"
    "tlv御中"
    "株式会社TLV"
]

let name = "Tlv"

printfn "TLV"
for x in fuzzySearch name input do
    printfn "  %s" x
