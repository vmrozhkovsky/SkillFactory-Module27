document.getElementById("search").oninput = function() {searchFunction(document.getElementById('search').value)};
function searchFunction(searchText) {
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