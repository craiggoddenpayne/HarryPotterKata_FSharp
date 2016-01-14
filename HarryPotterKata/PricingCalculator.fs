namespace HarryPotterKata

type PricingCalculator() =

    member x.SingleBookCost = 8

    member x.GetPrice (books : List<Book>) =
        if books.Length = 1 
        then 8
        else 
        0 