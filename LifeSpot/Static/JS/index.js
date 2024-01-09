document.getElementById("search").oninput = function() {myFunction()};

function myFunction() {
    console.log('Start');
    let elements = document.getElementsByTagName('input');
    let element = elements[0];
    let elementText = element.value;
    let videoElements = document.body.getElementsByClassName('video-container');
    for (let i = 0; i < videoElements.length; i++)
    {
        let childElements = videoElements[i];
        let videoDescription = childElements.getElementsByTagName('h3')[0];
        if (!(videoDescription.innerText.toLowerCase().includes(elementText.toLowerCase()))){
            videoElements[i].style.display = 'none';
        }
    }
}