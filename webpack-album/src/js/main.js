import Header from "./components/Header"
import Footer from "./components/Footer"
import Nav from "./components/Nav"
import HomeGrid from "./components/HomeGrid"
import displayArtist from "./artistFunction"
import Artist from "./components/Artist"
// import EditArtist from "./components/EditArtist"
import displayAlbum from "./albumFunction"
import Album from "./components/Album"
// import EditAlbum from "./components/EditAlbum"
import displaySong from "./songFunction"
import Song from "./components/Song"
// import EditSong from "./components/EditSong"
import apiActions from "./api/apiActions"
import AllAlbum from "./components/AllAlbums"

export default () => {
    pageBuild()
}

function pageBuild(){
    nav()
    header();
    homegrid();
    footer();
    artistAction();
    albumAction();
    songAction();
    displayHome();
    artistNAV();
    albumNAV();
    songNAV();
    AllAlbum();
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
function artistAction(){
    displayArtist()
}

function albumAction(){
    displayAlbum()
}

function songAction(){
    displaySong()
}

function allAlbums(){
    AllAlbum()
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
