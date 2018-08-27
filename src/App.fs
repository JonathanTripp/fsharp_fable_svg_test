module fsharp_fable_svg_test

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser

open HtmlUtil

let renderLines () =
    (s=?"svg") ["width" => 600; "height" => 600]
        [
            (s=?"line") [ "x1" => 300; "y1" => 100; "x2" => 300; "y2" => 500; "style" => "stroke:black;stroke-width:1" ] [];
            (s=?"line") [ "x1" => 100; "y1" => 100; "x2" => 500; "y2" => 500; "style" => "stroke:blue;stroke-width:2" ] [];
            (s=?"line") [ "x1" => 100; "y1" => 500; "x2" => 500; "y2" => 100; "style" => "stroke:red;stroke-width:5" ] [];
            (s=?"line") [ "x1" => 100; "y1" => 300; "x2" => 500; "y2" => 300; "style" => "stroke:green;stroke-width:10" ] []
        ]

let error msg =
  (h=?"p") [] [
    (h=?"strong") [] [text "Error: "]
    text msg
  ] |> renderTo (document.getElementById("errors"))

let init() =
    let output = document.getElementById("output")
    renderLines() |> renderTo output

    error "Error!"

init()