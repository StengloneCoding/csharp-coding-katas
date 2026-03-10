# C# Coding Katas

A collection of classic coding katas implemented in **C#** with **xUnit tests**.  
This repository is intended for practicing algorithmic problem-solving, Clean Code principles and Test-Driven Development (TDD).

---

## 🛠 Tech Stack

- **Language:** C#
- **Framework:** .NET 9.0
- **Testing:** xUnit

---

## 🧩 Implemented Katas

| Category | Kata | Test Status |
| :--- | :--- | :--- |
| **Basics** | FizzBuzz | ✅ Passed |
| **Strings** | Anagram | ✅ Passed |
| **Strings** | First Unique Character | ✅ Passed |
| **Strings** | Palindrome | ✅ Passed |
| **Arrays** | Two Sum | ✅ Passed |

---

## 📂 Project Structure

The solution is separated into the logic project (**CodingKatas**) and the test project (**CodingKatas.Tests**):

```text
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
```

---

## 🚀 Running the Tests

To run all tests from the command line, execute the following command in the root directory:

```bash
dotnet test
```

Alternatively, tests can be run directly via the **Test Explorer** in Visual Studio.

---

## 🎯 Learning Goals

- **Problem Solving:** Break complex problems into small, testable steps.
- **TDD:** Follow the *Red–Green–Refactor* development cycle.
- **Clean Code:** Focus on readability and maintainability.
- **Data-Driven Testing:** Consistent use of xUnit **[Theory]** and **[InlineData]** to efficiently validate logic with multiple input values.
