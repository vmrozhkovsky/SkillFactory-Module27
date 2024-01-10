document.getElementById("search").oninput = function() {searchFunction()};
function searchFunction() {
    let searchText = document.getElementById('search').value;
    let videoElements = document.body.getElementsByClassName('video-container');
    for (let i = 0; i < videoElements.length; i++)
    {
        let videoDescription = videoElements[i].querySelector(".video-title").innerText;
        if (!(videoDescription.toLowerCase().includes(searchText.toLowerCase()))){
            videoElements[i].style.display = 'none';
        }
        else {
            videoElements[i].style.display = 'inline-block';
        }
    }
}