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
var stars = document.querySelectorAll('.star-icon');
                  
document.addEventListener('click', function(e){
  var classStar = e.target.classList;
  if(!classStar.contains('ativo')){
    stars.forEach(function(star){
      star.classList.remove('ativo');
    });
    classStar.add('ativo');
    console.log(e.target.getAttribute('data-avaliacao'));
  }
});

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