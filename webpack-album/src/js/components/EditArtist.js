export default function EditArtist(artistEDIT) {
    
    return `
        <section class='main-content_artistEDIT'>
        <h3>Artist: ${artistEDIT.name}</h3>  
        <h3>Age: ${artistEDIT.age}</h3>
        <h3>Hometown: ${artistEDIT.hometown}</h3>
        <h3>${artistEDIT.name}</h3>  
        </section>

        <section class='update-artist'>
        <img src=${artistEDIT.image}></img>
        <input class='update-artist_name' type='text' value="${artistEDIT.name}">
        <input class='update-artist_age' type='text' value="${artistEDIT.age}">
        <input class='update-artist_home' type='text' value="${artistEDIT.hometown}">
        <button class='update-artist_submit'>Save Changes</button>
        <input class='update-artist_id' type='hidden' value="${artistEDIT.id}">
        </section>
        `;
}