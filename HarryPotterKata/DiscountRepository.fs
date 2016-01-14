namespace HarryPotterKata

type DiscountRepository() = 
    member x.GetDiscountFor bookCount = 
        if bookCount = 2 then 5
        else 0