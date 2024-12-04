let currentSlide = 0; 
const totalSlides = document.querySelectorAll('.carousel-images img').length;

function showSlide(index) {
    const carouselImages = document.querySelector('.carousel-images');
    const indicators = document.querySelectorAll('.indicator');

    currentSlide = (index + totalSlides) % totalSlides;

    carouselImages.style.transform = `translateX(-${currentSlide * 100}%)`;


    indicators.forEach((indicator, i) => {
        indicator.classList.toggle('active', i === currentSlide);
    });
}

function goToSlide(index) {
    showSlide(index);
}


setInterval(() => {
    showSlide(currentSlide + 1);
}, 6000); 
