﻿using USFLibrary;

var library = new Library();

// --- Seed Books ---
var b1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
var b2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
var b3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);
library.AddBook(b1);
library.AddBook(b2);
library.AddBook(b3);

// --- Seed Patrons ---
var s1 = new Student("Faisal", "faisal@usf.edu", "S001", "Business Analytics", 2026);
var s2 = new Student("Jonathan", "jonathan@usf.edu", "S002", "Information Systems", 2025);
var staff1 = new Staff("Hongxu", "hongxu@usf.edu", "ST001", "Librarian", "Library Services");
library.AddPatron(s1);
library.AddPatron(s2);
library.AddPatron(staff1);

// --- Display initial state ---
library.DisplayBooks("Books in Library:");
library.DisplayPatrons("Patrons in Library:");

// --- Borrow scenario ---
System.Console.WriteLine("Borrowing Books...");
System.Console.WriteLine(library.Borrow("Faisal", "Business Insights with AI"));
System.Console.WriteLine(library.Borrow("Jonathan", "Analytics in Action"));
System.Console.WriteLine();

// --- Display after borrowing ---
library.DisplayBooks("Books after borrowing:\nBooks in Library:");
