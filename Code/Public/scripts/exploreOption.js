// Partage an orticle
const partage = document.querySelectorAll('.share');
partage.forEach(element => {
    element.addEventListener('click', function (e) {
        var head = e.currentTarget.parentElement.parentElement.parentElement
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
