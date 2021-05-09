var user = document.getElementById('user')
var mdp = document.getElementById('mdp')
var signIn = document.getElementById('signIn')

signIn.addEventListener('click', () => {
    if (!user.value || !mdp.value) {
        swal.fire("Attention", "Veillez remplir tous les champs avant d'envoyer vos informations", "info")
    }
    else {
        signIn.disabled = true
        signIn.innerHTML = '<img src="images/RollingLoader.svg" alt="Waiting icon" draggable="false" style="width: 100%; height: 100%;">'
        fetch('http://localhost:5000/signIn', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                user: user.value,
                mdp: mdp.value
            })
        }).then((res) => {
            if (res.status == 200) {
                window.location.href = 'http://localhost:5000/app/explore'
                user.value = ''
                mdp.value = ''
            } else if (res.status == 401) {
                swal.fire("Erreur", `Le nom d\'utilisateur ou le mot de passe sont incorrects`, "error")
            } else if (res.status == 404) {
                swal.fire("Erreur", `Le nom d\'utilisateur n'existe pas`, "error")
            } else {
                swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
        }).finally(() => {
            signIn.disabled = false
            signIn.innerHTML = 'Connecter'
        })
    }
})