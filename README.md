# Survey_UP

Aplikacja webowa typu CRUD do zarządzania **ankietami ewaluacyjnymi studentów**, zbudowana w ramach pracy inżynierskiej. Umożliwia tworzenie ankiet, zarządzanie pytaniami i odpowiedziami, zapraszanie głosujących oraz przeglądanie zbiorczych wyników.

## Stack technologiczny

- **.NET 5** / **ASP.NET Core 5** (Razor Pages)
- **Entity Framework Core 5** (Code-First + Migrations)
- **Microsoft SQL Server** (produkcja) / **SQLite** (opcjonalnie)
- **ASP.NET Core Identity** — rejestracja, logowanie, role
- **Bootstrap** + jQuery (warstwa UI, `wwwroot/`)

## Struktura projektu

| Katalog | Opis |
|---|---|
| `Pages/` | Widoki Razor Pages (Surveys, Questions, Answers, Voters, Users, Roles, Public, Shared) |
| `Models/Tables/` | Encje EF Core (`VtsTb*`, `ApplicationUser`, `ApplicationRole`, …) |
| `Models/Context/` | Dwa `DbContext`: `N3mikosContext` (dane domenowe) i `SurveyUpIdDbContext2` (Identity) |
| `Migrations/` | Migracje EF Core dla obu kontekstów |
| `Areas/Identity/` | Scaffoldowane strony logowania/rejestracji |
| `Services/` | `EmailSender` (SMTP) |
| `Data/` | Helpery i enumy (np. `Roles`) |
| `wwwroot/` | Zasoby statyczne (CSS, JS, obrazy, biblioteki) |

## Wymagania

- [.NET SDK 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
- Microsoft SQL Server (lokalny, LocalDB lub kontener Docker)
- (Opcjonalnie) narzędzie `dotnet-ef`:
  ```bash
  dotnet tool install --global dotnet-ef --version 5.0.*
  ```

## Konfiguracja

1. Skopiuj plik `appsettings.json` do lokalnego `appsettings.Development.json` (plik ten jest w `.gitignore`).
2. Uzupełnij `ConnectionStrings:DefaultConnection` swoim connection stringiem do SQL Server, np.:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=SurveyUP;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```
3. Uzupełnij dane SMTP w sekcji `EmailSender` (host, port, login, hasło).

> **Uwaga bezpieczeństwa:** Nie commituj rzeczywistych haseł i connection stringów. Używaj [User Secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets):
> ```bash
> dotnet user-secrets set "ConnectionStrings:DefaultConnection" "..."
> dotnet user-secrets set "EmailSender:Password" "..."
> ```

## Uruchomienie

```bash
# 1. Klon i wejście do katalogu
git clone <repo-url>
cd Survey_UP

# 2. Restore zależności
dotnet restore

# 3. Aplikacja migracji – dwa osobne konteksty
dotnet ef database update --context SurveyUpIdDbContext2
dotnet ef database update --context N3mikosContext

# 4. Start aplikacji
dotnet run
```

Aplikacja domyślnie nasłuchuje pod:
- `https://localhost:5001`
- `http://localhost:5000`

### Alternatywnie – Visual Studio / Rider

Otwórz `SurveyUP.sln` i uruchom profil **SurveyUP** (albo **IIS Express**). Profile znajdują się w `Properties/launchSettings.json`.

## Migracje EF Core

Projekt korzysta z **dwóch** `DbContext`, dlatego każdą operację EF trzeba wskazać flagą `--context` (CLI) lub `-Context` (Package Manager Console).

```bash
# Dodanie nowej migracji
dotnet ef migrations add <Nazwa> --context N3mikosContext
dotnet ef migrations add <Nazwa> --context SurveyUpIdDbContext2

# Aktualizacja bazy
dotnet ef database update --context N3mikosContext
dotnet ef database update --context SurveyUpIdDbContext2
```

## Role i pierwsze logowanie

Role są zdefiniowane w `Data/Enums/Roles.cs`. Konta użytkowników zakłada się przez `/Identity/Account/Register` — konto wymaga potwierdzenia mailem (opcja `RequireConfirmedAccount = true` w `Startup.cs`).

## Build / Publish

```bash
dotnet build -c Release
dotnet publish -c Release -o ./publish
```

## Licencja

Projekt studencki (praca inżynierska). Do celów edukacyjnych.
