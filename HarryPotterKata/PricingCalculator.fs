namespace HarryPotterKata

type PricingCalculator() =

    member x.SingleBookCost = 8

    member x.GetPrice (books : List<Book>) =
        x.SingleBookCost * books.Length
        