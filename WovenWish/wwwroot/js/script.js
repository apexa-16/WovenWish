const toggleBtn = document.querySelector('.menu-toggle');
const menu = document.querySelector('.menu');

toggleBtn.addEventListener('click', () => {
    menu.classList.toggle('open');
});

window.addEventListener('resize', () => {
    if (window.innerWidth > 768) {
        menu.classList.remove('open');
    }
});
