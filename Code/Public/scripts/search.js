const search = document.getElementById('search')
const searchResult = document.getElementById('searchResult');
const index = document.getElementById('index');
const searchText = document.getElementById('searchText');
const wlc = document.getElementById('wlc');

// Add new article
search.addEventListener('click', (e) => {
    if (!searchText.value) {
        swal.fire("Attention", "Veuillez Entrer ce que vous voulez chercher!", "warning")
    }
    else {
        fetch(`http://localhost:5000/app/search/${index.options[index.selectedIndex].value}/`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({                
                text: searchText.value
            })
        }).then((res) => {
            if (res.status == 200) {
                res.text().then(value => {
                    wlc.classList.add('hidden')
                    searchResult.innerHTML = value
                })
            } else {
                swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
            }
        }).catch((error) => {
            swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
        })
    }
})