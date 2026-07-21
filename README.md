# Expense Analyzer

Expense Analyzer imports a CSV bank statement, groups transactions into spending categories and generates a summary.

The demo version uses an in-memory statement but the architecture can be connected to real CSV files.

---

## Workflow

CSV Statement

↓

Import Transactions

↓

Category Detection

↓

Statistics

↓

Console Report

---

## Example

```
Importing statement...

Transactions loaded : 7

Food
$82.40

Transport
$19.50

Shopping
$145.99

Utilities
$56.00

-----------------------

Total expenses : $303.89
```

Run

```
dotnet run
```
