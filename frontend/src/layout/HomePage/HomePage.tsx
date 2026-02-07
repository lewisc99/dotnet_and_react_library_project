import { Carousel } from "./Components/Carousel"
import { ExploreTopBooks } from "./Components/ExporeTopBooks"
import { Heros } from "./Components/Heros"
import { LibraryServices } from "./Components/LibraryService"

export const HomePage = () => {
    return (
        <>
        <ExploreTopBooks />
        <Carousel />
        <Heros/>
        <LibraryServices />
        </>
    )
}