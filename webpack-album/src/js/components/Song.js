export default function Song(songs) {
    return `
    <section id="songgrid">
    <ul> 
    ${songs
      .map(songEdit => {
        return `
             <li>
                <h3>${songEdit.title}</h3>
                <h5>Duration: ${songEdit.duration}</h5>
              </li>
        `;
      })
      .join("")}
 </ul>
</section>
<section class='add-song'>
    <input class='add-song_songTitle' type='text' placeholder='Add A New Song!'>
    <input class='add-song_songDuration' type='text' placeholder='Add Song Duration 0:00!'>
    <button class='add-song_submit'>Submit</button>
</section>
    `;
}