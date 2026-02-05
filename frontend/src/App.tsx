import './App.css'
import { HomePage } from './layout/HomePage/HomePage'
import { Footer } from './layout/NavBarAndFooter/Footer'
import { Navbar } from './layout/NavBarAndFooter/NavBar'

function App() {

  return (
    <div>
      <Navbar />
      <HomePage />
      <Footer />
    </div>
  )
}

export default App
