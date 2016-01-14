namespace HarryPotterKata.Tests
open NUnit.Framework
open HarryPotterKata
open Moq

type PricingCalculatorTests() = 
    let calculator = new PricingCalculator()

    [<Test>]
    member this.WhenCallingGetPriceWithOneBookItShouldBe8() = 
        let book = [new Book("Mock")]
        let result = calculator.GetPrice(book)
        Assert.That(result, Is.EqualTo 8)

    [<Test>]
    member this.WhenCallingGetPriceWithTwoDifferentBooksItShouldBe16() = 
        let books = [new Book("Mock1");new Book("Mock2")]
        let result = calculator.GetPrice(books)
        Assert.That(result, Is.EqualTo 16)

    [<Test>]
    member this.SingleCostOfABookIs8() = 
        Assert.That(calculator.SingleBookCost, Is.EqualTo 8)