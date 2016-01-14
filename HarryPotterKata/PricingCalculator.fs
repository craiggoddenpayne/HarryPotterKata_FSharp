namespace HarryPotterKata

type PricingCalculator() =
    member x.GetPrice (books : List<Book>) =
        if books.Length = 1 
        then 8
        else 
        0 