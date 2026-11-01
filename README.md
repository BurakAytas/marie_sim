# MARIE Simulator (C# WinForms)

A small Windows Forms application that simulates the MARIE computer (the teaching architecture from *The Essentials of Computer Organization and Architecture*). It was written for a computer architecture course; the course report is in `docs/`.

## What MARIE is

MARIE is a simple 16-bit accumulator machine with 4096 words of memory (12-bit addresses). An instruction is one hex digit of opcode followed by a 12-bit address/operand. The simulator shows the registers AC, IR, MAR, MBR and PC, the memory table and the label (tag) table, and runs a program with the Fetch / Decode / Get-operand cycle.

## Supported instructions

Read from the code (`Form1.cs`):

| Mnemonic | Opcode | Behavior in the simulator |
|---|---|---|
| `Jns X` | 0 | store PC at X, jump to X+1 |
| `Load X` | 1 | AC = M[X] |
| `Store X` | 2 | M[X] = AC |
| `Add X` | 3 | AC = AC + M[X] |
| `Subt X` | 4 | AC = AC - M[X] |
| `Input` | 5 | AC = value of the input text box |
| `Output` | 6 | show AC in the output register label |
| `Halt` | 7 | stop and show a message box |
| `Skipcond X` | 8 | skip next instruction: `000` if AC < 0, `400` if AC = 0, `800` if AC > 0 |
| `Jump X` | 9 | PC = X |
| `Clear` | A | AC = 0 |
| `AddI X` | B | AC = AC + M[M[X]] |
| `JumpI X` | C | PC = M[X] |
| `LoadI X` | D | AC = M[M[X]] |
| `StoreI X` | E | M[M[X]] = AC |

Pseudo-instructions: `ORG <hex address>` (must be the first line) and `END` (last line).

## Program format

One item per line, tokens separated by a single space:

- First line: `ORG <hex start address>`
- Instruction: `Mnemonic operand`, where the operand is a label or a 3-digit hex address. `Halt`, `Output`, `Input` and `Clear` take no operand.
- Data: `Label DEC <decimal value>` or `Label HEX <hex value>`
- Last line: `END`

Labels get the address of the line they are on, counted from the `ORG` address.

### Sample program (adds 5 and 7)

```
ORG 100
Load X
Add Y
Store Z
Output
Halt
X DEC 5
Y DEC 7
Z HEX 0
END
```

Load it, press Run: AC ends as hex `00C` (12) and is shown in the output register.

## How to run

Visual Studio:

1. Open `WindowsFormsApp1.sln` (the project targets .NET Framework 4.6.1).
2. Build and run (F5).

Command line (the `Microsoft.NETFramework.ReferenceAssemblies` package supplies the reference assemblies, so no targeting pack is needed):

```
dotnet build WindowsFormsApp1.sln
WindowsFormsApp1\bin\Debug\net461\WindowsFormsApp1.exe
```

Then type a program in the commands box, press the load button, and run it.

## Repository layout

```
WindowsFormsApp1/          Form1 (UI and execution), Model/ (Command, Memory, Tag)
docs/                      Course report (docx)
```
