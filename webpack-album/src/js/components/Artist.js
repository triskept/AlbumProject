export default function Artist(artists) {
    return `
    <ul> 
    ${artists
      .map(artist => {
        return `
             <li id="artist">
                <img src=${artist.image}></img>
                <h3>${artist.name}</h3>
                <h5>Age: ${artist.age}</h5>
                <h5>Hometown: ${artist.hometown}</h5>
                <input class="artist__id" type="hidden" value="${artist.id}">
                </li>
                <div id="EDArtist">
                  <button class="edit-artist__submit">Edit</button>
                  <button class="delete-artist__submit">Delete</button>
                </div>
        `;
      })  
      .join("")}
 </ul>
 
<section class='add-artist'>
    <input class='add-artist_artistName' type='text' placeholder='Add A New Artist!'>
    <input class='add-artist_artistAge' type='text' placeholder='Add An Artist Age!'>
    <input class='add-artist_artistHome' type='text' placeholder='Add An Artist Hometown!'>
    <button class='add-artist_submit'>Submit</button>
</section>
    `;
}