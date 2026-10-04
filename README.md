# Shop Billing System (Windows Forms)

A C# Windows Forms desktop app for a small shop. The cashier adds items to a bill, the app calculates the total with a 10% discount, and every action is written to a live activity log. The project is built to show how **delegates and events** work in C#.

## Features

- Add items with product name, quantity and price
- Items show in a grid with an automatic item total (quantity x price)
- **Calculate Total** shows the subtotal, the 10% discount, the final total and the bill date and time
- **Remove Selected** deletes one item from the bill
- **Clear All** resets the whole bill
- Live **activity log** with a timestamp for every action
- Status label that shows the latest action
- Input validation with clear warning messages

## Concepts Used

### 1. Custom delegate
`ValidateItemDelegate` is a delegate type that points to the validation method. Before an item is added, the delegate checks that the product name is not empty and that quantity and price are greater than 0.

### 2. Func delegate
`DiscountCalculator` is a `Func<double, double>` property. It takes the subtotal and returns the discounted total (10% off). Because it is a delegate, the discount rule can be swapped without changing the rest of the code.

### 3. Events
The form raises three events:

| Event | Raised when |
|---|---|
| `OnItemAdded` | An item is added to the bill |
| `OnBillCalculated` | The total is calculated |
| `OnBillCleared` | The bill is cleared |

### 4. Observer pattern
The form only announces *what happened*. Other parts of the app subscribe to those events and react on their own:
- `BillingLogger` writes entries to the activity log
- The status label updates with the latest action

The form does not need to know how logging works, which keeps the code loosely coupled.

### 5. Lambda expressions
Short inline handlers are used for the discount rule and for the status label updates.

### 6. Separate logger class
`BillingLogger` receives an `Action<string>` in its constructor and uses it to write messages. It doesn't depend on any specific control, so it can be reused and tested on its own.

### 7. Thread-safe UI updates
The log and status label use `InvokeRequired` and `Invoke` so they are safe to update from any thread.

### 8. Exception handling
Every button handler is wrapped in `try/catch` and uses `TryParse` for numbers, so bad input shows a message instead of crashing the app.

## Project Structure

| File | Purpose |
|---|---|
| `Program.cs` | App entry point |
| `Form1.cs` | Main form, button logic, delegates and events |
| `Form1.Designer.cs` | Auto-generated form layout |
| `BillingLogger.cs` | Subscribes to events and writes log messages |

## How to Run

1. Install Visual Studio with the **.NET desktop development** workload.
2. Open the solution file.
3. Press **F5** to build and run.

## Built With

- C#
- .NET (Windows Forms)

## About

Made as a homework project at the University of the Punjab.
