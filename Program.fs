// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello! I'm Bishal Amgai(22083566)"





type Genre =
    | Comedy
    | Fantasy
    | Sport
    | Horror
    | Drama
    | Thriller





type Director = {
    Name: string
    Movies: int
}





type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDbRating: float
}





let movies = [
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDbRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDbRating = 7.5 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDbRating = 7.3 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDbRating = 7.4 }
    { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam McKay"; Movies = 27 }; IMDbRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }; IMDbRating = 7.6 }
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDbRating = 8.1 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDbRating = 7.1 }
    
    
]

let convertRunLength (runLength: int) =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

let runLengthsInHours = movies |> List.map (fun movie -> convertRunLength movie.RunLength)

printfn "All the Movies are:"
movies |> List.iter (fun movie -> printfn "%s - %s" movie.Name (convertRunLength movie.RunLength))


let oscarWinners = movies |> List.filter (fun movie -> movie.IMDbRating > 7.4)







printfn "All the probable Oscar Winners are:"
oscarWinners |> List.iter (fun movie -> printfn "%s - %s" movie.Name (convertRunLength movie.RunLength))
