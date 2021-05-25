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
        searchResult.innerHTML = `<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" style="width: 100px; height:100px; margin: auto; background: none; display: block; shape-rendering: auto;" viewBox="0 0 100 100" preserveAspectRatio="xMidYMid">
        <circle cx="50" cy="50" fill="none" stroke="#397BA7" stroke-width="10" r="32" stroke-dasharray="150.79644737231007 52.26548245743669">
          <animateTransform attributeName="transform" type="rotate" repeatCount="indefinite" dur="1.8518518518518516s" values="0 50 50;360 50 50" keyTimes="0;1"></animateTransform>
        </circle>
        </svg>`

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
            searchResult.innerHTML = null
        })
    }
})