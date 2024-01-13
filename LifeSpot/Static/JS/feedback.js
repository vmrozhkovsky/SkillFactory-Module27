function getFeedback () {
    let feedback = {};
    
    feedback['UserName'] = prompt("Введите Ваше имя:");
    if(feedback["UserName"] == null){
        return
    }

    feedback['UserFeedbackText'] = prompt("Напишите свой отзыв:");
    if(feedback['UserFeedbackText'] == null){
        return
    }
    
    feedback['FeedbackDate'] = new Date().toLocaleString();

    if(confirm('Разрешить пользователям оценивать ваш отзыв?')){
        let feedbackWithRating = Object.create(feedback);
        feedbackWithRating['Rating'] = 0;
        writeFeedback(feedbackWithRating);
    } else{
        writeFeedback(feedback);
    }
}
const writeFeedback = feedback => {
    let ratingCounter = '';
    if (feedback.hasOwnProperty('Rating')){
        ratingCounter += '           <b style="color: chocolate">Рейтинг:</b>   ' + feedback.Rating;
    }
    document.getElementsByClassName('feedback')[0].innerHTML += '    <div class="review-text">\n' +
        `<p> <i> <b>${feedback['UserName']}</b>  ${feedback['FeedbackDate']}${ratingCounter}</i></p>` +
        `<p>${feedback['UserFeedbackText']}</p>`  +
        '</div>';
}