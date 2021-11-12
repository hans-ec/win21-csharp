import React from 'react'

const Customer = ({customer}) => {
    return (
        <div className="col">
            <div className="card h-100 shadow-sm">
                <img src="https://thispersondoesnotexist.com/image" className="card-img-top" alt="..." />
                <div className="card-body text-center">
                <h5 className="card-title">{customer.contactPerson}</h5>
                <p className="card-text text-muted">{customer.organization}</p>
                </div>
            </div>
        </div>
    )
}

export default Customer
