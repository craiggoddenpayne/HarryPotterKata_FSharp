namespace HarryPotterKata.Tests
open NUnit.Framework
open HarryPotterKata

type BookTests() =
    
    [<Test>]
    member this.BookShouldHaveATitle () =
        let book = new Book "Harry Potter"
        Assert.That(book.Title, Is.EqualTo "Harry Potter")


