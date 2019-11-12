import Album from "./components/Album"
import EditAlbum from "./components/EditAlbum"
import apiActions from "./api/apiActions"
import AlbumSongs from "./components/AlbumSongs"

export default () => {
    displayAlbum()
}

function displayAlbum(){
    const albumButton = document.querySelector("#albumbrowse");
    albumButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44342/api/album", albums => {
            document.querySelector("#app").innerHTML = Album(albums);
            console.log(albums);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("albumIMG")){
        const albumId = event.target.parentElement.querySelector(".album_id").value;
        apiActions.getRequest(`https://localhost:44342/api/album/${albumId}`, album => {
            document.querySelector("#app").innerHTML = AlbumSongs(album);
            console.log(album);
        });
    }
    });

    // const app = document.querySelector("#app");
    app.addEventListener("click", function(){
    if(event.target.classList.contains("add-album_submit")){
        const addAlbum = event.target.parentElement.querySelector(
            ".add-album_albumTitle"        
        ).value;
        const addAlbumArtist = event.target.parentElement.querySelector(
            ".add-album_artist"
        ).value;
        const addAlbumLabel = event.target.parentElement.querySelector(
            ".add-album_Label"
        ).value;
        const addAlbumImage = "./images/photo-g.jfif"
        console.log(addAlbum);
        apiActions.postRequest
        ("https://localhost:44342/api/album", 
        {
            title: addAlbum,
            artistId: addAlbumArtist,
            label: addAlbumLabel,
            image: addAlbumImage
        },
        albums => {
            console.log(albums);
            document.querySelector("#app").innerHTML = Album(albums);
        }
        )    
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("delete-album_submit")) {
        const albumId = event.target.parentElement.querySelector(".album_id").value;
        console.log("delete" + albumId);
        apiActions.deleteRequest(`https://localhost:44342/api/album/${albumId}`,
            albums => {
                app.innerHTML = Album(albums);
            })       
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("edit-album_submit")) {
        const albumId = event.target.parentElement.querySelector(".album_id").value;
        console.log("edit" + albumId);
        apiActions.getRequest(`https://localhost:44342/api/album/${albumId}`, albumEDIT => {
                app.innerHTML = EditAlbum(albumEDIT);
        })        
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-album_submit")) {
    const albumId = event.target.parentElement.querySelector(
        ".update-album_id").value;
    const albumTitle = event.target.parentElement.querySelector(
        ".update-album_title").value;
    const albumArtist = event.target.parentElement.querySelector(
        ".update-album_artist").value;
    const albumLabel = event.target.parentElement.querySelector(
        ".update-album_label").value;    
    const addAlbumImage = "./images/photo-g.jfif"
     
    const albumData = {
        id: albumId,
        title: albumTitle,
        artistId: albumArtist,
        label: albumLabel,
        image: addAlbumImage
    };

    apiActions.putRequest(
        `https://localhost:44342/api/album/${albumId}`,
    albumData,
    albums => {
        document.querySelector("#app").innerHTML = Album(albums);
        })
    }
});
}