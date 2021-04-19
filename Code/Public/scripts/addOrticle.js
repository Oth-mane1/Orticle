const orticle = document.getElementById('orticle');
const title = document.getElementById('titleOrt');
const textOrt = document.getElementById('textOrt');
const reset = document.getElementById('resetOrt');
const add = document.getElementById('addOrt');
const dlt = document.querySelectorAll('.delete');

// Reset orticle text
reset.addEventListener('click', function (e) {
    title.value = '';
    textOrt.value = '';
})

// Add new orticle
dlt.forEach(element => {
    element.addEventListener('click', function (e) {
        console.log(e.target.parentElement.parentElement.parentElement.parentElement.remove())
    })
});