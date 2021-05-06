var nom = document.getElementById('nom')
var prenom = document.getElementById('prenom')
var mail = document.getElementById('mail')
var message = document.getElementById('msg')
var env = document.getElementById('envoyer')

env.addEventListener('click', () => {
    if (!nom.value || !prenom.value || !mail.value || !message.value) {
        swal.fire("Attention", "Veillez remplir tous les champs avant d'envoyer votre message", "info")
    }
    else {
        env.disabled = true
        env.innerHTML = '<img src="images/RollingLoader.svg" alt="Waiting icon" draggable="false" style="width: 100%; height: 100%;">'
        fetch('http://localhost:5000/support', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                nom: nom.value,
                prenom: prenom.value,
                mail: mail.value,
                message: message.value
            })
        }).then((res) => {
            if (res.status == 201) {
                swal.fire("Message envoyé avec succès", `Merci pour votre message ${prenom.value}! notre support va vous répondre au plus delai possible.`, "success")
                nom.value = ''
                prenom.value = ''
                mail.value = ''
                message.value = ''
            } else {
                swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
        }).finally(()=>{            
            env.disabled = false
            env.innerHTML = 'Envoyer'
        })
    }
})
