export default function EditArtist(artistEDIT) {
    
    return `
<<<<<<< HEAD
        <section class='main-content_artistEDIT'>
        <h3>Artist: ${artistEDIT.name}</h3>  
=======
        <section class='main-content__artistEDIT'>
        <h3>${artistEDIT.name}</h3>  
>>>>>>> 50e727240ea08a8f529e9b2522485467d5966582
        <h3>Age: ${artistEDIT.age}</h3>
        <h3>Hometown: ${artistEDIT.hometown}</h3>
        <img id="artistIMG" src=${artistEDIT.image}></img>
        </section>

        <section class='update-artist'>
<<<<<<< HEAD
        <img src=${artistEDIT.image}></img>
        <input class='update-artist_name' type='text' value="${artistEDIT.name}">
        <input class='update-artist_age' type='text' value="${artistEDIT.age}">
        <input class='update-artist_home' type='text' value="${artistEDIT.hometown}">
        <button class='update-artist_submit'>Save Changes</button>
        <input class='update-artist_id' type='hidden' value="${artistEDIT.id}">
=======
        <input class='update-artist__name' type='text' value="${artistEDIT.name}">
        <input class='update-artist__age' type='text' value="${artistEDIT.age}">
        <input class='update-artist__home' type='text' value="${artistEDIT.hometown}">
        <button class='update-artist__submit'>Save Changes</button>
        <input class='update-artist__id' type='hidden' value="${artistEDIT.id}">
>>>>>>> 50e727240ea08a8f529e9b2522485467d5966582
        </section>
        `;
}