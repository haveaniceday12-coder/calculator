# Calculator

A console calculator written in C#. You enter two numbers and an operator, and
it prints the result.

## How it works
- Supports `+`, `-`, `*` and `/`.
- Numbers can be negative or have decimals (parsed with `double.TryParse`).
- If you enter an invalid number or operator, it tells you and asks again
  instead of crashing.
- After each calculation you can choose to do another one.
- Dividing by zero prints `Infinity`, which is how `double` behaves in C#.

## Run it
    dotnet run

## Example
    Enter first number:
    12.5
    Enter operator (+, - , *, /):
    *
    Enter second number:
    4
    12.5 * 4 = 50
    Do you want to do another calculation?
    no

## What I learned
- Validating input with `double.TryParse` so bad input never crashes the program
- Using a flag variable (`incorrectChoice`) with a `do/while` loop to re-ask
- Splitting logic into methods (`Calculate`, `AskForAnotherCalculation`)
- `switch` statements, and the `?? ""` operator to handle null input

## Planned improvements
- Show a clear message for division by zero instead of `Infinity`
- Accept "y" as well as "yes" when asked to continue
- Support more operators, such as modulo and powers