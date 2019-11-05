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
    <button class='add-album_submit'>Submit</button>
</section>
    `;
}