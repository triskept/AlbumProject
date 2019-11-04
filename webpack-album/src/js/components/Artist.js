export default function Artist(artists) {
alert(artists)
    return `
    <ul> 
    ${artists
      .map(artist => {
        return `
             <li>
                <h3>${artist.name}</h3>
                <h4>${artist.age}</h4>
                <h4>${artist.hometown}</h4>
                <h4>${artist.image}</h4>
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