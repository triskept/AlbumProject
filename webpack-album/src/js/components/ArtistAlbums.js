export default function ArtistAlbum(artist) {
    return `
    <section class='main-content_artistEDIT'>
    <h3>Artist: ${artist.name}</h3>  
    <img id="artistIMG" src=${artist.image}></img>
    </section>

    <section id="albumgrid">    
<ul> 
    ${artist.albums
      .map(album => {
        return `
             <li id="album">
                <img src=${album.image}></img>
                <h3>${album.title}</h3>
                <p><input class="album_id" type="hidden" value="${album.id}"></p>
             </li>
        `;
      })
      .join("")}
 </ul>
 </section>
    `
};