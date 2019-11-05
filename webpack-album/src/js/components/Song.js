export default function Song(songs) {
    return `
    <ul> 
    ${songs
      .map(song => {
        return `
             <li>
                <h3>${song.title}</h3>
                <h5>Duration: ${song.duration}</h5>
                </li>
        `;
      })
      .join("")}
 </ul>
 
<section class='add-song'>
    <input class='add-song_songTitle' type='text' placeholder='Add A New Song!'>
    <button class='add-song_submit'>Submit</button>
</section>
    `;
}