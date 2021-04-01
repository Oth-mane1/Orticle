document.getElementById('menu').addEventListener('click', function () {
    document.getElementsByClassName('nv')[0].classList.toggle('hidden');
    document.getElementsByClassName('nv')[1].classList.toggle('hidden');
    this.style.transition = 'all 0.2s';
    if (this.getAttribute('aria-label') == 'menu') {
        this.style.backgroundImage = "url(./images/close.svg)";
        this.setAttribute('aria-label', 'close');
    } else {
        this.style.backgroundImage = "url(./images/menu.svg)";
        this.setAttribute('aria-label', 'menu');
    }
});