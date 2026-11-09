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

## Mushroom Identification Guide

The application supports identification of six mushrooms through a guided yes/no questionnaire:

| Mushroom | Identification path in the application |
| --- | --- |
| **Agaric Jaunissant** | Does not grow in the forest and has a convex cap |
| **Coprin chevelu** | Does not grow in the forest and does not have a convex cap |
| **Amanite tue-mouche** | Grows in the forest, has a convex cap, and has a ring |
| **Pied bleu** | Grows in the forest, has a convex cap, and does not have a ring |
| **Girolle** | Grows in the forest, does not have a convex cap, and has gills |
| **Cepe de Bordeaux** | Grows in the forest, does not have a convex cap, and does not have gills |

### Decision Logic

The identification flow asks these questions in order:

1. **Does it grow in the forest?**
   - **No:** Ask whether it has a convex cap.
	 - **Yes:** Identify it as **Agaric Jaunissant**.
	 - **No:** Identify it as **Coprin chevelu**.
   - **Yes:** Ask whether it has a convex cap.
2. **Does it have a convex cap?**
   - **Yes:** Ask whether it has a ring.
	 - **Yes:** Identify it as **Amanite tue-mouche**.
	 - **No:** Identify it as **Pied bleu**.
   - **No:** Ask whether it has gills.
	 - **Yes:** Identify it as **Girolle**.
	 - **No:** Identify it as **Cepe de Bordeaux**.

The questions are displayed as Yes/No dialog boxes, and the identified mushroom is shown in a result message after the final answer.

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
