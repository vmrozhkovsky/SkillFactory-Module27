function saveUserInput (){
let currentUserInput = document.getElementById('search').value;
alert(currentUserInput);
alert(`Предыдущий ввод: ${this.lastUserInput}\nТекущий ввод: ${currentUserInput}`);
this.lastUserInput = currentUserInput;
}