import Song from "./components/song"
import EditSong from "./components/EditSong"
import apiActions from "./api/apiActions"

export default () => {
    displaySong()
}

function displaySong(){
    const songButton = document.querySelector("#songbrowse");
    songButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44342/api/song", songs => {
            document.querySelector("#app").innerHTML = Song(songs);
            console.log(songs);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
    if(event.target.classList.contains("add-song_submit")){
        const addSong = event.target.parentElement.querySelector(
            ".add-song_songTitle"        
        ).value;

        console.log(addSong);
        apiActions.postRequest
        ("https://localhost:44342/api/song", 
        {
            title: addSong,
           albumId: 4
        },
        songs => {
            console.log(songs);
            document.querySelector("#app").innerHTML = Song(songs);
        }
        )    
    }
});
app.addEventListener("click", function() {
    if(event.target.classList.contains("delete-song__submit")) {
        const songId = event.target.parentElement.querySelector(".song__id").value;
        console.log("delete" + songId);
        apiActions.deleteRequest(`https://localhost:44342/api/song/${songId}`,
            songs => {
                app.innerHTML = Song(songs);
            })       
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("edit-song__submit")) {
        const songId = event.target.parentElement.querySelector(".song__id").value;
        console.log("edit" + songId);
        apiActions.getRequest(`https://localhost:44342/api/song/${songId}`, songEDIT => {
                app.innerHTML = EditSong(songEDIT);
        })        
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-song__submit")) {
    const songId = event.target.parentElement.querySelector(
        ".update-song__id").value;
    const songTitle = event.target.parentElement.querySelector(
        ".update-song__title").value;
    const songDuration = event.target.parentElement.querySelector(
        ".update-song__duration").value;    
    // const songAlbum = event.target.parentElement.querySelector(
    //     ".update-song__album").value;
     
    const songData = {
        id: songId,
        title: songTitle,
        duration: songDuration
        // albumId: songArtist,
    };

    apiActions.putRequest(
        `https://localhost:44342/api/song/${songId}`,
    songData,
    songs => {
        document.querySelector("#app").innerHTML = Song(songs);
        })
    }
});
}
