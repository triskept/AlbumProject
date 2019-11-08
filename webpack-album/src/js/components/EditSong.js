export default function EditSong(songEDIT) {
    
    return `
        <section class='main-content__songEDIT'>
        <h3>${songEDIT.title}</h3>  
        </section>

        <section class='update-song'>
        <input class='update-song__title' type='text' value="${songEDIT.title}">
        <input class='update-song__duration' type='text' value="${songEDIT.duration}">
        <button class='update-song__submit'>Save Changes</button>
        <input class='update-song__id' type='hidden' value="${songEDIT.id}">
        </section>
        `;
}