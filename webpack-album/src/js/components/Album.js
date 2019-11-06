export default function Album(albums) {
    return `
    <section id="albumgrid">
      <ul> 
      ${albums
        .map(album => {
          return `
              <li id="album">
                  <img src=${album.image}></img>
              </li>
          `;
        })
        .join("")}
  </ul>
 </section>
<section class='add-album'>
    <input class='add-album_albumTitle' type='text' placeholder='Add A New Album!'>
    <button class='add-album_submit'>Submit</button>
</section>
    `;
}