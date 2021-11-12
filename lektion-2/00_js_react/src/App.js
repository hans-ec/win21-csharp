import './App.css';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import AddCustomer from './views/AddCustomer';
import Customers from './views/Customers';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route exact path="/customers/add" element={<AddCustomer />} />
        <Route exact path="/customers" element={<Customers />} />
        <Route exact path="/" element={<Customers />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
