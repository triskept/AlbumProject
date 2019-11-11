export default function Album(albums) {
    return `

<section id="albumgrid">    
<ul> 
    ${albums
      .map(albumEdit => {
        return `
             <li id="album">
                <img src=${albumEdit.image}></img>
                <h3>${albumEdit.title}</h3>
                <h5>${albumEdit.artistName}<h5>
                <h5>Label: ${albumEdit.label}</h5>          
                <p><input class="album_id" type="hidden" value="${albumEdit.id}"></p>
                <button class="edit-album_submit">Edit</button>
                <button class="delete-album_submit">Delete</button>
             </li>
        `;
      })
      .join("")}
 </ul>
 </section>

<section class='add-album'>
    <input class='add-album_albumTitle' type='text' placeholder='Add A New Album!'>
    <select class= 'add-album_artist' name="Artist">
    <option value="1">Kid Cudi</option>
    <option value="2">Imagine Dragons</option>
    <option value="3">Pink Floyd</option>
    <option value="4">Alicia Keys</option>
    </select>
    <input class='add-album_Label' type='text' placeholder='Add A New Label!'>
    <button class='add-album_submit'>Submit</button>
</section>
    `;
}