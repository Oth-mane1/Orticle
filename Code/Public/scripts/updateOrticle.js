// Main orticle attributs
const orticleContent = document.getElementById('orticleContent');
const title = document.getElementById('titre');
const source = document.getElementById('source');
const category = document.getElementById("category")

// Orticle ideas
const newIdea = document.getElementById('newIdea');
const titleIdee = document.getElementById('titleOrt');
const textOrt = document.getElementById('textOrt');
const reset = document.getElementById('resetOrt');
const charleft = document.getElementById('charLeft');

// Buttons
const add = document.getElementById('addOrt');
const partage = document.getElementById('parteger');

// Reset orticle text
reset.addEventListener('click', function (e) {
    titleIdee.value = '';
    textOrt.innerHTML = '';
})

// Count the input char
textOrt.addEventListener('keydown', (e) => {
    if (charleft.innerText <= 0 && e.code !== 'Backspace' && e.code !== 'Delete') {
        e.preventDefault();
        charleft.style.color = 'red';
    }
    else {
        charleft.style.color = 'black';
        charleft.innerText = 500 - textOrt.innerText.length;
    }
})
textOrt.addEventListener('keyup', (e) => {
    if (charleft.innerText <= 0 && e.code !== 'Backspace' && e.code !== 'Delete') {
        e.preventDefault();
        charleft.style.color = 'red';
    }
    else {
        charleft.style.color = 'black';
        charleft.innerText = 500 - textOrt.innerText.length;
    }
})

// Remove an orticle
const dlt = document.querySelectorAll('.delete');

dlt.forEach(element => {
    element.addEventListener('click', function (e) {
        e.currentTarget.parentElement.parentElement.remove();
    })
});

// Add new orticle
add.addEventListener('click', function (e) {
    if (!titleIdee.value || !textOrt.innerText) {
        return swal.fire("Attention", "Veuillez Remplir tous les champs!", "warning")
    }

    var div = document.createElement('div');
    div.classList.add('orticle', 'flex', 'flex-col', 'justify-between', 'bg-oblue', 'p-4', 'rounded-xl', 'overflow-hidden');
    var content = `
        <div>
            <textarea cols="20" rows="2" placeholder="Titre..."
                class="title w-full overflow-hidden border-white border-dashed border-2 border-opacity-0 focus:border-opacity-100 
                hover:border-opacity-100 transition duration-500 text-gray-50 bg-transparent text-xl font-semibold p-1.5 outline-none">${titleIdee.value}
            </textarea>
            <div cols="20" rows="5" placeholder="Orticle..." contenteditable="true"
                class="idea w-full overflow-hidden border-black border-dashed border-2 border-opacity-0 focus:border-opacity-100 
                hover:border-opacity-100 transition duration-500 text-gray-900 bg-transparent text-lg p-1.5 mb-2 outline-none">${textOrt.innerHTML}
            </div>
        </div>
        <div class="mt-3 flex justify-end">
            <button class="delete">
                <svg class="h-5" width="17" height="24" viewBox="0 0 17 24" fill="none"
                    xmlns="http://www.w3.org/2000/svg">
                    <path
                        d="M1.21429 21.3333C1.21429 22.8 2.30714 24 3.64286 24H13.3571C14.6929 24 15.7857 22.8 15.7857 21.3333V8C15.7857 6.53333 14.6929 5.33333 13.3571 5.33333H3.64286C2.30714 5.33333 1.21429 6.53333 1.21429 8V21.3333ZM15.7857 1.33333H12.75L11.8879 0.386667C11.6693 0.146667 11.3536 0 11.0379 0H5.96214C5.64643 0 5.33071 0.146667 5.11214 0.386667L4.25 1.33333H1.21429C0.546429 1.33333 0 1.93333 0 2.66667C0 3.4 0.546429 4 1.21429 4H15.7857C16.4536 4 17 3.4 17 2.66667C17 1.93333 16.4536 1.33333 15.7857 1.33333Z"
                        fill="#323232" />
                </svg>
            </button>
        </div>
        `
    div.innerHTML = content;
    orticleContent.insertBefore(div, newIdea);

    // Remove an orticle
    const dlt = document.querySelectorAll('.delete');

    dlt.forEach(element => {
        element.addEventListener('click', function (e) {
            e.currentTarget.parentElement.parentElement.remove();
        })
    });

    // Clear the content
    titleIdee.value = '';
    textOrt.innerHTML = '';
    // Reset the counter
    charleft.innerText = 500;
    charleft.style.color = 'black';
})

// Add new orticle
partage.addEventListener('click', (e) => {
    if (!title.value || !source.value) {
        swal.fire("Attention", "Veuillez Remplir tous les champs!", "warning")
    }
    else {
        if (--orticleContent.childElementCount < 3) {
            return swal.fire("Attention", "Vous devez ajouter au moins 3 idées", "info")
        }

        if (!source.checkValidity()) {
            return swal.fire("Attention", "Veuillez assurer que vous avez entré un source de donnée valide", "warning")
        }

        // Inserted ideas
        const ideas = document.querySelectorAll('.idea');
        const titleIdeas = document.querySelectorAll('.title');
        var ideasArr = []
        for (let i = 0; i < --orticleContent.childElementCount; i++) {
            ideasArr.push([titleIdeas[i].innerHTML.trim(), ideas[i].innerHTML.trim()])
        }

        const shortSource = new URL(source.value);
        partage.disabled = true
        partage.innerHTML = '<img src="/images/RollingLoader.svg" alt="Waiting icon" draggable="false" style="width: 100%; height: 100%;">'
        fetch(`http://localhost:5000/app/orticle/edit/${orticleContent.getAttribute('data-id')}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                idOrt: orticleContent.getAttribute('data-id'),
                title: title.value,
                source: source.value,
                shortSrc: shortSource.hostname,
                category: category.options[category.selectedIndex].getAttribute('data-id'),
                idees: ideasArr
            })
        }).then((res) => {
            if (res.status == 204) {
                swal.fire({
                    title: `C;est fait!`,
                    text: `Votre orticle a bien été modifié.`,
                    icon: 'success'
                }).then(() => {
                    window.location.href = 'http://localhost:5000/app/orticle'
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