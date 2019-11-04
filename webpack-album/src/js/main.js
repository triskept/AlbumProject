import Header from "./components/Header"
import Footer from "./components/Footer"
import Nav from "./components/Nav"
import HomeGrid from "./components/HomeGrid"
import Artist from "./components/Artist"
import apiActions from "./api/apiActions"

export default() => {
    pageBuild1()
}

function pageBuild1(){
    // nav()
    header();
    homegrid();
    footer();
    displayArtist();
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