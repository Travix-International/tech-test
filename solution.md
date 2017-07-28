# Solution.md
//ulr shortening algorithm (here coded in fsharp)
//taken from: https://stackoverflow.com/questions/742013/how-to-code-a-url-shortener/742047#742047 and reworked


```fs
//an example alphabet
let Alphabet = [for i in 48..90 do yield (char)i] |> Seq.toArray

let rec generateDigits 
    (alphabet: char array) 
    (accumulator : string list * int) 
    : string =
        let counterBase = alphabet.Length
        let digits, num = accumulator
        if num > 0 then
            let remainder = num % counterBase
            let d = alphabet.[remainder].ToString() :: digits |> List.rev
            let n = num / counterBase
            generateDigits alphabet (d,n)
        else
            digits |> Seq.fold (+) ""

```
