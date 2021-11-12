import React, {useState, useEffect} from 'react'
import { NavLink } from 'react-router-dom'
import Customer from '../components/Customer'

import Navbar from '../components/Navbar'

const Customers = () => {
    const [customers, setCustomers] = useState([])

    useEffect(() => {
        async function fetchCustomers() {
            let res = await fetch("https://win21-demo.azurewebsites.net/api/customers")
            let data = await res.json()
            setCustomers(data)
        }
        fetchCustomers()
    }, [])

    return (
        <div>
            <Navbar />
            <div className="container mt-5">
                <NavLink className="btn btn-outline-dark" to="/customers/add"><i className="fas fa-plus me-2"></i>Lägg till ny Kund</NavLink>
                <div className="row row-cols-1 row-cols-md-4 g-4 mt-1 mb-5">
                {
                    customers.map(customer => (<Customer key={customer.id} customer={customer} />))
                }
                </div>
            </div>
        </div>
    )
}

export default Customers
