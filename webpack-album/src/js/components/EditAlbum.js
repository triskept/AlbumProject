export default function EditAlbum(albumEDIT) {
    
    return `
        <section class='main-content_albumEDIT'>
        <h3>${albumEDIT.title}</h3>  
        </section>

        <section class='update-album'>
        <input class='update-album_title' type='text' value="${albumEDIT.title}">
        <select class= 'update-album_artist' name="Artist">
        <option value="1">Kid Cudi</option>
        <option value="2">Imagine Dragons</option>
        <option value="3">Pink Floyd</option>
        <option value="4">Alicia Keys</option>
        </select>    
        <input class='update-album_label' type='text' value="${albumEDIT.label}">
        <button class='update-album_submit'>Save Changes</button>
        <input class='update-album_id' type='hidden' value="${albumEDIT.id}">
        </section>
        `;
}