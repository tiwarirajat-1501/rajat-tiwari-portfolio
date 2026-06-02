* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    scroll-behavior: smooth;
    font-family: 'Poppins', sans-serif;
}

body {
    background: #f8fafc;
    color: #1f2937;
    line-height: 1.6;
}

header {
    background: #ffffff;
    box-shadow: 0 2px 10px rgba(0,0,0,0.08);
    position: sticky;
    top: 0;
    z-index: 1000;
}

.navbar {
    max-width: 1200px;
    margin: auto;
    padding: 18px 30px;
    display: flex;
    justify-content: space-between;
    align-items: center;
}

.logo {
    color: #2563eb;
    font-size: 1.6rem;
    font-weight: 700;
}

.navbar ul {
    display: flex;
    gap: 25px;
    list-style: none;
}

.navbar a {
    text-decoration: none;
    color: #374151;
    font-weight: 500;
    transition: 0.3s;
}

.navbar a:hover {
    color: #2563eb;
}

.hero {
    min-height: 90vh;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: center;
    background: linear-gradient(135deg, #2563eb, #1e40af);
    color: white;
    padding: 40px;
}

.hero-content h1 {
    font-size: 4rem;
    margin-bottom: 10px;
}

.hero-content h2 {
    font-size: 1.8rem;
    font-weight: 400;
    margin-bottom: 20px;
}

.hero-content p {
    max-width: 700px;
    margin: auto;
    margin-bottom: 30px;
}

.btn,
.btn-outline {
    display: inline-block;
    padding: 12px 24px;
    margin: 10px;
    border-radius: 8px;
    text-decoration: none;
    font-weight: 600;
    transition: 0.3s;
}

.btn {
    background: white;
    color: #2563eb;
}

.btn:hover {
    transform: translateY(-3px);
}

.btn-outline {
    border: 2px solid white;
    color: white;
}

.btn-outline:hover {
    background: white;
    color: #2563eb;
}

.section {
    max-width: 1100px;
    margin: auto;
    padding: 80px 20px;
}

.section h2 {
    text-align: center;
    color: #2563eb;
    margin-bottom: 40px;
    font-size: 2.2rem;
}

.card,
.project-card {
    background: white;
    padding: 25px;
    margin-bottom: 25px;
    border-radius: 15px;
    box-shadow: 0 5px 18px rgba(0,0,0,0.08);
    transition: 0.3s;
}

.card:hover,
.project-card:hover {
    transform: translateY(-5px);
}

.skills-grid {
    display: flex;
    flex-wrap: wrap;
    gap: 15px;
    justify-content: center;
}

.skills-grid span {
    background: #2563eb;
    color: white;
    padding: 12px 18px;
    border-radius: 30px;
    font-weight: 500;
}

.cert-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit,minmax(250px,1fr));
    gap: 20px;
}

#github {
    text-align: center;
}

#github img {
    width: 100%;
    max-width: 500px;
    margin-top: 20px;
}

#contact {
    text-align: center;
}

#contact a {
    color: #2563eb;
    text-decoration: none;
}

footer {
    text-align: center;
    background: #1e40af;
    color: white;
    padding: 20px;
    margin-top: 50px;
}

.fade {
    opacity: 0;
    transform: translateY(30px);
    transition: all 0.8s ease;
}

.fade.show {
    opacity: 1;
    transform: translateY(0);
}

@media(max-width: 768px) {

    .navbar {
        flex-direction: column;
        gap: 15px;
    }

    .navbar ul {
        flex-wrap: wrap;
        justify-content: center;
    }

    .hero-content h1 {
        font-size: 2.7rem;
    }

    .hero-content h2 {
        font-size: 1.3rem;
    }
}