import './App.css'
import { HomePage } from './layout/HomePage/HomePage'
import { Footer } from './layout/NavBarAndFooter/Footer'
import { Navbar } from './layout/NavBarAndFooter/NavBar'
import { SearchBooksPage } from './layout/SearchBooksPage/SearchBooksPage'

function App() {

  return (
    <div>
      <Navbar />
      <HomePage />
      <SearchBooksPage />
      <Footer />
    </div>
  )
}

export default App
