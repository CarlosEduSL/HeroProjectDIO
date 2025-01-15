# HeroProjectDIO

## Description
This project implements a hero class system that simulates different types of heroes (Mage, Warrior, Monk, and Ninja) and their unique attack patterns. It was developed as part of Digital Innovation One's C# programming challenge, focusing on Object-Oriented Programming concepts.

## Features
- Hero class with properties for name, age, and type
- Dynamic attack system based on hero type
- Support for multiple hero types:
  - Mage (uses magic)
  - Warrior (uses sword)
  - Monk (uses martial arts)
  - Ninja (uses shuriken)

## Technologies Used
- C#
- .NET
- Object-Oriented Programming

## Class Structure
The project consists of two main classes:
1. **Hero Class**: Contains properties and methods for hero management
   - Properties: Name, Age, Type
   - Methods: Attack()
2. **Program Class**: Contains the main program execution logic

## How It Works
The Hero class uses a switch-case structure to determine the attack type based on the hero's classification. When the Attack() method is called, it displays a message showing which attack the hero used, following this pattern:

```
"O {Type} atacou usando {attackDescription}"
```

## Examples

```
Hero mage = new Hero("Gandalf", 150, "Mago");
mage.Attack(); // Output: "O Mago atacou usando magia"
Hero warrior = new Hero("Aragorn", 87, "Guerreiro");
warrior.Attack(); // Output: "O Guerreiro atacou usando espada"
```
## Prerequisites
- .NET SDK
- Any C# IDE (Visual Studio, VS Code, etc.)

## Learning Objectives
This project demonstrates understanding of:
- Classes and Objects
- Properties and Methods
- Constructors
- Switch-Case Statements
- String Interpolation
- Basic C# Syntax

## Author
[Carlos Lima]

## Acknowledgments
- Digital Innovation One (DIO) for the project challenge
- [Felipao] for the guidance

---
⭐ Feel free to star this repository if you found it helpful!
