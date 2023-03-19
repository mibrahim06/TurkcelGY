using Constructors;

/**
 * This is a simple example of how to use constructors
 */

// Create a new book object with default constructor
Book noTitle = new Book();
noTitle.PrintBook();

// Create a new book object with parameterized constructor
Book harryPotter = new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 223, 1997, "Bloomsbury", "9780747532743", "English");
harryPotter.PrintBook();

// Create a new book object with default constructor and set the properties
Book lordOfTheRings = new Book();
lordOfTheRings.SetTitle("The Lord of the Rings");
lordOfTheRings.SetAuthor("J.R.R. Tolkien");
lordOfTheRings.SetPages(1216);
lordOfTheRings.SetYear(1954);
lordOfTheRings.SetIsbn("9780544003415");
lordOfTheRings.SetPublisher("Allen & Unwin");
lordOfTheRings.SetLanguage("English");
lordOfTheRings.PrintBook();
