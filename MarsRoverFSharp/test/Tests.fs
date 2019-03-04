module Tests

open System
open Xunit
open MarsRover

[<Fact>]
let ``Rover should return "0:0:N" when receive ""`` () =
    let position  = Rover.Move ""
    Assert.Equal("0:0:N", position)

[<Fact>]
let ``Rover should return "1:0:N" when receive "F"`` () =
    let position  = Rover.Move "F"
    Assert.Equal("0:1:N", position)

[<Fact>]
let ``Rover should return "0:2:N" when receive "FF"`` () =
    let position  = Rover.Move "FF"
    Assert.Equal("0:2:N", position)

[<Fact>]
let ``Rover should return "0:3:N" when receive "FFF"`` () =
    let position  = Rover.Move "FFF"
    Assert.Equal("0:3:N", position)

[<Fact>]
let ``Rover should return "0:0:W" when receive "L"`` () =
    let position  = Rover.Move "L"
    Assert.Equal("0:0:W", position)

[<Fact>]
let ``Rover should return "0:0:S" when receive "LL"`` () =
    let position  = Rover.Move "LL"
    Assert.Equal("0:0:S", position)

[<Fact>]
let ``Rover should return "0:0:E" when receive "LLL"`` () =
    let position  = Rover.Move "LLL"
    Assert.Equal("0:0:E", position)

[<Fact>]
let ``Rover should return "0:0:N" when receive "LLLL"`` () =
    let position  = Rover.Move "LLLL"
    Assert.Equal("0:0:N", position)

[<Fact>]
let ``Rover should return "0:0:E" when receive "R"`` () =
    let position  = Rover.Move "R"
    Assert.Equal("0:0:E", position)

[<Fact>]
let ``Rover should return "0:0:S" when receive "RR"`` () =
    let position  = Rover.Move "RR"
    Assert.Equal("0:0:S", position)

[<Fact>]
let ``Rover should return "0:0:W" when receive "RRR"`` () =
    let position  = Rover.Move "RRR"
    Assert.Equal("0:0:W", position)

[<Fact>]
let ``Rover should return "0:0:N" when receive "RRRR"`` () =
    let position  = Rover.Move "RRRR"
    Assert.Equal("0:0:N", position)

[<Fact>]
let ``Rover should return "1:0:E" when receive "RF"`` () =
    let position  = Rover.Move "RF"
    Assert.Equal("1:0:E", position)

[<Fact>]
let ``Rover should return "0:9:S" when receive "RRF"`` () =
    let position  = Rover.Move "RRF"
    Assert.Equal("0:9:S", position)

[<Fact>]
let ``Rover should return "9:0:W" when receive "RRRF"`` () =
    let position  = Rover.Move "RRRF"
    Assert.Equal("9:0:W", position)

[<Fact>]
let ``Rover should return "0:0:N" when receive "FFFFFFFFFF"`` () =
    let position  = Rover.Move "FFFFFFFFFF"
    Assert.Equal("0:0:N", position)

[<Fact>]
let ``Rover should return "0:0:E" when receive "RFFFFFFFFFF"`` () =
    let position  = Rover.Move "RFFFFFFFFFF"
    Assert.Equal("0:0:E", position)