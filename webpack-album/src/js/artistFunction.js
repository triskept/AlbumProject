import Artist from "./components/Artist"
import EditArtist from "./components/EditArtist"
import apiActions from "./api/apiActions"

export default () => {
    displayArtist()
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