export default function AlbumSong(album) {
    return `
    <section class='main-content_albumEDIT'>
    <h3>Album: ${album.title}</h3>  
    <img id="albumIMG" src=${album.image}></img>
    </section>

    <section id="songgrid">
    <ul> 
    ${album.songs
      .map(song => {
        return `
             <li id="song">
                <h3>${song.title}</h3>
                <h5>Duration: ${song.duration}</h5>
                <p><input class="song_id" type="hidden" value="${song.id}"></p>
              </li>
        `;
      })
      .join("")}
 </ul>
</section>
    `
};