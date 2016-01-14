namespace HarryPotterKata.Tests
open NUnit.Framework
open HarryPotterKata
open Moq

type PricingCalculatorTests() = 
    let discountRepository = Mock.Of<DiscountRepository>()
    let calculator = new PricingCalculator(discountRepository)

    [<Test>]
    member this.WhenCallingGetPriceWithOneBookItShouldBe8() = 
        let book = [new Book("Mock")]
        let result = calculator.GetPrice(book)
        Assert.That(result, Is.EqualTo 8)

    [<Test>]
    member this.WhenCallingGetPriceWithTwoSameBooksItShouldBe16() = 
        let books = [new Book("Mock1");new Book("Mock1")]
        let result = calculator.GetPrice(books)
        Assert.That(result, Is.EqualTo 16)

    [<Test>]
    member this.WhenCallingGetPriceWithTwoDifferentBooksItShouldBeTenPercentOff() = 
        let books = [new Book("Mock1");new Book("Mock2")]
        let result = calculator.GetPrice(books)
        Assert.That(result, Is.EqualTo 15.2)

    [<Test>]
    member this.SingleCostOfABookIs8() = 
        Assert.That(calculator.SingleBookCost, Is.EqualTo 8)

    [<Test>]
    member this.WhenCallingGetPriceItShouldGetDiscount() = 
        Mock.Get(discountRepository).Setup(fun x -> x.GetDiscountFor 1) |> ignore

        let books = [new Book("Mock1")]
        let price = calculator.GetPrice(books)
        Mock.Get(discountRepository).Verify(fun x -> x.GetDiscountFor(1))