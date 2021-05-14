var cheksCat = document.querySelectorAll('.favCategory')
var modCat = document.getElementById('modifierCat')
var nomUtl = document.getElementById('nomUtl')
var checkedChecks;

fetch(`http://localhost:5000/app/user/${nomUtl.value}/categories`, {
    method: 'GET'
}).then((res) => {
    if (res.status == 200) {
        res.json().then((value) => {
            cheksCat.forEach(element => {
                if (element.getAttribute('data-id') == value[0].idCat ||
                    element.getAttribute('data-id') == value[1].idCat ||
                    element.getAttribute('data-id') == value[2].idCat) {
                    element.checked = true
                }
            })
        })
    } else {
        swal.fire("Erreur", "Une erreur s'est produit lors du chargement de la page veuillez réessayer plus tard", "error")
    }
}).catch((error) => {
    swal.fire("Erreur", "Une erreur s'est produit lors du chargement de la page veuillez réessayer plus tard", "error")
})


// Control number of checked categories
cheksCat.forEach(element => {
    element.addEventListener('click', (e) => {
        checkedChecks = document.querySelectorAll(".favCategory:checked");
        if (checkedChecks.length > 3)
            return e.preventDefault()
    })
})

modCat.addEventListener('click', (e) => {
    // Modify user fav categories
})