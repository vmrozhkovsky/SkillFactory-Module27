function getFeedback () {
    let feedback = {};
    
    feedback["UserName"] = prompt("Введите Ваше имя:");
    if(feedback["UserName"] == null){
        return
    }

    feedback["UserFeedbackText"] = prompt("Напишите свой отзыв:");
    if(feedback["UserFeedbackText"] == null){
        return
    }
    
    feedback["FeedbackDate"] = new Date().toLocaleString();
    
    writeFeedback(feedback);
}
const writeFeedback = feedback => {
    document.getElementsByClassName('feedback')[0].innerHTML += '    <div class="review-text">\n' +
        `<p> <i> <b>${feedback['UserName']}</b>  ${feedback['FeedbackDate']}</i></p>` +
        `<p>${feedback['UserFeedbackText']}</p>`  +
        '</div>';
}