const sections = document.querySelectorAll(
    ".card, .project-card, .skills-grid, .cert-grid"
);

const observer = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.classList.add("show");
        }
    });
});

sections.forEach(section => {
    section.classList.add("fade");
    observer.observe(section);
});

console.log("Portfolio Loaded Successfully 🚀");