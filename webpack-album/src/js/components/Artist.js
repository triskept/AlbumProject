export default function Artist(artists) {
    return `
    <ul> 
    ${artists
      .map(artist => {
        return `
             <li>
                <img src=${artist.image}></img>
                <h3>${artist.name}</h3>
                <h5>Age: ${artist.age}</h5>
                <h5>Hometown: ${artist.hometown}</h5>
             </li>
        `;
      })
      .join("")}
 </ul>
 
<section class='add-artist'>
    <input class='add-artist_artistName' type='text' placeholder='Add A New Artist!'>
    <button class='add-artist_submit'>Submit</button>
</section>
    `;
}