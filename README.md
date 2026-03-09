# C# Coding Katas

Eine Sammlung klassischer Coding-Katas, implementiert in **C#** mit **xUnit Tests**. Dieses Repository dient dem Training von algorithmischem Problemlösen, Clean Code und Test-Driven Development (TDD).

---

## 🛠 Tech Stack

* **Sprache:** C#
* **Framework:** .NET 9.0
* **Testing:** xUnit

---

## 🧩 Implementierte Katas

| Kategorie | Kata | Test-Status |
| :--- | :--- | :--- |
| **Basics** | FizzBuzz | ✅ Bestanden |
| **Strings** | Anagram | ✅ Bestanden |
| **Strings** | First Unique Character | ✅ Bestanden |
| **Strings** | Palindrome | ✅ Bestanden |
| **Arrays** | Two Sum | ✅ Bestanden |

---

## 📂 Projektstruktur

Die Solution ist in das Logik-Projekt (CodingKatas) und das Test-Projekt (CodingKatas.Tests) unterteilt:

csharp-coding-katas
├── CodingKatas
│   ├── Arrays
│   │   └── TwoSum.cs
│   ├── Basics
│   │   └── FizzBuzz.cs
│   └── Strings
│       ├── Anagram.cs
│       ├── FirstUniqueCharacter.cs
│       └── Palindrome.cs
└── CodingKatas.Tests
    ├── Arrays
    │   └── TwoSumTests.cs
    ├── Basics
    │   └── FizzBuzzTests.cs
    └── Strings
        ├── AnagramTests.cs
        ├── FirstUniqueCharacterTests.cs
        └── PalindromeTests.cs

---

## 🚀 Ausführung

Um alle Tests in der Konsole auszuführen, nutze folgenden Befehl im Hauptverzeichnis:

dotnet test

Alternativ können die Tests direkt über den Test-Explorer in Visual Studio gestartet werden.

---

## 🎯 Lernziele

* **Problem Solving:** Komplexe Aufgaben in kleine, testbare Schritte zerlegen.
* **TDD:** Entwicklung nach dem "Red-Green-Refactor"-Prinzip.
* **Clean Code:** Fokus auf Lesbarkeit und Wartbarkeit des Codes.
* **Data-Driven Testing:** Konsequente Nutzung von xUnit **[Theory]** und **[InlineData]**, um Logik mit verschiedenen Eingabewerten effizient zu validieren.

---
