namespace HarryPotterKata

type DiscountRepository() = 
    member x.GetDiscountFor bookCount = 
        if bookCount = 2 then 5
        else if bookCount = 3 then 10
        else if bookCount = 4 then 20
        else if bookCount = 5 then 25
        else 0