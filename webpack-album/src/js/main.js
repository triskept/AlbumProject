import Header from "./components/Header"
import Footer from "./components/Footer"
import Nav from "./components/Nav"
import HomeGrid from "./components/HomeGrid"
import Artist from "./components/Artist"
import Album from "./components/Album"
import Song from "./components/Song"
import apiActions from "./api/apiActions"

export default () => {
    pageBuild()
}

function pageBuild(){
    nav()
    header();
    homegrid();
    footer();
    displayArtist();
    displayAlbum();
    displaySong();
}

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header()    
}
function footer(){
    const footer = document.getElementById("footer")
    footer.innerHTML = Footer()    
}
function nav(){
    const nav = document.getElementById("nav")
    nav.innerHTML = Nav()    
}
function homegrid(){
    const homegrid = document.getElementById("app")
    homegrid.innerHTML = HomeGrid()    
}
function displayArtist(){
    const artistButton = document.querySelector("#artistbrowse");
    artistButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44342/api/artist", artists => {
            document.querySelector("#app").innerHTML = Artist(artists);
            console.log(artists);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
    if(event.target.classList.contains("add-artist_submit")){
        const addArtist = event.target.parentElement.querySelector(
            ".add-artist_artistName"        
        ).value;

        console.log(addArtist);
        apiActions.postRequest
        ("https://localhost:44342/api/artist", 
        {
            name: addArtist
        },
        artists => {
            console.log(artists);
            document.querySelector("#app").innerHTML = Artist(artists);
        }
        )    
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("delete-artist__submit")) {
        const artistId = event.target.parentElement.querySelector(".artist__id")
        .value;
        console.log("delete" + artistId);
        apiActions.deleteRequest(
            `https://localhost:44342/api/artist/${artistId}`,
            artists => {
                app.innerHTML = Artist(artists);
            }
            )       
    }
});

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
    if(event.target.classList.contains("add-album_submit")){
        const addAlbum = event.target.parentElement.querySelector(
            ".add-album_albumTitle"        
        ).value;
        const addAlbumArtist = event.target.parentElement.querySelector(
            ".add-album_artist"
        ).value;
        console.log(addAlbum);
        apiActions.postRequest
        ("https://localhost:44342/api/album", 
        {
            title: addAlbum,
            artistId: addAlbumArtist
        },
        albums => {
            console.log(albums);
            document.querySelector("#app").innerHTML = Album(albums);
        }
        )    
    }
});
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
}
