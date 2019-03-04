namespace MarsRover

module Rover =
    open System

    let initialPosition = (0,0,"N")
    [<Literal>]
    let pattern = "{0}:{1}:{2}"
    [<Literal>]
    let Forward = 'F'
    [<Literal>]
    let Left = 'L'
    [<Literal>]
    let Right = 'R'
    [<Literal>]
    let North = "N";
    [<Literal>]
    let West = "W";
    [<Literal>]
    let South = "S";
    [<Literal>]
    let East = "E";

    let private Increment value =
        if value < 9 then
            value + 1
        else
            0

    let private Decrement value =
        if value = 0 then
            9
        else
            value - 1

    let private MoveForward position =
        let (x,y,orientation) = position
        match orientation with
        | North ->(x,Increment y,orientation)
        | East -> (Increment x,y,orientation)
        | South -> (x,Decrement y,orientation)
        |_ -> (Decrement x,y,orientation)
        
    let private FormatReturn position =
        let (x,y,orientation) = position
        String.Format (pattern, x, y, orientation) 
    
    let private GoLeft position =
        let (x,y,orientation) = position
        match orientation with
        | North -> (x,y,West)
        | West -> (x,y,South)
        | South -> (x,y,East)
        |_ -> (x,y,North)

    let private GoRight position =
        let (x,y,orientation) = position
        match orientation with
        | South -> (x,y,West)
        | East -> (x,y,South)
        | North -> (x,y,East)
        |_ -> (x,y,North)

    let private Action (direction, position) =
        match direction with
        | Left -> GoLeft position
        | Right -> GoRight position
        |_ -> MoveForward position

    let rec Execute (position, directions:string) =
        if directions.Length = 0 then
            position
        else
            let direction = directions.Chars(0)
            Execute(Action(direction , position), directions.Substring(1))

    let Move directions =
        Execute(initialPosition, directions) 
        |> FormatReturn        