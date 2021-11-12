import React, {useState} from 'react'
import { useNavigate } from 'react-router-dom'
import Navbar from '../components/Navbar'
import uuid from 'react-uuid'

const AddCustomer = () => {
    const navigate = useNavigate()

    const [contactPerson, setContactPerson] = useState('')
    const [organization, setOrganization] = useState('')
    const [contactPersonError, setContactPersonError] = useState('')
    const [organizationError, setOrganizationError] = useState('')

    const validate = (value, minLength) => {
        if(value.length < minLength)
            return 'is-invalid d-block'
        else
            return ''
    }

    const contactPersonHandler = (e) => {
        setContactPerson(e.target.value)
        setContactPersonError(validate(e.target.value, 5))
    }
    const organizationHandler = (e) => {
        setOrganization(e.target.value)
        setOrganizationError(validate(e.target.value, 5))
    }

    const submitHandler = (e) => {
        e.preventDefault()

        if(contactPerson.length !== 0 && organization.length !== 0) {
            fetch("https://win21-demo.azurewebsites.net/api/customers", {
                method: 'post',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ id: uuid(), contactPerson, organization })
            })
            .then(res => {
                if(res.status == 201)
                    navigate('/customers')
            })
        }
    }

    return (
        <div>
            <Navbar />
            <div className="container mt-5">
                <div className="d-flex justify-content-center align-items-center">
                    <div className="col-12 col-sm-10 col-lg-6 border p-3 shadow-sm">
                        <form className="p-4" onSubmit={submitHandler}>
                            <div className="mb-3">
                                <label for="contactPerson" className="form-label">Kontaktperson</label>
                                <input value={contactPerson} onChange={contactPersonHandler} type="text" className="form-control form-control-lg" id="contactPerson" aria-describedby="contactPersonHelp" />
                                <div id="contactPerson-error" className={`invalid-feedback ${contactPersonError}`}><small>Du måste ange en kontaktperson (ex. Förnamn Efternamn)</small></div>
                                <div id="contactPersonHelp" className="form-text">Vi kommer aldrig dela med oss av din information till någon annan.</div>
                            </div>
                            <div className="mb-5">
                                <label for="organization" className="form-label">Organisation</label>
                                <input value={organization} onChange={organizationHandler} type="text" className="form-control form-control-lg" id="organization" />
                                <div id="organization-error" className={`invalid-feedback ${organizationError}`}><small>Du måste ange en organisation (ex. Företag AB)</small></div>
                                
                            </div>
                            <div className="d-grid">
                                <button type="submit" className="btn btn-lg btn-dark">Skapa en Kund</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div> 
        </div>
    )
}

export default AddCustomer
