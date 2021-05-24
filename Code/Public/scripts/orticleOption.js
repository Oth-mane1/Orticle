// Remove an article
const supprimer = document.querySelectorAll('.supprimer');

supprimer.forEach(element => {
    element.addEventListener('click', function (e) {
        const idArt = e.currentTarget.parentElement.parentElement.parentElement.parentElement.parentElement.getAttribute('data-id')
        swal.fire({
            title: 'Suppression...',
            showConfirmButton: false,
            allowOutsideClick: () => !Swal.isLoading(),
            didOpen: () => {
                Swal.showLoading()
                fetch(`http://localhost:5000/app/orticle/delete/${idArt}`, {
                    method: 'DELETE'
                }).then((res) => {
                    if (res.status == 204) {
                        swal.fire({
                            title: 'Suppression terminer',
                            text: `L'article a bien été Supprimer`,
                            icon: 'success'
                        }).then(() => {
                            location.reload();
                        })
                    } else {
                        swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
                    }
                }).catch((error) => {
                    swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
                })
            }
        }).then(() => {
            location.reload();
        })


    })
});

// Partage an article
const partage = document.querySelectorAll('.partager');

partage.forEach(element => {
    element.addEventListener('click', function (e) {
        var head = e.currentTarget.parentElement.parentElement.parentElement.parentElement
        navigator.clipboard.writeText(head.children[0].children[1].getAttribute('href')).then(() => {
            Swal.fire({
                title: 'Partager!',
                text: 'Lien vers l\'article est copié dans le presse papier.',
                timer: 2000,
                icon: 'success',
                showConfirmButton: false,
                timerProgressBar: true
            })
        })
    })
});
