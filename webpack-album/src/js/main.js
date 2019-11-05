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
}

function displayAlbum(){
    const albumButton = document.querySelector("#albumbrowse");
    albumButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44342/api/album", albums => {
            document.querySelector("#app").innerHTML = Album(albums);
            console.log(albums);
        });
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
}