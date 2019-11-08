export default function EditArtist(artistEDIT) {
    
    return `
        <section class='main-content__artistEDIT'>
        <h3>${artistEDIT.name}</h3>  
        <h3>Age: ${artistEDIT.age}</h3>
        <h3>Hometown: ${artistEDIT.hometown}</h3>
        <img id="artistIMG" src=${artistEDIT.image}></img>
        </section>

        <section class='update-artist'>
        <input class='update-artist__name' type='text' value="${artistEDIT.name}">
        <input class='update-artist__age' type='text' value="${artistEDIT.age}">
        <input class='update-artist__home' type='text' value="${artistEDIT.hometown}">
        <button class='update-artist__submit'>Save Changes</button>
        <input class='update-artist__id' type='hidden' value="${artistEDIT.id}">
        </section>
        `;
}