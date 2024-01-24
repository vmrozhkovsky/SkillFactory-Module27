function Feedback () {
    this.UserName = prompt("Введите Ваше имя:");
    if (this.UserName == null) {
        return
    }

    this.UserFeedbackText = prompt("Напишите свой отзыв:");
    if (this.UserFeedbackText == null) {
        return
    }

    this.FeedbackDate = new Date().toLocaleString();
}
function GetFeedback (){
    let feedback = new Feedback();
    if(confirm('Разрешить пользователям оценивать ваш отзыв?')){
    feedback['Rating'] = 0;
}
    writeFeedback(feedback);
}
function addLike(id){
    let element = document.getElementById(id);
    let array = element.innerText.split(' ')
    let resultNum = parseInt(array[array.length - 1], 10);
    resultNum += 1
    array[array.length - 1] =  `${resultNum}`
    element.innerText = array.join(' ')
}
const writeFeedback = feedback => {
    let ratingCounter = '';
    if (feedback.hasOwnProperty('Rating')){
        let feedbackId = Math.random();
        ratingCounter += '<button class="rating" id="' + feedbackId + '" onclick="addLike(this.id)">' + `❤️ ${feedback.Rating}</button>`;
    }
    document.getElementsByClassName('feedback')[0].innerHTML += '    <div class="review-text">\n' +
        `<p> <i> <b>${feedback['UserName']}</b>  ${feedback['FeedbackDate']} ${ratingCounter}</i></p>` +
        `<p>${feedback['UserFeedbackText']}</p>`  +
        '</div>';
}