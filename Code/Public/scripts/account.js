var cheksCat = document.querySelectorAll('.favCategory')
var modInfo = document.getElementById('modifierInfo')
var modCat = document.getElementById('modifierCat')
var sup = document.getElementById('supprimer')
var nomUtl = document.getElementById('nomUtl')
var checkedChecks = document.querySelectorAll(".favCategory:checked");

// Get usera fav Categories
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
    } else if (res.status == 404) {
        swal.fire("Informations", "Vous n'avez pas encore ajouter vos préférence", "info")
    } else {
        swal.fire("Erreur", "Une erreur s'est produit lors du chargement de la page veuillez réessayer plus tard", "error")
    }
}).catch((error) => {
    swal.fire("Erreur", "Une erreur s'est produit lors du chargement de la page veuillez réessayer plus tard", "error")
}).finally(() => {
    document.getElementById('loader').remove();
    document.getElementById('categories').removeAttribute('hidden');
})


// Control number of checked categories
cheksCat.forEach(element => {
    element.addEventListener('click', (e) => {
        checkedChecks = document.querySelectorAll(".favCategory:checked");
        if (checkedChecks.length > 3)
            return e.preventDefault()
    })
})

// Modify user's infos
modInfo.addEventListener('click', (e) => {
    var userId = document.getElementById('userInfos').getAttribute('data-id');
    var nom = document.getElementById('nom')
    var prenom = document.getElementById('prenom')
    var user = document.getElementById('nomUtl')
    var mail = document.getElementById('email')
    var mdp = document.getElementById('mdp')
    var cfrmdp = document.getElementById('cfrmdp')
    if (!nom.value || !prenom.value || !user.value || !mail.value || !mdp.value || !cfrmdp.value) {
        swal.fire("Attention", "Veillez remplir tous les champs pour pouvoir modifier vos informations", "warning")
    }
    else {
        if (mdp.value == cfrmdp.value) {
            modInfo.disabled = true
            modInfo.innerHTML = '<img src="/images/RollingLoader.svg" alt="Waiting icon" draggable="false" style="width: 100%; height: 100%;">'
            fetch(`http://localhost:5000/app/user/${nomUtl.value}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    userId: userId,
                    nom: nom.value,
                    prenom: prenom.value,
                    user: user.value,
                    mail: mail.value,
                    mdp: mdp.value
                })
            }).then((res) => {
                if (res.status == 204) {
                    swal.fire(`C'est fait ${prenom.value}!`, `Vos informations sont bien été modifié.`, "success")
                    cfrmdp.value = ''
                } else if (res.status == 409) {
                    swal.fire("Erreur", `Le nom d\'utilisateur <b>${user.value}</b> existe déja veuillez réessayer avec un autre nom d'utilisateur`, "error")
                } else {
                    swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
                }
            }).catch((error) => {
                swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
            }).finally(() => {
                modInfo.disabled = false
                modInfo.innerHTML = 'Modifier'
            })
        } else {
            swal.fire("Erreur", "Les mots de passe ne sont pas identique!", "error")
        }
    }
})

// Modify user's fav categorie
modCat.addEventListener('click', (e) => {
    var userId = document.getElementById('userInfos').getAttribute('data-id');
    var user = document.getElementById('nomUtl')
    if (checkedChecks?.length < 3) {
        swal.fire("Attention", "Veillez Selectionner 3 catégorie!", "info")
    }
    else {
        modCat.disabled = true
        modCat.innerHTML = '<img src="/images/RollingLoader.svg" alt="Waiting icon" draggable="false" style="width: 100%; height: 100%;">'
        fetch(`http://localhost:5000/app/user/${user.value}/categories`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                userId: userId,
                cat1: checkedChecks[0].getAttribute('data-id'),
                cat2: checkedChecks[1].getAttribute('data-id'),
                cat3: checkedChecks[2].getAttribute('data-id')
            })
        }).then((res) => {
            if (res.status == 201) {
                swal.fire({
                    title: `C'est terminer ${prenom.value}!`,
                    text: `Vos préférence ont bien été modifié`,
                    icon: 'success'
                })
            } else {
                swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
        }).finally(() => {
            modCat.disabled = false
            modCat.innerHTML = 'Modifier'
        })
    }
})

// Delete user account
sup.addEventListener('click', async (e) => {
    var prenom = document.getElementById('prenom')
    const { value: username } = await swal.fire({
        title: `Suppression du compte!`,
        text: `Veuillez entrer votre nom d'utilisateur pour confirmer la suppression`,
        icon: 'error',
        allowOutsideClick: false,
        allowEscapeKey: false,
        showCancelButton: true,
        confirmButtonColor: 'rgb(204, 6, 6)',
        confirmButtonText: 'Confirmer',
        cancelButtonText: 'Annuler ',
        input: 'text',
        inputPlaceholder: 'Entrer votre nom d\'utilisateur',
        inputValidator: (value) => {
            if (!value) {
                return 'Vous devez entrer votre nom d\'utilisateur!'
            }
            if (value != nomUtl.value) {
                return 'Nom d\'utilisateur saisi est incorrect!'
            }
        }
    })

    if (username) {
        fetch(`http://localhost:5000/app/user/${nomUtl.value}/`, {
            method: 'DELETE'
        }).then((res) => {
            if (res.status == 204) {
                swal.fire({
                    title: `C'est terminer ${prenom.value}!`,
                    text: `Triste de vous voir partir, mais vous êtes toujours le bienvenu pour créer un compte.`,
                    icon: 'success',
                    allowOutsideClick: false,
                    allowEscapeKey: false

                }).then((result) => {
                    if (result.isConfirmed) {
                        window.location.href = 'http://localhost:5000/'
                    }
                })
            } else {
                swal.fire("Erreur", "Une erreur s'est produit veuillez réessayer plus tard", "error")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit veuillez réessayer plus tard", "error")
        })
    }
})