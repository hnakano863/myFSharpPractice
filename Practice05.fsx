let fuzzyStartsWith (pat: string) (s: string): bool =
    s.Trim().ToLower().StartsWith(pat.ToLower())

let fuzzySearch pat = List.filter (fuzzyStartsWith pat)

let input = [
    "TLV"
    "  tlv様"
    "ミヤワキ様  "
    "テイエルブイ様  "
    "  tlv御中  "
    " 株式会社TLV "
]

let name = "Tlv"

for x in fuzzySearch name input do
    printfn "%s" x
