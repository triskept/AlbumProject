export default function Album(albums) {
    return `
    <ul> 
    ${albums
      .map(album => {
        return `
             <li>
                <img src=${album.image}></img>
                <h3>${album.title}</h3>
                <h5>Label: ${album.label}</h5>               
             </li>
        `;
      })
      .join("")}
 </ul>
 
<section class='add-album'>
    <input class='add-album_albumTitle' type='text' placeholder='Add A New Album!'>
    <select class= 'add-album_artist' name="Artist">
    <option value="1">Kid Cudi</option>
    <option value="2">Imagine Dragons</option>
    <option value="3">Pink Floyd</option>
    <option value="4">Alicia Keys</option>
    </select>
    <button class='add-album_submit'>Submit</button>
</section>
    `;
}