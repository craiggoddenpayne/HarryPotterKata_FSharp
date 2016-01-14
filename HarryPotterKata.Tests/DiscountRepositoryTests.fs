namespace HarryPotterKata.Tests
open NUnit.Framework
open HarryPotterKata

type DiscountRepositoryTests() = 
    let discountRepository = new DiscountRepository()

    [<Test>]
    member this.WhenCallingGetDiscountFor1BookItShouldReturn0() = 
        let bookCount = 1
        let result = discountRepository.GetDiscountFor(bookCount)
        Assert.That(result, Is.EqualTo 0)
    
    [<Test>]
    member this.WhenCallingGetDiscountFor2BooksItShouldReturn5() = 
        let bookCount = 2
        let result = discountRepository.GetDiscountFor(bookCount)
        Assert.That(result, Is.EqualTo 5)

    [<Test>]
    member this.WhenCallingGetDiscountFor3BooksItShouldReturn10() = 
        let bookCount = 3
        let result = discountRepository.GetDiscountFor(bookCount)
        Assert.That(result, Is.EqualTo 10)

    [<Test>]
    member this.WhenCallingGetDiscountFor4BooksItShouldReturn20() = 
        let bookCount = 4
        let result = discountRepository.GetDiscountFor(bookCount)
        Assert.That(result, Is.EqualTo 20)
    
    [<Test>]
    member this.WhenCallingGetDiscountFor5BooksItShouldReturn25() = 
        let bookCount = 5
        let result = discountRepository.GetDiscountFor(bookCount)
        Assert.That(result, Is.EqualTo 25)