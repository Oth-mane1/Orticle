const orticle = document.getElementById('orticleContent');
const idee = document.getElementById('idee');
const title = document.getElementById('titleOrt');
const textOrt = document.getElementById('textOrt');
const reset = document.getElementById('resetOrt');
const add = document.getElementById('addOrt');
const charleft = document.getElementById('charLeft');


// Reset orticle text
reset.addEventListener('click', function (e) {
    title.value = '';
    textOrt.value = '';
})

// Count the input char
textOrt.addEventListener('keydown', (e)=>{
    if (charleft.innerText <= 0 && e.code !== 'Backspace' && e.code !== 'Delete') {
        e.preventDefault();
        charleft.style.color = 'red';
    }
    else
    {
        charleft.style.color = 'black';
        charleft.innerText = 500 - ++textOrt.innerText.length;
    }
})

// Add new orticle
add.addEventListener('click', function (e) {
    var div = document.createElement('div');
    div.classList.add('orticle', 'flex', 'flex-col', 'justify-between', 'bg-oblue', 'p-4', 'rounded-xl', 'overflow-hidden');
    var content = `
        <div>
            <textarea cols="20" rows="2" placeholder="Titre..."
                class="title w-full overflow-hidden border-white border-dashed border-2 border-opacity-0 focus:border-opacity-100 
                hover:border-opacity-100 transition duration-500 text-gray-50 bg-transparent text-xl font-semibold p-1.5 outline-none">${title.value}
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
    orticle.insertBefore(div, idee);

    // Remove an orticle
    const dlt = document.querySelectorAll('.delete');
    
    dlt.forEach(element => {
        element.addEventListener('click', function (e) {
            e.currentTarget.parentElement.parentElement.remove();
        })
    });

    // Clear the content
    title.value = '';
    textOrt.innerHTML = '';
})
