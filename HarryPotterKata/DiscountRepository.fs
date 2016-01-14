namespace HarryPotterKata

type DiscountRepository() = 
    abstract member GetDiscountFor : int -> int  
       default x.GetDiscountFor bookCount = 
            if bookCount = 2 then 5
            else if bookCount = 3 then 10
            else if bookCount = 4 then 20
            else if bookCount = 5 then 25
            else 0