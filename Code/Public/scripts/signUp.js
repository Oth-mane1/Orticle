var nom = document.getElementById('nom')
var prenom = document.getElementById('prenom')
var user = document.getElementById('user')
var mail = document.getElementById('mail')
var mdp = document.getElementById('mdp')
var signup = document.getElementById('signUp')
var termine = document.getElementById('termine')
var cheksCat = document.querySelectorAll('.favCategory')

var userID;
var prenomName;
var checkedChecks;

cheksCat.forEach(element => {
    element.addEventListener('click', (e) => {
        checkedChecks = document.querySelectorAll(".favCategory:checked");
        if (checkedChecks.length > 3)
            return e.preventDefault()
    })
})

cheksCat.forEach(element => {
    element.addEventListener('change', (e) => {
        checkedChecks = document.querySelectorAll(".favCategory:checked");
        if (checkedChecks.length == 3) {
            termine.disabled = false
        }
        else
            termine.disabled = true
    })
})

signup.addEventListener('click', () => {
    if (!nom.value || !prenom.value || !user.value || !mail.value || !mdp.value) {
        swal.fire("Attention", "Veillez remplir tous les champs avant d'envoyer vos informations", "info")
    }
    else {
        signup.disabled = true
        signup.innerHTML = '<img src="images/RollingLoader.svg" alt="Waiting icon" draggable="false" style="width: 100%; height: 100%;">'
        fetch('http://localhost:5000/signUp', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                nom: nom.value,
                prenom: prenom.value,
                user: user.value,
                mail: mail.value,
                mdp: mdp.value
            })
        }).then((res) => {
            res.text().then(val => userID = val)
            if (res.status == 201) {
                swal.fire(`Bienvenue ${prenom.value}!`, `Votre Compte a bien été créer.`, "success")
                prenomName = prenom.value
                nom.value = ''
                prenom.value = ''
                user.value = ''
                mail.value = ''
                mdp.value = ''
                document.getElementById('favCatSec').classList.remove('hidden');
                document.getElementById('favCatSec').classList.add('flex');
                document.getElementById('signupSec').classList.add('hidden');
            } else if (res.status == 409) {
                swal.fire("Erreur", `Le nom d\'utilisateur <b>${user.value}</b> existe déja veuillez réessayer avec un autre nom d'utilisateur`, "error")
            } else {
                swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
        }).finally(() => {
            signup.disabled = false
            signup.innerHTML = 'S\'inscrire'
        })
    }
})

termine.addEventListener('click', () => {
    if (checkedChecks?.length < 3) {
        swal.fire("Attention", "Veillez Selectionner 3 catégorie", "info")
    }
    else {
        termine.disabled = true
        termine.innerHTML = '<img src="images/RollingLoader.svg" alt="Waiting icon" draggable="false" style="width: 100%; height: 100%;">'
        fetch(`http://localhost:5000/signUp/categories`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                userId: userID,
                cat1: checkedChecks[0].getAttribute('data-id'),
                cat2: checkedChecks[1].getAttribute('data-id'),
                cat3: checkedChecks[2].getAttribute('data-id')
            })
        }).then((res) => {
            if (res.status == 201) {
                swal.fire({
                    title: `C'est terminer ${prenomName}!`,
                    text: `Vos préférence ont bien été enregistré`,
                    icon: 'success',
                    allowOutsideClick: false,
                    allowEscapeKey: false

                }).then((result) => {
                    if (result.isConfirmed) {
                        window.location.href = 'http://localhost:5000/signIn'
                    }
                })
            } else {
                swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
        }).finally(() => {
            termine.innerHTML = 'Terminer'
        })
    }
})