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