namespace HarryPotterKata.Tests
open NUnit.Framework
open HarryPotterKata

type DiscountRepositoryTests() = 
    let discountRepository = new DiscountRepository()

    [<Test>]
    member this.WhenCallingGetDiscountFor2Books() = 
        let bookCount = 2
        let result = discountRepository.GetDiscountFor(bookCount)
        Assert.That(result, Is.EqualTo 5)