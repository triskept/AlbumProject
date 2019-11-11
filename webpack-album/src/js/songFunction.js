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
        const addDuration = event.target.parentElement.querySelector(
            ".add-song_songDuration"        
        ).value;
    

        console.log(addSong);
        apiActions.postRequest
        ("https://localhost:44342/api/song", 
        {
            title: addSong,
            duration: addDuration,
        //    albumId: 4
        },
        songs => {
            console.log(songs);
            document.querySelector("#app").innerHTML = Song(songs);
        }
        )    
    }
});
app.addEventListener("click", function() {
    if(event.target.classList.contains("delete-song_submit")) {
        const songId = event.target.parentElement.querySelector(".song_id").value;
        console.log("delete" + songId);
        apiActions.deleteRequest(`https://localhost:44342/api/song/${songId}`,
            songs => {
                app.innerHTML = Song(songs);
            })       
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("edit-song_submit")) {
        const songId = event.target.parentElement.querySelector(".song_id").value;
        console.log("edit" + songId);
        apiActions.getRequest(`https://localhost:44342/api/song/${songId}`, songEDIT => {
                app.innerHTML = EditSong(songEDIT);
        })        
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-song_submit")) {
    const songId = event.target.parentElement.querySelector(
        ".update-song_id").value;
    const songTitle = event.target.parentElement.querySelector(
        ".update-song_title").value;
    const songDuration = event.target.parentElement.querySelector(
        ".update-song_duration").value;    
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
