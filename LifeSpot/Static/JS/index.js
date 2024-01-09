// let userAge = prompt("Введите свой реальный возраст");
// if (userAge < 18) {
//     window.location.href = "http://www.google.com";}
// else {
//     alert("Приветствуем на LifeSpot! " + new Date().toLocaleString());}
document.getElementsByName("").addEventListener("input", myFunction);

function myFunction() {
    document.getElementById("demo").innerHTML = "The value of the input field was changed.";
}