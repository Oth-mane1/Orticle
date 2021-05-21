const apporter = document.getElementById('apporter')
const partage = document.getElementById('partager');
const source = document.getElementById('source');
const content = document.getElementById('content');
const wlc = document.getElementById('wlc');
const textArt = document.getElementById('textArt');
const titreArt = document.getElementById('titreArt');

// Add new article
apporter.addEventListener('click', (e) => {
    if (!source.value) {
        swal.fire("Attention", "Veuillez Entrer votre source de données!", "warning")
    }
    else {
        if (!source.checkValidity()) {
            return swal.fire("Erreur", "Veuillez assurer que vous avez entré un source de donnée valide", "error")
        }

        apporter.disabled = true
        apporter.innerHTML = '<img src="/images/RollingLoader.svg" alt="Waiting icon" draggable="false" style="width: 100%; height: 100%;">'
        fetch(`http://localhost:5000/app/article/getContent`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                link: source.value
            })
        }).then((res) => {
            if (res.status == 200) {
                res.json().then(value => {
                    const result = JSON.parse(value)
                    content.removeAttribute('hidden')
                    wlc.classList.add('hidden');
                    textArt.value = result.content.substring(0, 500) + '...';
                    titreArt.value = result.title;
                    window.result = result;
                })
            } else {
                swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
        }).finally(() => {
            apporter.disabled = false
            apporter.innerHTML = 'Apporter'
        })
    }
})

// Share the new article
partage.addEventListener('click', (e) => {
    if (!source.value || !textArt.value || !titreArt.value) {
        swal.fire("Attention", "Veuillez Entrer votre source de données!", "warning")
    }
    else {
        if (!source.checkValidity()) {
            return swal.fire("Erreur", "Veuillez assurer que vous avez entré un source de donnée valide", "error")
        }

        partage.disabled = true
        partage.innerHTML = '<img src="/images/RollingLoader.svg" alt="Waiting icon" draggable="false" style="width: 100%; height: 100%;">'
        fetch(`http://localhost:5000/app/article/add`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },

            body: JSON.stringify({
                title: window.result.title,
                source: window.result.url,
                shortSrc: window.result.domain,
                extrait: window.result.content.substring(0, 500) + '...'
            })
        }).then((res) => {
            if (res.status == 201) {
                source.value = '';
                textArt.value = '';
                titreArt.value = '';
                swal.fire({
                    title: `Merci pour votre contribution!`,
                    text: `Votre article a bien été ajouté`,
                    icon: 'success'
                }).then(() => {
                    window.location.href = 'http://localhost:5000/app/article'
                })
            } else {
                swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
        }).finally(() => {
            partage.disabled = false
            partage.innerHTML = 'Partager'
        })
    }
})