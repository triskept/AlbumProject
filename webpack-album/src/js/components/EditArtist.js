export default function EditArtist(artistEDIT) {
    
    return `
        <section class='main-content__artistEDIT'>

        <h3>Artist: ${artistEDIT.name}</h3>  
        <h3>Age: ${artistEDIT.age}</h3>
        <h3>Hometown: ${artistEDIT.hometown}</h3>

        <h3>${artistEDIT.name}</h3>  

        </section>

        <section class='update-artist'>
        <img src=${artistEDIT.image}></img>
        <input class='update-artist__name' type='text' value="${artistEDIT.name}">
        <input class='update-artist__age' type='text' value="${artistEDIT.age}">
        <input class='update-artist__home' type='text' value="${artistEDIT.hometown}">
        <button class='update-artist__submit'>Save Changes</button>
        <input class='update-artist__id' type='hidden' value="${artistEDIT.id}">
        </section>
        `;
}