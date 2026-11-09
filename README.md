# Bicycle Rental & Mushroom Identification System

A .NET 10 Windows Forms application that combines bicycle rental fee calculation with a guided mushroom identification experience.

## Features

- Themed login screen with demo credentials
- Bicycle rental cost calculation based on starting and ending hours
- Mushroom identification using a guided yes/no question flow
- Service selection screen for navigating between modules
- Consistent responsive visual styling across all forms
- Rwandan Franc (RWF) rental fee display

## Requirements

- Windows
- Visual Studio 2026 or later
- .NET 10 SDK with Windows Forms support

## Getting Started

1. Clone the repository:

   ```bash
   git clone https://github.com/ijjoshua/Bicycle-Rental-Mushroom-Identification.git
   ```

2. Open `BicycleMushroomSystem.slnx` in Visual Studio.

3. Restore dependencies and build the solution.

4. Run the application.

## Demo Login

Use the following credentials on the login screen:

- **Username:** `admin`
- **Password:** `1234`

## Bicycle Rental Pricing

The rental fee is calculated per hour according to the time of day:

- **500 RWF/hour:** Before 07:00 and from 21:00 onward
- **1,000 RWF/hour:** 07:00–13:59 and 19:00–20:59
- **1,500 RWF/hour:** 14:00–18:59

The starting hour must be between `0` and `23`, and the ending hour must be between `1` and `24`.

## Project Structure

```text
BicycleMushroomSystem/
├── BicycleForm.cs                 # Bicycle rental calculation
├── ChooseForm.cs                  # Service selection screen
├── LoginForm.cs                   # Login screen and authentication
├── MushroomForm.cs                # Mushroom identification flow
├── UiTheme.cs                     # Shared application styling
├── Program.cs                     # Application entry point
└── BicycleMushroomSystem.csproj   # .NET project file
```

## License

This project is available for educational and demonstration purposes.
