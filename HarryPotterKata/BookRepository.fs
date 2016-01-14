namespace HarryPotterKata

type BookRepository () =
    member x.GetAllBooks() =
        [
        new Book "Harry Potter 1"; 
        new Book "Harry Potter 2";
        new Book "Harry Potter 3";
        new Book "Harry Potter 4";
        new Book "Harry Potter 5";
        ]