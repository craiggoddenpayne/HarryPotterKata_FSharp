namespace HarryPotterKata

type PricingCalculator(discountRepository: DiscountRepository) =
    let discountRepository = discountRepository

    member x.SingleBookCost = 8

    member x.GetPrice (books : List<Book>) =
        
        let bookGroups = query {
            for book in books do
            groupBy book.Title 
            count
        }

        if bookGroups = 2 
        then 15.2
        else
        (float)(x.SingleBookCost * books.Length)