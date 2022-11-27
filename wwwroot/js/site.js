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
    var url = window.location;
    url = url.toString()
    url = url.split("Index.cshtml");
    url = url[0];
   
    var s1 = document.getElementById("s1").src;
    var s2 = document.getElementById("s2").src;
    var s3 = document.getElementById("s3").src;
    var s4 = document.getElementById("s4").src;
    var s5 = document.getElementById("s5").src;
    var avaliacao = 0;
   
   if (estrela == 5){ 
    if (s5 == url + "../imagens/star0.png") {
    document.getElementById("s1").src = "../imagens/star1.png";
    document.getElementById("s2").src = "../imagens/star1.png";
    document.getElementById("s3").src = "../imagens/star1.png";
    document.getElementById("s4").src = "../imagens/star1.png";
    document.getElementById("s5").src = "../imagens/star1.png";
    avaliacao = 5;
    } else {
    document.getElementById("s1").src = "../imagens/star1.png";
    document.getElementById("s2").src = "../imagens/star1.png";
    document.getElementById("s3").src = "../imagens/star1.png";
    document.getElementById("s4").src = "../imagens/star1.png";
    document.getElementById("s5").src = "../imagens/star0.png";
    avaliacao = 4;
   }}
    
    //ESTRELA 4
   if (estrela == 4){ 
    if (s4 == url + "../imagens/star0.png") {
    document.getElementById("s1").src = "../imagens/star1.png";
    document.getElementById("s2").src = "../imagens/star1.png";
    document.getElementById("s3").src = "../imagens/star1.png";
    document.getElementById("s4").src = "../imagens/star1.png";
    document.getElementById("s5").src = "../imagens/star0.png";
    avaliacao = 4;
    } else {
    document.getElementById("s1").src = "../imagens/star1.png";
    document.getElementById("s2").src = "../imagens/star1.png";
    document.getElementById("s3").src = "../imagens/star1.png";
    document.getElementById("s4").src = "../imagens/star0.png";
    document.getElementById("s5").src = "../imagens/star0.png";
    avaliacao = 3;
   }}
   
   //ESTRELA 3
   if (estrela == 3){ 
    if (s3 == url + "../imagens/star0.png") {
    document.getElementById("s1").src = "../imagens/star1.png";
    document.getElementById("s2").src = "../imagens/star1.png";
    document.getElementById("s3").src = "../imagens/star1.png";
    document.getElementById("s4").src = "../imagens/star0.png";
    document.getElementById("s5").src = "../imagens/star0.png";
    avaliacao = 3;
    } else {
    document.getElementById("s1").src = "../imagens/star1.png";
    document.getElementById("s2").src = "../imagens/star1.png";
    document.getElementById("s3").src = "../imagens/star0.png";
    document.getElementById("s4").src = "../imagens/star0.png";
    document.getElementById("s5").src = "../imagens/star0.png";
    avaliacao = 2;
   }}
    
   //ESTRELA 2
   if (estrela == 2){ 
    if (s2 == url + "../imagens/star0.png") {
    document.getElementById("s1").src = "../imagens/star1.png";
    document.getElementById("s2").src = "../imagens/star1.png";
    document.getElementById("s3").src = "../imagens/star0.png";
    document.getElementById("s4").src = "../imagens/star0.png";
    document.getElementById("s5").src = "../imagens/star0.png";
    avaliacao = 2;
    } else {
    document.getElementById("s1").src = "../imagens/star1.png";
    document.getElementById("s2").src = "../imagens/star0.png";
    document.getElementById("s3").src = "../imagens/star0.png";
    document.getElementById("s4").src = "../imagens/star0.png";
    document.getElementById("s5").src = "../imagens/star0.png";
    avaliacao = 1;
   }}
    
    //ESTRELA 1
   if (estrela == 1){ 
    if (s1 == url + "../imagens/star0.png") {
    document.getElementById("s1").src = "../imagens/star1.png";
    document.getElementById("s2").src = "../imagens/star0.png";
    document.getElementById("s3").src = "../imagens/star0.png";
    document.getElementById("s4").src = "../imagens/star0.png";
    document.getElementById("s5").src = "../imagens/star0.png";
    avaliacao = 1;
    } else {
    document.getElementById("s1").src = "../imagens/star0.png";
    document.getElementById("s2").src = "../imagens/star0.png";
    document.getElementById("s3").src = "../imagens/star0.png";
    document.getElementById("s4").src = "../imagens/star0.png";
    document.getElementById("s5").src = "../imagens/star0.png";
    avaliacao = 0;
   }}
    
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