#r "nuget: Giraffe.ViewEngine, 1.4.0"
open Giraffe.ViewEngine

#r "nuget: System.Text.Json"
open System.Text.Json

let _ = 1 |> JsonSerializer.Serialize

let export() =
    html [] [
        head [] [
        ]
        body [] [
            header [] [
                str "Saasdassasdsadsadasadasdasmple page"
            ]
        ]
    ]
