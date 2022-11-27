// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//funcionalidade curtir
const button = document.querySelector('#curtir');
const numeroCurtidas = document.querySelector('#numeroCurtidas');
const imagem =  document.querySelector('#coracao');

button.addEventListener('click', () => {
  let likeValue = document.querySelector('#numeroCurtidas').textContent;
  let newValue = Number(likeValue) + 1;
  button.classList.add('curtir');
  numeroCurtidas.innerHTML = newValue;
  imagem.setAttribute("src", "../imagens/favorito-preenchido.png");
});


//funcionalidade avaliar
/* var stars = document.querySelectorAll(".star-icon");
                  
document.addEventListener('click', function(e){
  var classStar = e.target.classList;
  if(!classStar.contains('ativo')){
    stars.forEach(function(star){
      star.classList.remove('ativo');
    });
    classStar.add('ativo');
    console.log(e.target.getAttribute('data-avaliacao'));
  }
}); */


function Avaliar(estrela) {
  var avaliacao = 0;
 
  if (estrela == 5) {
      document.getElementById("s1").src = "../imagens/star1.png";
      document.getElementById("s2").src = "../imagens/star1.png";
      document.getElementById("s3").src = "../imagens/star1.png";
      document.getElementById("s4").src = "../imagens/star1.png";
      document.getElementById("s5").src = "../imagens/star1.png";
      avaliacao = 5;
  }
  
  //ESTRELA 4
 if (estrela == 4){ 
  document.getElementById("s1").src = "../imagens/star1.png";
  document.getElementById("s2").src = "../imagens/star1.png";
  document.getElementById("s3").src = "../imagens/star1.png";
  document.getElementById("s4").src = "../imagens/star1.png";
  document.getElementById("s5").src = "../imagens/star0.png";
  avaliacao = 4;
  }
 
 //ESTRELA 3
 if (estrela == 3){ 
  document.getElementById("s1").src = "../imagens/star1.png";
  document.getElementById("s2").src = "../imagens/star1.png";
  document.getElementById("s3").src = "../imagens/star1.png";
  document.getElementById("s4").src = "../imagens/star0.png";
  document.getElementById("s5").src = "../imagens/star0.png";
  avaliacao = 3;
  }
  
 //ESTRELA 2
 if (estrela == 2){ 
  document.getElementById("s1").src = "../imagens/star1.png";
  document.getElementById("s2").src = "../imagens/star1.png";
  document.getElementById("s3").src = "../imagens/star0.png";
  document.getElementById("s4").src = "../imagens/star0.png";
  document.getElementById("s5").src = "../imagens/star0.png";
  avaliacao = 2;
  }
  
  //ESTRELA 1
 if (estrela == 1){ 
  document.getElementById("s1").src = "../imagens/star1.png";
  document.getElementById("s2").src = "../imagens/star0.png";
  document.getElementById("s3").src = "../imagens/star0.png";
  document.getElementById("s4").src = "../imagens/star0.png";
  document.getElementById("s5").src = "../imagens/star0.png";
  avaliacao = 1;
  }
  
  document.getElementById('rating').innerHTML = avaliacao;
  
 }

//funcionalidade comentar

const openModalButton = document.querySelector("#open-modal");
const closeModalButton = document.querySelector("#close-modal");
const modal = document.querySelector("#modal");
const fade = document.querySelector("#fade");

const toggleModal = () => {
  modal.classList.toggle("hide");
  fade.classList.toggle("hide");
};

[openModalButton, closeModalButton, fade].forEach((el) => {
  el.addEventListener("click", () => toggleModal());
});

//funcionalidade avaliar modal

const openModalButtonAvaliar = document.querySelector("#open-modal-avaliar");
const closeModalButtonAvaliar = document.querySelector("#close-modal-avaliar");
const modalAvaliar = document.querySelector("#modal-avaliar");
const fadeAvaliar = document.querySelector("#fade-avaliar");

const toggleModalAvaliar = () => {
  modalAvaliar.classList.toggle("hide");
  fadeAvaliar.classList.toggle("hide");
};

[openModalButtonAvaliar, closeModalButtonAvaliar, fadeAvaliar].forEach((el) => {
  el.addEventListener("click", () => toggleModalAvaliar());
});