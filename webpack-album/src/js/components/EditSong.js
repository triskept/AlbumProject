export default function EditSong(songEDIT) {
    
    return `
        <section class='main-content_songEDIT'>
        <h3>${songEDIT.title}</h3>  
        </section>

        <section class='update-song'>
        <input class='update-song_title' type='text' value="${songEDIT.title}">
        <input class='update-song_duration' type='text' value="${songEDIT.duration}">
        <button class='update-song_submit'>Save Changes</button>
        <input class='update-song_id' type='hidden' value="${songEDIT.id}">
        </section>
        `;
}