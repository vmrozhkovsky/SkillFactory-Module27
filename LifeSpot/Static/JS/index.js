let userData = new Map();
function getUserData (){

    let userAgentString = window.navigator.userAgent;
    let userName = prompt('Введите своё имя:');
    userData.set('UserAgentString', userAgentString)
            .set('UserName', userName)
}
function ageCheck (){
    let userAge = prompt('Введите свой возраст:');
    userData.set('UserAge', userAge)
    if (userAge < 18){
        alert('Ваш возраст меньше 18 лет!');
        window.location.href = "http://www.google.com";
    }
}