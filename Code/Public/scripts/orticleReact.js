// Like an article
const olike = document.getElementById('olike');
olike.addEventListener('click', function (e) {
    const idOrt = e.currentTarget.parentElement.parentElement.parentElement.getAttribute('data-id');
    if (olike.classList.contains('liked')) {
        fetch(`http://localhost:5000/app/orticle/set/like/${idOrt}`, {
            method: 'DELETE'
        }).then((res) => {
            if (!res.status == 204) {
                swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
        })
        return olike.classList.remove('liked')
    }

    fetch(`http://localhost:5000/app/orticle/set/like/${idOrt}`, {
        method: 'POST'
    }).then((res) => {
        if (res.status == 200) {
            Swal.fire({
                title: 'O2 Orticle!',
                timer: 1000,
                icon: 'success',
                showConfirmButton: false,
                timerProgressBar: true
            })
            olike.classList.add('liked')
        } else {
            swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
        }
    }).catch((error) => {
        swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
    })
})

// Partage an orticle
const partage = document.getElementById('share');
partage.addEventListener('click', function (e) {
    var art = document.getElementById('art').children[0]
    var link = partage.parentElement.parentElement.parentElement.children[art.childElementCount - 2].children[0].getAttribute('href')
    navigator.clipboard.writeText(link).then(() => {
        Swal.fire({
            title: 'Partager!',
            text: 'Lien vers l\'orticle est copié dans le presse papier.',
            timer: 2000,
            icon: 'success',
            showConfirmButton: false,
            timerProgressBar: true
        })
    })
});

// Report an orticle
const signal = document.getElementById('report');
signal.addEventListener('click', async function (e) {
    const { value: descSig } = await swal.fire({
        title: `Signaler l'Orticle!`,
        text: `Veuillez nous preciser en quelque mots pourquoi vous voulez signaler ce Orticle?`,
        icon: 'error',
        allowOutsideClick: false,
        allowEscapeKey: false,
        showCancelButton: true,
        confirmButtonColor: 'rgb(204, 6, 6)',
        confirmButtonText: 'Envoyer',
        cancelButtonText: 'Annuler ',
        input: 'text',
        inputPlaceholder: 'Description...',
        inputValidator: (value) => {
            if (!value) {
                return 'Vous devez preciser votre raison avant de signaler!'
            }
        }
    })

    if (descSig) {
        var art = document.getElementById('art')
        fetch(`http://localhost:5000/app/orticle/signal/${art.getAttribute('data-id')}`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                descSig: descSig,
            })
        }).then((res) => {
            if (res.status == 200) {
                swal.fire({
                    title: `Orticle signaler!`,
                    text: `Merci pour votre collaboration pour améliorer votre contenu.`,
                    icon: 'success',
                    allowOutsideClick: false,
                    allowEscapeKey: false
                }).then((result) => {
                    if (result.isConfirmed) {
                        window.location.href = 'http://localhost:5000/app/'
                    }
                })
            } else {
                swal.fire("Erreur", "Une erreur s'est produit veuillez réessayer plus tard", "error")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit veuillez réessayer plus tard", "error")
        })
    }
});
