window.offset = 2;
window.count = 2;
const suggestResult = document.getElementById('suggestResult')

const target = document.getElementById('suggestRoller')
function handleIntersection(entries) {
    entries.map((entry) => {
        if (entry.isIntersecting) {
            fetch(`http://localhost:5000/app/explore/suggest/${window.offset}/${window.count}`)
                .then((res) => {
                    if (res.status == 200) {
                        res.text().then(value => {
                            suggestResult.insertAdjacentHTML('beforeend', value);
                            window.offset += 2;
                        })
                    } else if (res.status == 404) {
                        observer.unobserve(target);
                        target.innerHTML = null;
                        swal.fire("C'est tout pour aujourd'hui!")
                    } else {
                        swal.fire("Avertissement", "Une erreur s'est produit veuillez réessayer plus tard", "warning")
                    }
                }).catch((error) => {
                    observer.unobserve(target);
                    target.innerHTML = null;
                    swal.fire("Erreur", "Une erreur s'est produit au niveau du serveur veuillez réessayer plus tard", "error")
                })
        }
    });
}

const observer = new IntersectionObserver(handleIntersection, { threshold: 0.5 });
observer.observe(target);