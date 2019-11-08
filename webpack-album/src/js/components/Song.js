import albumEdit from "./Album"

// function albuminfo()
// {
//   albumEdit(title)
// }

export default function Song(songs) {
    return `
    <section id="songgrid">
    <ul> 
    ${songs
      .map(songEdit => {
        return `
             <li>
                <h3>${songEdit.title}</h3>
                <h4>Album: ${albumEdit.title}</h4>
                <h5>Duration: ${songEdit.duration}</h5>
                <p><input class="song__id" type="hidden" value="${songEdit.id}"></p>
                <button class="edit-song__submit">Edit</button>
                <button class="delete-song__submit">Delete</button>
              </li>
        `;
      })
      .join("")}
 </ul>
</section>
<section class='add-song'>
      <select class="song-dropdown">
      <option value="1">Man On The Moon</option>
      <option value="2">Man On The Moon 2</option>
      <option value="7">Night Visions</option>
      <option value="11">The Division Bell</option>
      <option value="15">Songs in A Minor</option>
      </select>
    <input class='add-song_songTitle' type='text' placeholder='Add A New Song!'>
    <input class='add-song_songDuration' type='text' placeholder='Add Song Duration 0:00!'>
    <button class='add-song_submit'>Submit</button>
</section>
    `;
}