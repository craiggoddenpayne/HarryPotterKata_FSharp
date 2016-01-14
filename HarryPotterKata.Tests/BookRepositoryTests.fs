namespace HarryPotterKata.Tests
open NUnit.Framework
open HarryPotterKata

type BookRepositoryTests() = 
    let bookRepository = new BookRepository()

    [<Test>]
    member this.WhenCallingGetBooksItShouldReturnAll5Books () = 
        let books = bookRepository.GetAllBooks()
        Assert.That(books.Length, Is.EqualTo 5)