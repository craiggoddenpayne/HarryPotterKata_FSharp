namespace HarryPotterKata.Tests
open NUnit.Framework
open HarryPotterKata

type BookRepositoryTests() = 
    
    [<Test>]
    member this.WhenCallingGetBooksItShouldReturnAll5Books () = 
        let bookRepository = new BookRepository()
        let books = bookRepository.GetAllBooks()
        Assert.That(books.Length, Is.EqualTo 5)