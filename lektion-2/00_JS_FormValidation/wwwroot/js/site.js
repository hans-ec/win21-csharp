// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function validationHandler(event, regEx) {
    if (!regEx.test(event.target.value)) {
        event.target.classList.add("is-invalid")
        document.getElementById(`${event.target.id}-error`).style.display = "block"
    } else {
        event.target.classList.remove("is-invalid")
        document.getElementById(`${event.target.id}-error`).style.display = "none"
    }
}

document.getElementById('email').addEventListener('keyup', function (e) {
    validationHandler(e, /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/)
})

document.getElementById('password').addEventListener('keyup', function (e) {
    validationHandler(e, /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})/)
})