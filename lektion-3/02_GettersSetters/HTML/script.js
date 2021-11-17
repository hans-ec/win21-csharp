function handleSubmit(e) {
    e.preventDefault()
    
    console.log(e.target["birthDate"].value)

    let birthDate = `${e.target["year"].value}-${e.target["month"].value}-${e.target["day"].value}`
    console.log(birthDate)
}


