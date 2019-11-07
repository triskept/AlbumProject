import Header from "./components/Header"
import Footer from "./components/Footer"
import Nav from "./components/Nav"
import HomeGrid from "./components/HomeGrid"
import Artist from "./components/Artist"
import EditArtist from "./components/EditArtist"
import Album from "./components/Album"
import EditAlbum from "./components/EditAlbum"
import Song from "./components/Song"
import EditSong from "./components/EditSong"
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
    displayHome();
    artistNAV();
    albumNAV();
    songNAV();
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

function displayHome(){
    const homeButton = document.querySelector("#Home");
    homeButton.addEventListener("click", function(){
        homegrid()
    });
}
//NAV functions
function artistNAV(){
    const navArtist = document.querySelector("#Artists");
    navArtist.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44342/api/artist", artists => {
            document.querySelector("#app").innerHTML = Artist(artists);
            console.log(artists);
        });
    });
}
function albumNAV(){
    const navAlbum = document.querySelector("#Albums");
    navAlbum.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44342/api/album", albums => {
            document.querySelector("#app").innerHTML = Album(albums);
            console.log(albums);
        });
    });
}
function songNAV(){
    const navSong = document.querySelector("#Songs");
    navSong.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44342/api/song", songs => {
            document.querySelector("#app").innerHTML = Song(songs);
            console.log(songs);
        });
    });
}
//artist functions
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
            ".add-artist_artistName").value;
        const addArtistAge = event.target.parentElement.querySelector(
            ".add-artist_artistAge").value;
        const addArtistHometown = event.target.parentElement.querySelector(
            ".add-artist_artistHome").value;
        const addArtistImage = "./images/photo-g.jfif"
    
        console.log(addArtist);
        apiActions.postRequest("https://localhost:44342/api/artist", 
        {
            name: addArtist,
            age: addArtistAge,
            hometown: addArtistHometown,
            image: addArtistImage
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
        const artistId = event.target.parentElement.querySelector(".artist__id").value;
        console.log("delete" + artistId);
        apiActions.deleteRequest(`https://localhost:44342/api/artist/${artistId}`,
            artists => {
                app.innerHTML = Artist(artists);
            })       
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("edit-artist__submit")) {
        const artistId = event.target.parentElement.querySelector(".artist__id").value;
        console.log("edit" + artistId);
        apiActions.getRequest(`https://localhost:44342/api/artist/${artistId}`, artistEDIT => {
                app.innerHTML = EditArtist(artistEDIT);
        })        
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-artist__submit")) {
    const artistId = event.target.parentElement.querySelector(
        ".update-artist__id").value;
    const artistName = event.target.parentElement.querySelector(
        ".update-artist__name").value;
    const artistAge = event.target.parentElement.querySelector(
        ".update-artist__age").value;
    const artistHometown = event.target.parentElement.querySelector(
        ".update-artist__home").value;
    const addArtistImage = "./images/photo-g.jfif"
     
    const artistData = {
        id: artistId,
        name: artistName,
        age: artistAge,
        hometown: artistHometown,
        image: addArtistImage
    };

    apiActions.putRequest(
        `https://localhost:44342/api/artist/${artistId}`,
    artistData,
    artists => {
        document.querySelector("#app").innerHTML = Artist(artists);
        })
    }
});
}
//album functions
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
        const addAlbumLabel = event.target.parentElement.querySelector(
            ".add-album_Label"
        ).value;
        console.log(addAlbum);
        apiActions.postRequest
        ("https://localhost:44342/api/album", 
        {
            title: addAlbum,
            artistId: addAlbumArtist,
            label: addAlbumLabel
        },
        albums => {
            console.log(albums);
            document.querySelector("#app").innerHTML = Album(albums);
        }
        )    
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("delete-album__submit")) {
        const albumId = event.target.parentElement.querySelector(".album__id").value;
        console.log("delete" + albumId);
        apiActions.deleteRequest(`https://localhost:44342/api/album/${albumId}`,
            albums => {
                app.innerHTML = Album(albums);
            })       
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("edit-album__submit")) {
        const albumId = event.target.parentElement.querySelector(".album__id").value;
        console.log("edit" + albumId);
        apiActions.getRequest(`https://localhost:44342/api/album/${albumId}`, albumEDIT => {
                app.innerHTML = EditAlbum(albumEDIT);
        })        
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-album__submit")) {
    const albumId = event.target.parentElement.querySelector(
        ".update-album__id").value;
    const albumTitle = event.target.parentElement.querySelector(
        ".update-album__title").value;
    const albumArtist = event.target.parentElement.querySelector(
        ".update-album__artist").value;
    const albumLabel = event.target.parentElement.querySelector(
        ".update-album__label").value;    
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
//song functions
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
